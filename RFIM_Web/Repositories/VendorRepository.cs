using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        protected readonly MyDbContext ctx;
        public VendorRepository(MyDbContext db)
        {
            ctx = db;
        }

        public bool VendorExists(int id)
        {
            return ctx.Vendors.Any(p => p.VendorId == id);
        }

        public bool VendorExistsInProduct(int? id)
        {
            return ctx.Products.Any(p => p.VendorId == id);
        }

        public bool VendorNameExists(string name)
        {
            return ctx.Vendors.Any(p => p.VendorName.Contains(name));
        }

        public void CreateVendor(Vendor model)
        {
            ctx.Add(model);
            Save();
        }

        public Vendor FindVendorById(int? id)
        {
            return ctx.Vendors.Find(id);
        }

        public List<Vendor> GetAllVendor()
        {
            return ctx.Vendors.ToList();
        }

        public Vendor GetVendor(int? id)
        {
            return ctx.Vendors.SingleOrDefault(p => p.VendorId == id);
        }

        public void UpdateVendor(Vendor model)
        {
            ctx.Update(model);
            Save();
        }

        public void DeactiveVendor(Vendor model)
        {
            model.Status = false;
            ctx.Update(model);
            Save();
        }
        public void ActiveVendor(Vendor model)
        {
            model.Status = true;
            ctx.Update(model);
            Save();
        }
        private void Save()
        {
            ctx.SaveChanges();
        }

        public bool VendorNameExistsExceptId(int id, string name)
        {
            return ctx.Vendors.Where(p => p.VendorId != id).Any(p => p.VendorName == name);
        }
    }
}
