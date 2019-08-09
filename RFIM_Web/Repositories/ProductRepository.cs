using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RFIM_Web.Repositories
{
    public class ProductRepository : IProductRepository
    {
        protected readonly MyDbContext ctx;
        public ProductRepository(MyDbContext db)
        {
            ctx = db;
        }
        public List<Product> GetAllProduct()
        {
            return ctx.Products.Include(p => p.Category).Include(p => p.Vendor)
                .ToList();
        }
        public List<Category> GetAllCategory()
        {
            return ctx.Categories.Where(p => p.Status == true).ToList();
        }
        public List<Vendor> GetAllVendor()
        {
            return ctx.Vendors.ToList();
        }
        public bool ProductIdExists(string id)
        {
            return ctx.Products.Any(p => p.ProductId == id);
        }
        public bool ProductNameExists(string name)
        {
            return ctx.Products.Any(p => p.ProductName == name);
        }
        public void AddProduct(Product model)
        {
            ctx.Add(model);
            Save();
        }
        public Product FindProductById(string id)
        {
            return ctx.Products.Find(id);
        }
        public bool ProductNameExistExceptId(string id, string name)
        {
            return ctx.Products.Where(p => p.ProductId != id).Any(p => p.ProductName == name);
        }
        public bool ProductExistInPackage(string id)
        {
            return ctx.Packages.Any(p => p.ProductId == id);
        }
        public void UpdateProduct(Product model)
        {
            ctx.Update(model);
            Save();
        }
        public void DeactiveProduct(Product model)
        {
            model.Status = false;
            ctx.Update(model);
            Save();
        }
        public void ActiveProduct(Product model)
        {
            model.Status = true;
            ctx.Update(model);
            Save();
        }
        public Product GetProduct(string id)
        {
            return ctx.Products.Include(p => p.Category).Include(p => p.Vendor)
                .FirstOrDefault(p => p.ProductId == id);
        }
        public List<Package> GetAllPackageById(string id)
        {
            return ctx.Packages.Where(p => p.ProductId == id).ToList();
        }
        public Product GetProductById(string id)
        {
            return ctx.Products.SingleOrDefault(p => p.ProductId == id);
        }
        private void Save()
        {
            ctx.SaveChanges();
        }

        public int GetQuantityBox(string id)
        {
            return ctx.Boxes.Count(p => p.ProductId == id);
        }
    }
}
