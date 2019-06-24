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

                for (int i = 1; i <= shelf.FloorNumber; i++)
                {
                    Floor floor = new Floor
                    {
                        FloorId = $"{shelf.ShelfId}-{i}",
                        ShelfId = shelf.ShelfId
                    };
                    ctx.Add(floor);
                    await ctx.SaveChangesAsync();
                };
                for (int i = 1; i <= shelf.FloorNumber; i++)
                {
                    for (int j = 1; j <= shelf.CellNumber; j++)
                    {
                        Cell cell = new Cell
                        {
                            CellId = $"{shelf.ShelfId}-{i}-{j}",
                            FloorId = $"{shelf.ShelfId}-{i}"
                        };
                        ctx.Add(cell);
                        await ctx.SaveChangesAsync();
                    }
                };
                return RedirectToAction(nameof(ListAllShelf));
            }

            return View(shelf);
        }

        // GET: Shelf/Edit/5
        public async Task<IActionResult> EditShelf(string id)
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
        public async Task<IActionResult> EditShelf(string id, Shelf shelf)
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
        public async Task<IActionResult> DeleteShelf(string id)
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
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var shelf = await ctx.Shelfs.FindAsync(id);
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                for (int j = 1; j <= shelf.CellNumber; j++)
                {
                    var cellId = $"{id}-{i}-{j}";
                    var cell = await ctx.Cells.FindAsync(cellId);
                    ctx.Cells.Remove(cell);
                    await ctx.SaveChangesAsync();
                }
            };
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                var floorId = $"{id}-{i}";
                var floor = await ctx.Floors.FindAsync(floorId);
                ctx.Floors.Remove(floor);
                await ctx.SaveChangesAsync();
            };
            ctx.Shelfs.Remove(shelf);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllShelf));
        }

        private bool ShelfExists(string id)
        {
            return ctx.Shelfs.Any(e => e.ShelfId == id);
        }

        public IActionResult BackToShelfList()
        {
            return RedirectToAction(nameof(ListAllShelf));
        }
    }
}
