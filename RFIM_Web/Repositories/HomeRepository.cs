using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        protected readonly MyDbContext ctx;
        public HomeRepository(MyDbContext db)
        {
            ctx = db;
        }
        public int CategoryCount()
        {
            return ctx.Categories.Count();
        }
        public int VendorCount()
        {
            return ctx.Vendors.Count();
        }
        public int ProductCount()
        {
            return ctx.Products.Count();
        }
        public int ShelfCount()
        {
            return ctx.Shelfs.Count();
        }
        public List<Invoice> GetReceives()
        {
            return ctx.Invoices.Where(p => p.InvoiceTypeId == 1)
                .Where(p => p.StatusId == 1).ToList();
        }
        public List<Invoice> GetIssues()
        {
            return ctx.Invoices.Where(p => p.InvoiceTypeId == 2)
                .Where(p => p.StatusId == 1).ToList();
        }

        public int ReceivesPendingCount()
        {
            return ctx.Invoices.Count(p => p.InvoiceTypeId == 1 && p.StatusId == 1);
        }

        public int IssuesPendingCount()
        {
            return ctx.Invoices.Count(p => p.InvoiceTypeId == 2 && p.StatusId == 1);
        }
    }
}
