using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFIM_Web.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        protected readonly MyDbContext ctx;
        public InvoiceRepository(MyDbContext db)
        {
            ctx = db;
        }
        public List<ProductExtendAttr> GetProductInvoiceListStockOut()
        {
            List<ProductExtendAttr> productInvoiceLists =
                (from b in ctx.Boxes
                 where b.Product.Status == true && b.Status == true
                 group new { b.Product, b.Product.Vendor, b.Product.Category, b } by new
                 {
                     b.Product.ProductId,
                     b.Product.Vendor.VendorName,
                     b.Product.Category.CategoryName,
                     b.Product.ProductName,
                     b.Product.QuantityPerBox
                 } into p
                 select new ProductExtendAttr
                 {
                     ProductId = p.Key.ProductId,
                     Vendor = p.Key.VendorName,
                     Category = p.Key.CategoryName,
                     ProductName = p.Key.ProductName,
                     QuantityPerBox = p.Key.QuantityPerBox,
                     InstockQuantity = p.Count(c => c.b.ProductId != null && c.b.Status == true)
                 }).ToList();
            return productInvoiceLists;
        }

        public List<ProductExtendAttr> GetProductInvoiceListStockIn()
        {
            List<ProductExtendAttr> productInvoiceLists = (from p in ctx.Products
                                                           join c in ctx.Categories on p.CategoryId equals c.CategoryId
                                                           join v in ctx.Vendors on p.VendorId equals v.VendorId
                                                           where p.Status == true
                                                           select new ProductExtendAttr
                                                           {
                                                               ProductId = p.ProductId,
                                                               ProductName = p.ProductName,
                                                               QuantityPerBox = p.QuantityPerBox,
                                                               Category = c.CategoryName,
                                                               Vendor = v.VendorName
                                                           }).ToList();
            return productInvoiceLists;
        }
        public List<Invoice> GetPendingInvoice(int typeId)
        {
            return ctx.Invoices.Include(i => i.InvoiceType).
                Include(i => i.InvoiceStatus).
                Include(u => u.User).
                Where(i => i.InvoiceTypeId.Equals(typeId)).
                Where(i => i.InvoiceStatus.StatusId != 3).
                OrderByDescending(i => i.Date).ToList();
        }

        public List<ProductList> GetProductInvoiceDetail(string id)
        {
            List<ProductList> productList = (from ip in ctx.Invoice_Products
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
                                                 Vendor = v.VendorName,
                                                 QuantityperBox = p.QuantityPerBox
                                             }).ToList();
            return productList;
        }

        public Invoice GetSingleInvoiceDetail(string id)
        {
            return ctx.Invoices.Include(it => it.InvoiceType).Include(u => u.User).Include(it => it.InvoiceStatus).SingleOrDefault(i => i.InvoiceId.Equals(id));
        }

        public void DeleteInvoiceOnAction(string id)
        {
            ctx.Invoice_Products.RemoveRange(ctx.Invoice_Products.Where(x => x.InvoiceId.Equals(id)));
            var invoice = GetSingleInvoiceDetail(id);
            Delete(invoice);
            Save();
        }

        public SelectList GetSelectList()
        {
            return new SelectList(ctx.InvoiceTypes, "InvoiceTypeId", "InvoiceTypes");
        }

        public bool CheckInvoiceDupp(Invoice invoice)
        {
            return ctx.Invoices.Any(i => i.InvoiceId == invoice.InvoiceId);
        }

        public void AddInvoice(Invoice invoice)
        {
            ctx.Add(invoice);
            Save();
        }

        public ProductExtendAttr FindSingleProductInvoiceStockOut(string id)
        {
            ProductExtendAttr pil = (from p in ctx.Products
                                     where p.ProductId.Equals(id)
                                     group new { p, p.Vendor, p.Category } by new
                                     {
                                         p.ProductId,
                                         p.ProductName,
                                         p.QuantityPerBox,
                                         p.Vendor.VendorName,
                                         p.Category.CategoryName,
                                     } into p
                                     select new ProductExtendAttr
                                     {
                                         ProductId = p.Key.ProductId,
                                         ProductName = p.Key.ProductName,
                                         Vendor = p.Key.VendorName,
                                         Category = p.Key.CategoryName,
                                         QuantityPerBox = p.Key.QuantityPerBox,
                                         InstockQuantity = ctx.Boxes.Count(x => x.ProductId.Equals(p.Key.ProductId) && x.Status == true)
                                     }).SingleOrDefault();
            return pil;
        }

        public ProductExtendAttr FindSingleProductInvoiceStockIn(string id)
        {
            ProductExtendAttr pil = (from p in ctx.Products
                                     join c in ctx.Categories on p.CategoryId equals c.CategoryId
                                     join v in ctx.Vendors on p.VendorId equals v.VendorId
                                     where p.Status == true && p.ProductId.Equals(id)
                                     select new ProductExtendAttr
                                     {
                                         ProductId = p.ProductId,
                                         ProductName = p.ProductName,
                                         QuantityPerBox = p.QuantityPerBox,
                                         Category = c.CategoryName,
                                         Vendor = v.VendorName
                                     }).SingleOrDefault();
            return pil;
        }

        public void AddInvoice_Product(Invoice_Product ip)
        {
            ctx.Add(ip);
            Save();
        }

        public void DeleteInvoiceOnCancel(string id)
        {
            var invoice = GetSingleInvoiceDetail(id);
            Delete(invoice);
            Save();
        }
        private void Save()
        {
            ctx.SaveChanges();
        }

        private void Delete(Invoice invoice)
        {
            ctx.Invoices.Remove(invoice);
        }

        public List<ProductExtendAttr> FindProductInvoiceListStockIn(string id)
        {
            List<ProductExtendAttr> productInvoiceLists = (from ip in ctx.Invoice_Products
                                                           where ip.InvoiceId.Equals(id)
                                                           group new { ip.Product, ip, ip.Product.Vendor, ip.Product.Category } by new
                                                           {
                                                               ip.ProductId,
                                                               ip.Product.ProductName,
                                                               ip.Quantity,
                                                               ip.Product.Vendor.VendorName,
                                                               ip.Product.Category.CategoryName,
                                                               ip.Product.QuantityPerBox
                                                           } into p
                                                           select new ProductExtendAttr
                                                           {
                                                               ProductId = p.Key.ProductId,
                                                               ProductName = p.Key.ProductName,
                                                               Quantity = p.Key.Quantity,
                                                               Vendor = p.Key.VendorName,
                                                               Category = p.Key.CategoryName,
                                                               QuantityPerBox = p.Key.QuantityPerBox
                                                           }).ToList();
                return productInvoiceLists;
        }

        public List<ProductExtendAttr> FindProductInvoiceListStockOut(string id)
        {
            List<ProductExtendAttr> productInvoiceLists = (from ip in ctx.Invoice_Products
                                                           where ip.InvoiceId.Equals(id)
                                                           group new { ip.Product, ip, ip.Product.Vendor, ip.Product.Category } by new
                                                           {
                                                               ip.ProductId,
                                                               ip.Product.ProductName,
                                                               ip.Quantity,
                                                               ip.Product.Vendor.VendorName,
                                                               ip.Product.Category.CategoryName,
                                                               ip.Product.QuantityPerBox
                                                           } into p
                                                           select new ProductExtendAttr
                                                           {
                                                               ProductId = p.Key.ProductId,
                                                               ProductName = p.Key.ProductName,
                                                               Quantity = p.Key.Quantity,
                                                               Vendor = p.Key.VendorName,
                                                               Category = p.Key.CategoryName,
                                                               QuantityPerBox = p.Key.QuantityPerBox,
                                                               InstockQuantity = ctx.Boxes.Count(x => x.ProductId.Equals(p.Key.ProductId) && x.Status == true)
                                                           }).ToList();
            return productInvoiceLists;
        }

        public void UpdateInvoice(Invoice invoice)
        {
                ctx.Update(invoice);
                Save();
        }

        public void WipeInvoiceProduct(string id)
        {
            var invoice = GetSingleInvoiceDetail(id);
            ctx.Invoice_Products.RemoveRange(ctx.Invoice_Products.Where(x => x.InvoiceId.Equals(invoice.InvoiceId)));
        }

        public User findUserById(int? user)
        {
            return ctx.Users.Find(user);
        }

        public List<Invoice> GetAllHistory()
        {
            return ctx.Invoices.Include(i => i.InvoiceType).
                Include(i => i.InvoiceStatus).
                Include(u => u.User).
                Where(i => i.InvoiceStatus.StatusId == 3).OrderByDescending(i => i.Date).ToList();
        }

        public InvoiceType getPrefix(int typeId)
        {
            return ctx.InvoiceTypes.Find(typeId);
        }

        public void UpdatePrefix(InvoiceType invoiceType)
        {
            ctx.Update(invoiceType);
            Save();
        }

        public int findUserIdByName(string username)
        {
            return ctx.Users.FirstOrDefault(p => p.Username == username).UserId;
        }
        public int findUserIdByName(string username)
        {
            return ctx.Users.FirstOrDefault(p => p.Username == username).UserId;
        }
    }
}
