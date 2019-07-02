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
            var listInvoice = ctx.Invoices.Include(i => i.InvoiceType).Include(i2 => i2.User).ToList();
            return View(listInvoice);
        }
        //Return view create Invoice
        public IActionResult CreateInvoice()
        {
            ViewData["InvoiceTypeId"] = new SelectList(ctx.InvoiceTypes, "InvoiceTypeId", "InvoiceTypes");
            return View();
        }
        public IActionResult DetailInvoice(int id)
        {
            var productList = (from ip in ctx.Invoice_Products  
                           join p in ctx.Products on ip.ProductId equals p.ProductId
                           where ip.InvoiceId == id
             select new ProductList
             {
                 ProductName = p.ProductName,
                 Quantity = ip.Quantity,
             }).ToList();
            var detail = ctx.Invoices.Include(it => it.InvoiceType).Include(u => u.User).SingleOrDefault(i => i.InvoiceId == id);
            var model = new InvoiceDetail { Invoices = detail, productList = productList};
            return View(model);
        }
    }
}