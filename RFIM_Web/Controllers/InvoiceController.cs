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
using RFIM_Web.Repositories;
using RFIM_Web.Interfaces;

namespace RFIM_Web.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceRepository context;
        public InvoiceController(IInvoiceRepository _context)
        {
            context = _context;
        }

        public IActionResult ListAllInvoice()
        {
            var listInvoice = context.GetAllInvoice();
            return View(listInvoice);
        }

        public IActionResult DetailInvoice(string id)
        {
            var productList = context.GetProductInvoiceDetail(id);
            var detail = context.GetSingleInvoiceDetail(id);
            var model = new InvoiceDetail { Invoices = detail, productList = productList };
            return PartialView("InvoiceDetail", model);
        }

        [HttpGet]
        public IActionResult DeleteInvoice(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var invoice = context.GetSingleInvoiceDetail(id);
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
        public IActionResult DeleteConfirm(string id)
        {
            context.DeleteInvoiceOnAction(id);
            return RedirectToAction(nameof(ListAllInvoice));
        }

        public IActionResult BackToInvoiceList()
        {
            return RedirectToAction(nameof(ListAllInvoice));

        }

        public IActionResult CreateInvoiceStep1()
        {
            ViewData["InvoiceTypeId"] = context.GetSelectList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddInvoiceStep2(Invoice invoice)
        {
            ViewData["InvoiceTypeId"] = context.GetSelectList();
            if (ModelState.IsValid)
            {
                if (context.CheckInvoiceDupp(invoice))
                {
                    ViewBag.invoceExist = "InvoiceId was already existed!";
                    return View("CreateInvoiceStep1", invoice);
                }
                else
                {
                    invoice.StatusId = 1;
                    invoice.Date = DateTime.Now;
                    context.AddInvoice(invoice);
                    int invoiceType = invoice.InvoiceTypeId;
                    HttpContext.Session.SetString("invoiceId", invoice.InvoiceId);
                    HttpContext.Session.SetInt32("invoiceType", invoiceType);
                    HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
                    return RedirectToAction(nameof(RenderProductList));

                }
            }
            return View("CreateInvoiceStep1");
        }

        public IActionResult AddProductList()
        {
            if (HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
            {
                var listProduct = context.GetProductInvoiceList();
                return PartialView("AddProductList", listProduct);
                } 
            else
            {
                var listProduct = context.GetProductInvoiceList();
                List<ProductExtendAttr> ssListProduct = HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct");
                var listExcept = listProduct.Where(x => !ssListProduct.Any(z => z.ProductId == x.ProductId)).ToList<ProductExtendAttr>();
                return PartialView("AddProductList", listExcept);
            }
        }

        public IActionResult AddProductListFinished(IFormCollection fm)
        {
            string[] listProductId = fm["checkList"].ToString().Split(",");
            if (string.IsNullOrEmpty(listProductId[0]))
            {
                var listProductRedirect = context.GetProductInvoiceList();
                HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
                return RedirectToAction(nameof(RenderProductList));
            }
            List<ProductExtendAttr> listProduct = new List<ProductExtendAttr>();
            foreach (string id in listProductId)
            {
                var product = context.FindSingleProductInvoice(id);
                listProduct.Add(product);
            }
            HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", listProduct);
            return RedirectToAction(nameof(RenderProductList));
        }

        public IActionResult RenderProductList()
        {
            return View("CreateInvoiceStep2");
        }

        [HttpPost]
        public IActionResult AddProductInvoice(IFormCollection form)
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
                context.AddInvoice_Product(ip);
            }
            HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
            return RedirectToAction(nameof(BackToInvoiceList));

        }

        public IActionResult InvoiceCancel()
        {
            string invoiceId = HttpContext.Session.GetString("invoiceId");
            context.DeleteInvoiceOnCancel(invoiceId);
            HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
            return RedirectToAction(nameof(ListAllInvoice));
        }

    }
}