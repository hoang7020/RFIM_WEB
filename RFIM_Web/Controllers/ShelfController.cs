using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;
using RFIM_Web.ModelView;

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
            var standShellSize = ctx.StandardShellSizes.SingleOrDefault(p => p.StandardShellId == 1);
            ViewBag.StandardSize = new StandardSize
            {
                StandardFloor = standShellSize.StandardFloor,
                StandardCell = standShellSize.StandardCell
            };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShelf(Shelf shelf)
        {

            if (ModelState.IsValid)
            {
                bool shelfIdExist = ctx.Shelfs.Any(p => p.ShelfId == shelf.ShelfId);
                if (!shelfIdExist)
                {
                    var standShellSize = ctx.StandardShellSizes.SingleOrDefault(p => p.StandardShellId == 1); 
                    ViewBag.StandardSize = new StandardSize
                    {
                        StandardFloor = standShellSize.StandardFloor,
                        StandardCell = standShellSize.StandardCell
                    };

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
                } else
                {
                    ModelState.AddModelError("", "ShelfId is already existed !!!");
                }
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
                    //lấy tổng số row của table cell, floor của id
                    int currentCellNumber = ctx.Cells.Where(p => p.CellId.Contains(id)).Count();
                    int currentFloorNumber = ctx.Floors.Where(p => p.FloorId.Contains(id)).Count();
                    //test

                    //thay đổi floor number tăng so với floor number hiện tại 
                    if (currentFloorNumber < shelf.FloorNumber)
                    {
                        ctx.Update(shelf);
                        await ctx.SaveChangesAsync();

                        for (int i = 1; i <= shelf.FloorNumber; i++)
                        {
                            string myFloorId = $"{shelf.ShelfId}-{i}";
                            if (!ctx.Floors.Any(p => p.FloorId == myFloorId))
                            {
                                Floor floor = new Floor
                                {
                                    FloorId = $"{shelf.ShelfId}-{i}",
                                    ShelfId = shelf.ShelfId
                                };
                                ctx.Add(floor);
                                await ctx.SaveChangesAsync();
                            }
                        };
                    }

                    //thay đổi cell number tăng hoặc floor number tăng với cell number, floor number hiện tại
                    if (currentCellNumber < (shelf.CellNumber * shelf.FloorNumber)
                        || (currentFloorNumber != shelf.FloorNumber && currentFloorNumber < shelf.FloorNumber))
                    {
                        ctx.Update(shelf);
                        await ctx.SaveChangesAsync();

                        for (int i = 1; i <= shelf.FloorNumber; i++)
                        {
                            for (int j = 1; j <= shelf.CellNumber; j++)
                            {
                                string myCellId = $"{shelf.ShelfId}-{i}-{j}";
                                if (!ctx.Cells.Any(p => p.CellId == myCellId))
                                {
                                    Cell cell = new Cell
                                    {
                                        CellId = $"{shelf.ShelfId}-{i}-{j}",
                                        FloorId = $"{shelf.ShelfId}-{i}"
                                    };
                                    ctx.Add(cell);
                                    await ctx.SaveChangesAsync();
                                }
                            }
                        };
                    }

                    if(currentCellNumber > (shelf.CellNumber * shelf.FloorNumber) ||
                        currentFloorNumber > shelf.FloorNumber)
                    {
                        int oldCellNumber = currentCellNumber / currentFloorNumber;
                        for(int i = 1; i <= currentFloorNumber; i++)
                        {
                            for(int j = 1; j <= oldCellNumber; j++)
                            {
                                var cellId = $"{shelf.ShelfId}-{i}-{j}";
                                var cell = await ctx.Cells.FindAsync(cellId);
                                ctx.Cells.Remove(cell);
                                await ctx.SaveChangesAsync();
                            }
                        };

                        for (int i = 1; i <= currentFloorNumber; i++)
                        {
                            var floorId = $"{shelf.ShelfId}-{i}";
                            var floor = await ctx.Floors.FindAsync(floorId);
                            ctx.Floors.Remove(floor);
                            await ctx.SaveChangesAsync();
                        };

                        ctx.Update(shelf);
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
                        }
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
                    }
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
            var cells = ctx.Cells.Where(p => p.CellId.Contains(shelf.ShelfId));
            List<int> packCountList = new List<int>();
            foreach(var cell in cells)
            {
                int packageCount = ctx.Packages.Count(p => p.CellId == cell.CellId);
                packCountList.Add(packageCount);
            }
            int totalInList = 0;
            packCountList.ForEach(item =>
            {
                totalInList += item;
            });
            
            if (totalInList == 0)
            {
                return PartialView("DeleteShelf", shelf);
            } else
            {
                return PartialView("DeleteShelfFail", shelf);
            }
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
        [HttpGet]
        public async Task<IActionResult> EditShelfSize(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var standardSize = await ctx.StandardShellSizes.FindAsync(id);
            if(standardSize == null)
            {
                return NotFound();
            }
            return View(standardSize);
        }
        [HttpPost]
        public async Task<IActionResult> EditShelfSize(int? id, StandardShellSize standardSize)
        {
            if(id != standardSize.StandardShellId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    ctx.Update(standardSize);
                    await ctx.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StandardSizeExists(standardSize.StandardShellId))
                    {
                        return NotFound();
                    } else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListAllShelf));
            }
            return View(standardSize);
        }

        public bool StandardSizeExists(int id)
        {
            return ctx.StandardShellSizes.Any(p => p.StandardShellId == id);
        }
    }
}
