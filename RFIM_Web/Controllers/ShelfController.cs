using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class ShelfController : Controller
    {
        private readonly MyDbContext ctx;

        public ShelfController(MyDbContext db)
        {
            ctx = db;
        }

        // GET: Shelf
        public async Task<IActionResult> ListAllShelf()
        {
            return View(await ctx.Shelfs.ToListAsync());
        }


        public IActionResult CreateShelf()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShelf(Shelf shelf)
        {
            if (ModelState.IsValid)
            {
                ctx.Add(shelf);
                await ctx.SaveChangesAsync();
                return RedirectToAction(nameof(ListAllShelf));
            }
            return View(shelf);
        }

        // GET: Shelf/Edit/5
        public async Task<IActionResult> EditShelf(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelf = await ctx.Shelfs.FindAsync(id);
            if (shelf == null)
            {
                return NotFound();
            }
            return View(shelf);
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditShelf(int id, Shelf shelf)
        {
            if (id != shelf.ShelfId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ctx.Update(shelf);
                    await ctx.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShelfExists(shelf.ShelfId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListAllShelf));
            }
            return View(shelf);
        }

        // GET: Shelf/Delete/5
        public async Task<IActionResult> DeleteShelf(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelf = await ctx.Shelfs
                .FirstOrDefaultAsync(m => m.ShelfId == id);
            if (shelf == null)
            {
                return NotFound();
            }

            return PartialView("DeleteShelf", shelf);
        }

        // POST: Shelf/Delete/5
        [HttpPost, ActionName("DeleteShelf")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shelf = await ctx.Shelfs.FindAsync(id);
            ctx.Shelfs.Remove(shelf);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllShelf));
        }

        private bool ShelfExists(int id)
        {
            return ctx.Shelfs.Any(e => e.ShelfId == id);
        }

        public IActionResult BackToShelfList()
        {
            return RedirectToAction(nameof(ListAllShelf));
        }
    }
}
