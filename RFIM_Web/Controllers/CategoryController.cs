using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;

namespace RFIM_Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _ctx;
        
        public CategoryController(ICategoryRepository _db)
        {
            _ctx = _db;
        }

        public IActionResult ListAllCategory()
        {
            return View(_ctx.GetAllCategory());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                if(_ctx.CategoryNameExists(category.CategoryName))
                {
                    ViewBag.cateExist = "Category name is already existed!";
                    return View("CreateCategory",category);
                }
                category.Status = true;
                _ctx.CreateCategory(category);
                return RedirectToAction(nameof(ListAllCategory));
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult EditCategory(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = _ctx.FindCategoryById(id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCategory(int id, Category category)
        {
            if(id != category.CategoryId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (_ctx.CategoryNameExistsExceptId(category.CategoryId, category.CategoryName))
                {
                    ViewBag.cateExist = "Category name is already existed!";
                    return View("CreateCategory", category);
                }
                else
                {
                    try
                    {
                        category.Status = true;
                        _ctx.UpdateCategory(category);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CategoryExist(category.CategoryId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return RedirectToAction(nameof(ListAllCategory));
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult ActiveCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _ctx.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return PartialView("ActiveCategory", category);
        }

        [HttpPost, ActionName("ActiveCategory")]
        [ValidateAntiForgeryToken]
        public IActionResult ActiveCategoryConfirmed(int id)
        {
            var category = _ctx.FindCategoryById(id);
            _ctx.ActiveCategory(category);
            return RedirectToAction(nameof(ListAllCategory));
        }
        [HttpGet]
        public IActionResult DeleteCategory(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = _ctx.GetCategory(id);
            if(category == null)
            {
                return NotFound();
            }
            var categoryExistInProduct = _ctx.CategoryExistsInProduct(id);
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
        public IActionResult DeleteCategoryConfirm(int id)
        {
            var category = _ctx.FindCategoryById(id);
            _ctx.DeactiveCategory(category);
            return RedirectToAction(nameof(ListAllCategory));
        }

        private bool CategoryExist(int id)
        {
            return _ctx.CategoryExists(id);
        }

        public IActionResult BackToListCategory()
        {
            return RedirectToAction(nameof(ListAllCategory));
        }
    }
}