using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        protected readonly MyDbContext ctx;
        public CategoryRepository(MyDbContext db)
        {
            ctx = db;
        }

        public bool CategoryExists(int id)
        {
            return ctx.Categories.Any(p => p.CategoryId == id);
        }

        public bool CategoryExistsInProduct(int? id)
        {
            return ctx.Products.Any(p => p.CategoryId == id);
        }

        public bool CategoryNameExists(string name)
        {
            return ctx.Categories.Any(p => p.CategoryName.Contains(name));
        }

        public void CreateCategory(Category model)
        {
            ctx.Add(model);
            Save();
        }

        public Category FindCategoryById(int? id)
        {
            return ctx.Categories.Find(id);
        }

        public List<Category> GetAllCategory()
        {
            return ctx.Categories.ToList();
        }

        public Category GetCategory(int? id)
        {
            return ctx.Categories.SingleOrDefault(p => p.CategoryId == id);
        }

        public void UpdateCategory(Category model)
        {
            ctx.Update(model);
            Save();
        }

        public void DeactiveCategory(Category model)
        {
            model.Status = false;
            ctx.Update(model);
            Save();
        }
        public void ActiveCategory(Category model)
        {
            model.Status = true;
            ctx.Update(model);
            Save();
        }
        private void Save()
        {
            ctx.SaveChanges();
        }

        public bool CategoryNameExistsExceptId(int id, string name)
        {
            return ctx.Categories.Where(p => p.CategoryId != id).Any(p => p.CategoryName == name);
        }
    }
}
