using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        public IActionResult DetailInvoice(string id)
        {
            var productList = (from ip in ctx.Invoice_Products  
                           join p in ctx.Products on ip.ProductId equals p.ProductId
                           join c in ctx.Categories on p.CategoryId equals c.CategoryId
                           join v in ctx.Vendors on p.VendorId equals v.VendorId
                           where ip.InvoiceId.Equals(id)
             select new ProductList
             {
                 ProductId = p.ProductId,
                 ProductName = p.ProductName,
                 Quantity = ip.Quantity,
                 Category = c.CategoryName,
                 Vendor = v.VendorName
             }).ToList();
            var detail = ctx.Invoices.Include(it => it.InvoiceType).Include(it => it.InvoiceStatus).SingleOrDefault(i => i.InvoiceId.Equals(id));
            var model = new InvoiceDetail { Invoices = detail, productList = productList};
            return PartialView("InvoiceDetail", model);
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
                return PartialView("DeleteFail", invoice);
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

        public IActionResult CreateInvoiceStep1()
        {
            ViewData["InvoiceTypeId"] = new SelectList(ctx.InvoiceTypes, "InvoiceTypeId", "InvoiceTypes");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddInvoiceStep2(Invoice invoice)
        {
            ViewData["InvoiceTypeId"] = new SelectList(ctx.InvoiceTypes, "InvoiceTypeId", "InvoiceTypes");
            if (ModelState.IsValid)
            {
                if (ctx.Invoices.Any(i => i.InvoiceId == invoice.InvoiceId))
                {
                    ViewBag.invoceExist = "InvoiceId was already existed!";
                    return View("CreateInvoiceStep1", invoice);
                }
                else
                {
                    invoice.StatusId = 1;
                    invoice.Date = DateTime.Now;
                    ctx.Add(invoice);
                    await ctx.SaveChangesAsync();
                    HttpContext.Session.SetString("invoiceId", invoice.InvoiceId);
                    HttpContext.Session.Set<List<ProductInvoiceList>>("listProduct", null);
                    return RedirectToAction(nameof(RenderProductList));

                }
            }
            return View("CreateInvoiceStep1");
        }

        public IActionResult AddProductList()
        {
            if (HttpContext.Session.Get<List<ProductInvoiceList>>("listProduct") == null)
            {
                var listProduct = (from p in ctx.Products
                                   join c in ctx.Categories on p.CategoryId equals c.CategoryId
                                   join v in ctx.Vendors on p.VendorId equals v.VendorId
                                   where p.Status == true
                                   select new ProductInvoiceList
                                   {
                                       ProductId = p.ProductId,
                                       ProductName = p.ProductName,
                                       QuantityPerBox = p.QuantityPerBox,
                                       Description = p.Description,
                                       Category = c.CategoryName,
                                       Vendor = v.VendorName
                                   }).ToList();
                return PartialView("AddProductList", listProduct);
            }
            else
            {
                var listProduct = (from p in ctx.Products
                                   join c in ctx.Categories on p.CategoryId equals c.CategoryId
                                   join v in ctx.Vendors on p.VendorId equals v.VendorId
                                   where p.Status == true
                                   select new ProductInvoiceList
                                   {
                                       ProductId = p.ProductId,
                                       ProductName = p.ProductName,
                                       QuantityPerBox = p.QuantityPerBox,
                                       Description = p.Description,
                                       Category = c.CategoryName,
                                       Vendor = v.VendorName
                                   }).ToList();
                List<ProductInvoiceList> ssListProduct = HttpContext.Session.Get<List<ProductInvoiceList>>("listProduct");
                var listExcept = listProduct.Where(x => !ssListProduct.Any(z => z.ProductId == x.ProductId)).ToList<ProductInvoiceList>();
                return PartialView("AddProductList", listExcept);
            }
        }

        public IActionResult AddProductListFinished(IFormCollection fm)
        {
            string[] listProductId = fm["checkList"].ToString().Split(",");
            if(string.IsNullOrEmpty(listProductId[0]))
            {
                var listProductRedirect = (from p in ctx.Products
                                   join c in ctx.Categories on p.CategoryId equals c.CategoryId
                                   join v in ctx.Vendors on p.VendorId equals v.VendorId
                                   where p.Status == true
                                   select new ProductInvoiceList
                                   {
                                       ProductId = p.ProductId,
                                       ProductName = p.ProductName,
                                       QuantityPerBox = p.QuantityPerBox,
                                       Description = p.Description,
                                       Category = c.CategoryName,
                                       Vendor = v.VendorName
                                   }).ToList();
                HttpContext.Session.Set<List<ProductInvoiceList>>("listProduct", null);
                return RedirectToAction(nameof(RenderProductList));
            }
            List <ProductInvoiceList> listProduct = new List<ProductInvoiceList>();
            foreach (string id in listProductId)
            {
                 var product = (from p in ctx.Products
                                   join c in ctx.Categories on p.CategoryId equals c.CategoryId
                                   join v in ctx.Vendors on p.VendorId equals v.VendorId
                                   where p.Status == true && p.ProductId.Equals(id)
                                   select new ProductInvoiceList
                                   {
                                       ProductId = p.ProductId,
                                       ProductName = p.ProductName,
                                       QuantityPerBox = p.QuantityPerBox,
                                       Description = p.Description,
                                       Category = c.CategoryName,
                                       Vendor = v.VendorName
                                   }).SingleOrDefault();
                listProduct.Add(product);
            }
            HttpContext.Session.Set<List<ProductInvoiceList>>("listProduct", listProduct);
            return RedirectToAction(nameof(RenderProductList));
        }

        public IActionResult RenderProductList()
        {
            return View("CreateInvoiceStep2");
        }

        [HttpPost]
        public async Task<IActionResult> AddProductInvoice(IFormCollection form)
        {
            string[] listProduct = form["listProduct"].ToString().Split(",");
            string[] listQuantity = form["listQuantity"].ToString().Split(",");
            int[] listQuantityParsed = listQuantity.Select(int.Parse).ToArray();
            Invoice_Product ip = new Invoice_Product();
            for (int i = 0; i < listProduct.Count(); i++)
            {
                ip.ProductId = listProduct[i];
                ip.Quantity = listQuantityParsed[i];
                ip.InvoiceId = HttpContext.Session.GetString("invoiceId");
                ip.ProcessQuantity = 0;
                ctx.Add(ip);
                await ctx.SaveChangesAsync();
            }
            HttpContext.Session.Set<List<ProductInvoiceList>>("listProduct", null);
            return RedirectToAction(nameof(BackToInvoiceList));

        }

        public async Task<IActionResult> InvoiceCancel()
        {
            string invoiceId = HttpContext.Session.GetString("invoiceId");
            var invoice = ctx.Invoices.Find(invoiceId);
            ctx.Invoices.Remove(invoice);
            await ctx.SaveChangesAsync();
            HttpContext.Session.Set<List<ProductInvoiceList>>("listProduct", null);
            return RedirectToAction(nameof(ListAllInvoice));
        }

    }
}