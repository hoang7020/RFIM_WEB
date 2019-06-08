using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class StockkeeperController : Controller
    {
        private readonly MyDbContext context;
        public StockkeeperController(MyDbContext db)
        {
            context = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetListShelf()
        {
            var dsShelf = context.Shelfs.ToList();
            return View(dsShelf);
        }

        public IActionResult CreateShelf()
        {
            return PartialView("CreateShelf");
        }
        [HttpPost]
        public async Task<IActionResult> CreateShelf(Shelf shelf)
        {
            if(ModelState.IsValid)
            {
                context.Add(shelf);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(GetListShelf));
            }
            return PartialView("CreateShelf", shelf);
        }
        public async Task<IActionResult> EditShelf(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var shelf = await context.Shelfs.FindAsync(id);
            if(shelf == null)
            {
                return NotFound();
            }
            return View(shelf);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditShelf(int id, Shelf shelf)
        {
            if(id != shelf.ShelfId)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {

                    context.Update(shelf);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShelfExist(shelf.ShelfId))
                    {
                        return NotFound();
                    } else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(GetListShelf));
            }
            return View(shelf);
        }

        public async Task<IActionResult> DeleteShelf(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var shelf = await context.Shelfs.FirstOrDefaultAsync(p => p.ShelfId == id);
            if(shelf == null)
            {
                return NotFound();
            }
            return PartialView("DeleteShelf", shelf);
        }
        [HttpPost, ActionName("DeleteShelf")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteShelfConfirm(int id) 
        {
            var shelf =await context.Shelfs.FindAsync(id);
            context.Shelfs.Remove(shelf);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(GetListShelf));
        }

        public bool ShelfExist(int id)
        {
            return context.Shelfs.Any(p => p.ShelfId == id);
        }
    }
}