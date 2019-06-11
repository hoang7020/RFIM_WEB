using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using RFIM_Web.Utils;

namespace RFIM_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDbContext ctx;
        public ProductController(MyDbContext db)
        {
            ctx = db;
        }

        public IActionResult ListAllProduct()
        {
            var dsProduct = ctx.Products.Include(p => p.Category).ToList();
            return View(dsProduct);
        }

        public IActionResult CreateProduct()
        {
            ViewBag.CategorySelect = new CategorySelect
            {
                Data = ctx.Categories.ToList()
            };
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(Product product, IFormFile fHinh)
        {
            if (ModelState.IsValid)
            {
                if(fHinh != null)
                {
                    product.Image = UploadImageTool.UploadImage(fHinh, "product");
                }
                ctx.Add(product);
                await ctx.SaveChangesAsync();
                return RedirectToAction(nameof(ListAllProduct));
            }
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> EditProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await ctx.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.CategorySelect = new CategorySelect
            {
                Data = ctx.Categories.ToList(),
                Select = product.ProductId
            };
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(int id, Product product, IFormFile fHinh)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if(fHinh != null)
                    {
                        product.Image = UploadImageTool.UploadImage(fHinh, "product");
                    }
                    ctx.Update(product);
                    await ctx.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExist(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListAllProduct));
            }
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product = await ctx.Products.Include(p => p.Category).SingleOrDefaultAsync(p => p.ProductId == id);
            if(product == null)
            {
                return NotFound();
            }
            return PartialView("DeleteProduct", product);
        }
        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var product =await ctx.Products.FindAsync(id);
            ctx.Products.Remove(product);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllProduct));
        }

        private bool ProductExist(int id)
        {
            return ctx.Products.Any(p => p.ProductId == id);
        }

        public IActionResult BackToProductList()
        {
            return RedirectToAction(nameof(ListAllProduct));
        }
    }
}