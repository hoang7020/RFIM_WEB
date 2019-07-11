using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using RFIM_Web.Utils;

namespace RFIM_Web.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly MyDbContext ctx;
        public InvoiceController(MyDbContext db)
        {
            ctx = db;
        }

        public IActionResult ListAllInvoice()
        {
            var listInvoice = ctx.Invoices.Include(i => i.InvoiceType).Include(i => i.InvoiceStatus).ToList();
            return View(listInvoice);
        }
        //Return view create Invoice
        public IActionResult CreateInvoice()
        {
            ViewData["InvoiceTypeId"] = new SelectList(ctx.InvoiceTypes, "InvoiceTypeId", "InvoiceTypes");
            ViewData["InvoiceStatusId"] = new SelectList(ctx.InvoiceStatuses, "StatusId", "Status");
            ViewData["ProductId"] = new SelectList(ctx.Products, "ProductId", "ProductName");
            return View();
        }
        public IActionResult DetailInvoice(string id)
        {
            var productList = (from ip in ctx.Invoice_Products  
                           join p in ctx.Products on ip.ProductId equals p.ProductId
                           where ip.InvoiceId.Equals(id)
             select new ProductList
             {
                 ProductName = p.ProductName,
                 Quantity = ip.Quantity,
             }).ToList();
            var detail = ctx.Invoices.Include(it => it.InvoiceType).Include(it => it.InvoiceStatus).SingleOrDefault(i => i.InvoiceId.Equals(id));
            var model = new InvoiceDetail { Invoices = detail, productList = productList};
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateInvoice(IFormCollection form, Invoice invoice)
        {
            //get string form dynamic control
            string[] listProduct = form["listProduct"].ToString().Split(",");
            string[] listQuantity = form["listQuantity"].ToString().Split(",");
            int[] listQuantityParsed = listQuantity.Select(int.Parse).ToArray();
            string invoiceId = invoice.InvoiceId.ToString();
            List<MergeList> mergeList = new List<MergeList>();
            for (int i = 0; i < listProduct.Count(); i++)
            {
                MergeList ml = new MergeList();
                ml.ProductId = listProduct[i];
                ml.Quantity = listQuantityParsed[i];
                mergeList.Add(ml);
            }
            //Combine duplicated Product Code with Quantity sum
            var combine = new Dictionary<string, int>();
            foreach (var merge in mergeList)
            {
                if (combine.ContainsKey(merge.ProductId))
                    combine[merge.ProductId] += merge.Quantity;
                else
                    combine.Add(merge.ProductId, merge.Quantity);
            }     
            if (ModelState.IsValid)
            {
                //check if product id already existed 
                bool invoiceIdExist = ctx.Invoices.Any(i => i.InvoiceId == invoice.InvoiceId);
                //if product id is not existed
                if (!invoiceIdExist)
                {
                    invoice.StatusId = 1;
                    ctx.Add(invoice);
                    await ctx.SaveChangesAsync();
                    for (int i = 0; i < combine.Count(); i++)
                    {
                        Invoice_Product ip = new Invoice_Product();
                        ip.InvoiceId = invoiceId;
                        ip.ProductId = combine.ElementAt(i).Key;
                        ip.Quantity = combine.ElementAt(i).Value;
                        ip.ProcessQuantity = 0;
                        ctx.Add(ip);
                        await ctx.SaveChangesAsync();
                    } 
                    return RedirectToAction(nameof(ListAllInvoice));
                }
                //product id is existed
                else
                {
                    ModelState.AddModelError("", "Invoice Id already existed !!!");
                }
            }
            //if validation is error return view with error messages
            return View(invoice);

        }

        [HttpGet]
        public async Task<IActionResult> DeleteInvoice(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var invoice = await ctx.Invoices.Include(i => i.InvoiceType).Include(i => i.InvoiceStatus).SingleOrDefaultAsync(i => i.InvoiceId == id);
            if (invoice == null)
            {
                return NotFound();
            }
            if (invoice.InvoiceStatus.Status.Equals("Processing") || invoice.InvoiceStatus.Status.Equals("Done"))
            {
                return PartialView("DeleteFail",invoice);
            }
            else
            {
                return PartialView("DeleteInvoice", invoice);
            }
        }
        [HttpPost, ActionName("DeleteInvoice")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            ctx.Invoice_Products.RemoveRange(ctx.Invoice_Products.Where(x => x.InvoiceId.Equals(id)));
            var invoice = await ctx.Invoices.FindAsync(id);
            ctx.Invoices.Remove(invoice);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllInvoice));
        }

        public IActionResult BackToInvoiceList()
        {
            return RedirectToAction(nameof(ListAllInvoice));
        }
    }
}