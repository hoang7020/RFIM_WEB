﻿using System;
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
            HttpContext.Session.SetInt32("invoiceType", 1);
            HttpContext.Session.SetInt32("User", context.findUserIdByName(User.Identity.Name));
            return View(context.GetPendingInvoice(1));
        }

        public IActionResult ListAllIssue()
        {
            HttpContext.Session.SetInt32("invoiceType", 2);
            HttpContext.Session.SetInt32("User", context.findUserIdByName(User.Identity.Name));
            return View(context.GetPendingInvoice(2));
        }

        public IActionResult ListAllHistory()
        {
            return View(context.GetAllHistory());
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
            if (invoice.StatusId != 1)
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
            HttpContext.Session.Set<Invoice>("invoice", null);
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
                    int? user = HttpContext.Session.GetInt32("User");
                    invoice.UserId = context.findUserByName(user);
                    invoice.StatusId = 1;
                    invoice.Date = DateTime.Now;
                    HttpContext.Session.Set<Invoice>("invoice",invoice);
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
            if (HttpContext.Session.GetInt32("invoiceType") == 1)
            {
                if (HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                {
                    var listProduct = context.GetProductInvoiceListStockIn();
                    return PartialView("AddProductList", listProduct);
                }
                else
                {
                    var listProduct = context.GetProductInvoiceListStockIn();
                    List<ProductExtendAttr> ssListProduct = HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct");
                    var listExcept = listProduct.Where(x => !ssListProduct.Any(z => z.ProductId == x.ProductId)).ToList<ProductExtendAttr>();
                    return PartialView("AddProductList", listExcept);
                }
            }
            else
            {
                if (HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                {
                    var listProduct = context.GetProductInvoiceListStockOut();
                    return PartialView("AddProductList", listProduct);
                }
                else
                {
                    var listProduct = context.GetProductInvoiceListStockOut();
                    List<ProductExtendAttr> ssListProduct = HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct");
                    var listExcept = listProduct.Where(x => !ssListProduct.Any(z => z.ProductId == x.ProductId)).ToList<ProductExtendAttr>();
                    return PartialView("AddProductList", listExcept);
                }
            }
        }

        public IActionResult AddProductListFinished(IFormCollection fm)
        {
            string[] listProductId = fm["checkList"].ToString().Split(",");
            if (HttpContext.Session.GetInt32("invoiceType") == 1)
            {
                if (string.IsNullOrEmpty(listProductId[0]))
                {
                    var listProductRedirect = context.GetProductInvoiceListStockOut();
                    HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
                    return RedirectToAction(nameof(RenderProductList));
                }
                List<ProductExtendAttr> listProduct = new List<ProductExtendAttr>();
                foreach (string id in listProductId)
                {
                    var product = context.FindSingleProductInvoiceStockOut(id);
                    listProduct.Add(product);
                }
                HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", listProduct);
                return RedirectToAction(nameof(RenderProductList));
            }
            else
            {
                if (string.IsNullOrEmpty(listProductId[0]))
                {
                    var listProductRedirect = context.GetProductInvoiceListStockIn();
                    HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
                    return RedirectToAction(nameof(RenderProductList));
                }           
                List<ProductExtendAttr> listProduct = new List<ProductExtendAttr>();
                foreach (string id in listProductId)
                {
                    var product = context.FindSingleProductInvoiceStockIn(id);
                    listProduct.Add(product);
                }
                HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", listProduct);
                return RedirectToAction(nameof(RenderProductList));
            }
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
            Invoice invoice = HttpContext.Session.Get<Invoice>("invoice");
            context.AddInvoice(invoice);
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
            HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
            return RedirectToAction(nameof(ListAllInvoice));
        }

        public IActionResult UpdateInvoice(string id)
        {
            Invoice invoice = context.FindInvoice(id);
            int invoiceType = invoice.InvoiceTypeId;
            HttpContext.Session.SetString("invoiceId", invoice.InvoiceId);
            HttpContext.Session.SetInt32("invoiceType", invoiceType);
            if (invoiceType == 1)
            {
                List<ProductExtendAttr> listProduct = context.FindProductInvoiceListStockIn(invoice.InvoiceId);
                HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", listProduct);
                return RedirectToAction(nameof(RenderEditProductList));
            }
            else
            {
                List<ProductExtendAttr> listProduct = context.FindProductInvoiceListStockOut(invoice.InvoiceId);
                HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", listProduct);
                return RedirectToAction(nameof(RenderEditProductList));
            }
        }

        public IActionResult RenderEditProductList()
        {
            return View("UpdateInvoice");
        }
        public IActionResult UpdateProductList()
        {
            if (HttpContext.Session.GetInt32("invoiceType") == 1)
            {
                if (HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                {
                    var listProduct = context.GetProductInvoiceListStockIn();
                    return PartialView("UpdateProductList", listProduct);
                }
                else
                {
                    var listProduct = context.GetProductInvoiceListStockIn();
                    List<ProductExtendAttr> ssListProduct = HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct");
                    var listExcept = listProduct.Where(x => !ssListProduct.Any(z => z.ProductId == x.ProductId)).ToList<ProductExtendAttr>();
                    return PartialView("UpdateProductList", listExcept);
                }
            }
            else
            {
                if (HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                {
                    var listProduct = context.GetProductInvoiceListStockOut();
                    return PartialView("UpdateProductList", listProduct);
                }
                else
                {
                    var listProduct = context.GetProductInvoiceListStockOut();
                    List<ProductExtendAttr> ssListProduct = HttpContext.Session.Get<List<ProductExtendAttr>>("listProduct");
                    var listExcept = listProduct.Where(x => !ssListProduct.Any(z => z.ProductId == x.ProductId)).ToList<ProductExtendAttr>();
                    return PartialView("UpdateProductList", listExcept);
                }
            }
        }

        public IActionResult UpdateProductListFinished(IFormCollection fm)
        {
            string[] listProductId = fm["checkList"].ToString().Split(",");
            if (HttpContext.Session.GetInt32("invoiceType") == 1)
            {
                if (string.IsNullOrEmpty(listProductId[0]))
                {
                    var listProductRedirect = context.GetProductInvoiceListStockIn();
                    HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
                    return RedirectToAction(nameof(RenderEditProductList));
                }
                List<ProductExtendAttr> listProduct = new List<ProductExtendAttr>();
                foreach (string id in listProductId)
                {
                    var product = context.FindSingleProductInvoiceStockIn(id);
                    listProduct.Add(product);
                }
                HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", listProduct);
                return RedirectToAction(nameof(RenderEditProductList));
            }
            else
            {
                if (string.IsNullOrEmpty(listProductId[0]))
                {
                    var listProductRedirect = context.GetProductInvoiceListStockOut();
                    HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
                    return RedirectToAction(nameof(RenderEditProductList));
                }
                List<ProductExtendAttr> listProduct = new List<ProductExtendAttr>();
                foreach (string id in listProductId)
                {
                    var product = context.FindSingleProductInvoiceStockOut(id);
                    listProduct.Add(product);
                }
                HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", listProduct);
                return RedirectToAction(nameof(RenderEditProductList));
            }
        }

        public IActionResult UpdateProductInvoice(IFormCollection form)
        {
            string[] listProduct = form["listProduct"].ToString().Split(",");
            string[] listQuantity = form["listQuantity"].ToString().Split(",");
            int[] listQuantityParsed = listQuantity.Select(int.Parse).ToArray();
            string invoiceId = HttpContext.Session.GetString("invoiceId");
            context.WipeInvoiceProduct(invoiceId);
            Invoice_Product ip = new Invoice_Product();
            for (int i = 0; i < listProduct.Count(); i++)
            {
                ip.ProductId = listProduct[i];
                ip.Quantity = listQuantityParsed[i];
                ip.InvoiceId = invoiceId;
                ip.ProcessQuantity = 0;
                context.AddInvoice_Product(ip);
            }
            HttpContext.Session.Set<List<ProductExtendAttr>>("listProduct", null);
            return RedirectToAction(nameof(BackToInvoiceList));
        }
    }
}