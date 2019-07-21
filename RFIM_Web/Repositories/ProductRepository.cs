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
            return ctx.Categories.ToList();
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
        public async Task AddProduct(Product model)
        {
            ctx.Add(model);
            await Save();
        }
        public async Task<Product> FindProductById(string id)
        {
            return await ctx.Products.FindAsync(id);
        }
        public bool ProductNameExistExceptId(string id, string name)
        {
            return ctx.Products.Where(p => p.ProductId != id).Any(p => p.ProductName == name);
        }
        public async Task UpdateProduct(Product model)
        {
            ctx.Update(model);
            await Save();
        }
        public async Task<Product> GetProduct(string id)
        {
            return await ctx.Products.Include(p => p.Category).Include(p => p.Vendor)
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }
        public async Task<List<Package>> GetAllPackageById(string id)
        {
            return await ctx.Packages.Where(p => p.ProductId == id).ToListAsync();
        }
        public Product GetProductById(string id)
        {
            return ctx.Products.SingleOrDefault(p => p.ProductId == id);
        }
        private async Task Save()
        {
            await ctx.SaveChangesAsync();
        }
    }
}
