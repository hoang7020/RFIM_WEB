using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;

namespace RFIM_Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDbContext ctx;
        
        public CategoryController(MyDbContext db)
        {
            ctx = db;
        }

        public IActionResult ListAllCategory()
        {
            return View(ctx.Categories.ToList());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                ctx.Add(category);
                await ctx.SaveChangesAsync();
                return RedirectToAction(nameof(ListAllCategory));
            }
            return View(category);
        }
        [HttpGet]
        public async Task<IActionResult> EditCategory(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = await ctx.Categories.FindAsync(id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(int id, Category category)
        {
            if(id != category.CategoryId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    ctx.Update(category);
                    await ctx.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExist(category.CategoryId))
                    {
                        return NotFound();
                    } else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListAllCategory));
            }
            return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> ActiveCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await ctx.Categories.SingleOrDefaultAsync(p => p.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return PartialView("ActiveCategory", category);
        }

        [HttpPost, ActionName("ActiveCategory")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ActiveCategoryConfirmed(int id)
        {
            var category = await ctx.Categories.FindAsync(id);
            category.Status = true;
            ctx.Update(category);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllCategory));
        }
        [HttpGet]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = await ctx.Categories.SingleOrDefaultAsync(p => p.CategoryId == id);
            if(category == null)
            {
                return NotFound();
            }
            var categoryExistInProduct = ctx.Products.Any(p => p.CategoryId == id);
            if(categoryExistInProduct)
            {
                return PartialView("DeactiveFail", category);
            } else
            {
                return PartialView("DeleteCategory", category);
            }
        }

        [HttpPost, ActionName("DeleteCategory")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategoryConfirm(int id)
        {
            var category = await ctx.Categories.FindAsync(id);
            category.Status = false;
            ctx.Update(category);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllCategory));
        }

        private bool CategoryExist(int id)
        {
            return ctx.Categories.Any(p => p.CategoryId == id);
        }

        public IActionResult BackToListCategory()
        {
            return RedirectToAction(nameof(ListAllCategory));
        }
    }
}