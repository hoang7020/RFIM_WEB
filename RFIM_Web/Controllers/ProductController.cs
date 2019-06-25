using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        //Return view create product
        public IActionResult CreateProduct()
        {
            //ViewBag.CategorySelect = new CategorySelect
            //{
            //    Data = ctx.Categories.ToList()
            //};
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(Product product, IFormFile fHinh)
        {
            //check model validation 
            if (ModelState.IsValid)
            {
                //check if product id already existed 
                bool productIdExist = ctx.Products.Any(p => p.ProductId == product.ProductId);
                //if product id is not existed
                if (!productIdExist)
                {
                    if (fHinh != null)
                    {
                        product.Image = UploadImageTool.UploadImage(fHinh, "product");
                    }
                    ctx.Add(product);
                    await ctx.SaveChangesAsync();
                    return RedirectToAction(nameof(ListAllProduct));
                }
                //product id is existed
                else
                {
                    ModelState.AddModelError("", "Product Id already existed !!!");
                }
            }
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName", product.CategoryId);
            //if validation is error return view with error messages
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> EditProduct(string id)
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
            //ViewBag.CategorySelect = new CategorySelect
            //{
            //    Data = ctx.Categories.ToList(),
            //    Select = product.ProductId
            //};
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(string id, Product product, IFormFile fHinh)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (fHinh != null)
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
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await ctx.Products.Include(p => p.Category).SingleOrDefaultAsync(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return PartialView("DeleteProduct", product);
        }
        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            var product = await ctx.Products.FindAsync(id);
            ctx.Products.Remove(product);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllProduct));
        }

        private bool ProductExist(string id)
        {
            return ctx.Products.Any(p => p.ProductId == id);
        }

        public IActionResult BackToProductList()
        {
            return RedirectToAction(nameof(ListAllProduct));
        }
        
        public async Task<IActionResult> DetailProduct(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product = await ctx.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.ProductId == id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}