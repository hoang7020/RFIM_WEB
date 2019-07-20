using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using RFIM_Web.ModelView;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class ShelfController : Controller
    {
        private readonly IShelfRepository ctx;
        public ShelfController(IShelfRepository db)
        {
            ctx = db;
        }

        // GET: Shelf
        public async Task<IActionResult> ListAllShelf()
        {
            return View(await ctx.GetAllShelf());
        }


        public IActionResult CreateShelf()
        {
            //var standShellSize = ctx.StandardShellSizes.SingleOrDefault(p => p.StandardShellId == 1);
            var standShelfSize = ctx.GetStandardShellSize(1);
            ViewBag.StandardSize = new StandardSize
            {
                StandardFloor = standShelfSize.StandardFloor,
                StandardCell = standShelfSize.StandardCell
            };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShelf(Shelf shelf)
        {
            var standShelfSize = ctx.GetStandardShellSize(1);
            if (ModelState.IsValid)
            {
                //bool shelfIdExist = ctx.Shelfs.Any(p => p.ShelfId == shelf.ShelfId);
                bool shelfIdExist = ctx.ShelfExists(shelf.ShelfId);
                if (!shelfIdExist)
                {
                    ViewBag.StandardSize = new StandardSize
                    {
                        StandardFloor = standShelfSize.StandardFloor,
                        StandardCell = standShelfSize.StandardCell
                    };

                    await ctx.AddShelf(shelf);

                    for (int i = 1; i <= shelf.FloorNumber; i++)
                    {
                        Floor floor = new Floor
                        {
                            FloorId = $"{shelf.ShelfId}-{i}",
                            ShelfId = shelf.ShelfId
                        };
                        await ctx.AddFloor(floor);
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
                            await ctx.AddCell(cell);
                        }
                    };
                    return RedirectToAction(nameof(ListAllShelf));
                }
                else
                {
                    ViewBag.ShelfExistError = "Shelf Id is already existed !!!";
                    ViewBag.StandardSize = new StandardSize
                    {
                        StandardFloor = standShelfSize.StandardFloor,
                        StandardCell = standShelfSize.StandardCell
                    };
                    return View(shelf);
                }
            }
            ViewBag.StandardSize = new StandardSize
            {
                StandardFloor = standShelfSize.StandardFloor,
                StandardCell = standShelfSize.StandardCell
            };
            return View(shelf);
        }

        // GET: Shelf/Edit/5
        public async Task<IActionResult> EditShelf(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelf = await ctx.FindShelf(id);
            if (shelf == null)
            {
                return NotFound();
            }
            var standShelfSize = ctx.GetStandardShellSize(1);
            ViewBag.StandardSize = new StandardSize
            {
                StandardFloor = standShelfSize.StandardFloor,
                StandardCell = standShelfSize.StandardCell
            };
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
            var standShelfSize = ctx.GetStandardShellSize(1);
            if (ModelState.IsValid)
            {
                try
                {
                    //lấy tổng số row của table cell, floor của id
                    int currentCellNumber = ctx.CellCount(id);
                    int currentFloorNumber = ctx.FloorCount(id);

                    //thay đổi floor number tăng so với floor number hiện tại 
                    if (currentFloorNumber < shelf.FloorNumber)
                    {
                        await ctx.UpdateShelf(shelf);

                        for (int i = 1; i <= shelf.FloorNumber; i++)
                        {
                            string myFloorId = $"{shelf.ShelfId}-{i}";
                            if (!ctx.FloorExists(myFloorId))
                            {
                                Floor floor = new Floor
                                {
                                    FloorId = $"{shelf.ShelfId}-{i}",
                                    ShelfId = shelf.ShelfId
                                };
                                await ctx.AddFloor(floor);
                            }
                        };
                    }

                    //thay đổi cell number tăng hoặc floor number tăng với cell number, floor number hiện tại
                    if (currentCellNumber < (shelf.CellNumber * shelf.FloorNumber)
                        || (currentFloorNumber != shelf.FloorNumber && currentFloorNumber < shelf.FloorNumber))
                    {
                        await ctx.UpdateShelf(shelf);

                        for (int i = 1; i <= shelf.FloorNumber; i++)
                        {
                            for (int j = 1; j <= shelf.CellNumber; j++)
                            {
                                string myCellId = $"{shelf.ShelfId}-{i}-{j}";
                                if (!ctx.CellExists(myCellId))
                                {
                                    Cell cell = new Cell
                                    {
                                        CellId = $"{shelf.ShelfId}-{i}-{j}",
                                        FloorId = $"{shelf.ShelfId}-{i}"
                                    };
                                    await ctx.AddCell(cell);
                                }
                            }
                        };
                    }
                    //if (currentCellNumber > (shelf.CellNumber * shelf.FloorNumber) ||
                    //    currentFloorNumber > shelf.FloorNumber)
                    //{
                    //    int oldCellNumber = currentCellNumber / currentFloorNumber;
                    //    for (int i = 1; i <= currentFloorNumber; i++)
                    //    {
                    //        for (int j = 1; j <= oldCellNumber; j++)
                    //        {
                    //            var cellId = $"{shelf.ShelfId}-{i}-{j}";
                    //            var cell = await ctx.Cells.FindAsync(cellId);
                    //            ctx.Cells.Remove(cell);
                    //            await ctx.SaveChangesAsync();
                    //        }
                    //    };

                    //    for (int i = 1; i <= currentFloorNumber; i++)
                    //    {
                    //        var floorId = $"{shelf.ShelfId}-{i}";
                    //        var floor = await ctx.Floors.FindAsync(floorId);
                    //        ctx.Floors.Remove(floor);
                    //        await ctx.SaveChangesAsync();
                    //    };

                    //    ctx.Update(shelf);
                    //    await ctx.SaveChangesAsync();

                    //    for (int i = 1; i <= shelf.FloorNumber; i++)
                    //    {
                    //        Floor floor = new Floor
                    //        {
                    //            FloorId = $"{shelf.ShelfId}-{i}",
                    //            ShelfId = shelf.ShelfId
                    //        };
                    //        ctx.Add(floor);
                    //        await ctx.SaveChangesAsync();
                    //    }
                    //    for (int i = 1; i <= shelf.FloorNumber; i++)
                    //    {
                    //        for (int j = 1; j <= shelf.CellNumber; j++)
                    //        {
                    //            Cell cell = new Cell
                    //            {
                    //                CellId = $"{shelf.ShelfId}-{i}-{j}",
                    //                FloorId = $"{shelf.ShelfId}-{i}"
                    //            };
                    //            ctx.Add(cell);
                    //            await ctx.SaveChangesAsync();
                    //        }
                    //    };
                    //}

                    if (standShelfSize.StandardCell < (currentCellNumber / currentFloorNumber)
                        || standShelfSize.StandardFloor < currentFloorNumber)
                    {
                        ViewBag.UpdateShelfSize = "Cant decrease shelf size, please remove all packages !!!";
                        ViewBag.StandardSize = new StandardSize
                        {
                            StandardFloor = standShelfSize.StandardFloor,
                            StandardCell = standShelfSize.StandardCell
                        };
                        return View(shelf);
                    }

                    if (standShelfSize.StandardCell == shelf.CellNumber && standShelfSize.StandardFloor == shelf.FloorNumber)
                    {
                        await ctx.UpdateShelf(shelf);
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
            ViewBag.StandardSize = new StandardSize
            {
                StandardFloor = standShelfSize.StandardFloor,
                StandardCell = standShelfSize.StandardCell
            };
            return View(shelf);
        }
        public async Task<IActionResult> ActiveShelf(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shelf = await ctx.GetShelf(id);
            if (shelf == null)
            {
                return NotFound();
            }
            return PartialView("ActiveShelf", shelf);
        }
        [HttpPost, ActionName("ActiveShelf")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ActiveConfirmed(string id)
        {
            var shelf = await ctx.FindShelf(id);
            shelf.Status = true;
            await ctx.UpdateShelf(shelf);
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                var floorId = $"{id}-{i}";
                var floor = await ctx.FindFloor(floorId);
                floor.Status = true;
                await ctx.UpdateFloor(floor);
            };
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                for (int j = 1; j <= shelf.CellNumber; j++)
                {
                    var cellId = $"{id}-{i}-{j}";
                    var cell = await ctx.FindCell(cellId);
                    cell.Status = true;
                    await ctx.UpdateCell(cell);
                }
            };
            return RedirectToAction(nameof(ListAllShelf));
        }
        public async Task<IActionResult> DeactiveShelf(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shelf = await ctx.GetShelf(id);
            if (shelf == null)
            {
                return NotFound();
            }
            var cells = ctx.GetAllCellById(shelf.ShelfId);
            List<int> packCountList = new List<int>();
            foreach (var cell in cells)
            {
                //int packageCount = ctx.Packages.Count(p => p.CellId == cell.CellId);
                int packageCount = ctx.PackageCountById(cell.CellId);
                packCountList.Add(packageCount);
            }
            int totalInList = 0;
            packCountList.ForEach(item =>
            {
                totalInList += item;
            });
            if (totalInList == 0)
            {
                return PartialView("DeactiveShelf", shelf);
            }
            else
            {
                return PartialView("DeactiveFail", shelf);
            }
        }
        [HttpPost, ActionName("DeactiveShelf")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeactiveConfirmed(string id)
        {
            var shelf = await ctx.FindShelf(id);
            shelf.Status = false;
            await ctx.UpdateShelf(shelf);
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                var floorId = $"{id}-{i}";
                var floor = await ctx.FindFloor(floorId);
                floor.Status = false;
                await ctx.UpdateFloor(floor);
            };
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                for (int j = 1; j <= shelf.CellNumber; j++)
                {
                    var cellId = $"{id}-{i}-{j}";
                    var cell = await ctx.FindCell(cellId);
                    cell.Status = false;
                    await ctx.UpdateCell(cell);
                }
            };
            return RedirectToAction(nameof(ListAllShelf));
        }
        // GET: Shelf/Delete/5
        public async Task<IActionResult> DeleteShelf(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelf = await ctx.GetShelf(id);
            if (shelf == null)
            {
                return NotFound();
            }
            var cells = ctx.GetAllCellById(shelf.ShelfId);
            List<int> packCountList = new List<int>();
            foreach (var cell in cells)
            {
                //int packageCount = ctx.Packages.Count(p => p.CellId == cell.CellId);
                int packageCount = ctx.PackageCountById(cell.CellId);
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
            }
            else
            {
                return PartialView("DeleteShelfFail", shelf);
            }
        }

        // POST: Shelf/Delete/5
        [HttpPost, ActionName("DeleteShelf")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var shelf = await ctx.FindShelf(id);
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                for (int j = 1; j <= shelf.CellNumber; j++)
                {
                    var cellId = $"{id}-{i}-{j}";
                    await ctx.DeleteCell(cellId);
                }
            };
            for (int i = 1; i <= shelf.FloorNumber; i++)
            {
                var floorId = $"{id}-{i}";
                await ctx.DeleteFloor(floorId);
            };
            await ctx.DeleteShelf(shelf.ShelfId);
            return RedirectToAction(nameof(ListAllShelf));
        }

        private bool ShelfExists(string id)
        {
            return ctx.ShelfExists(id);
        }

        public IActionResult BackToShelfList()
        {
            return RedirectToAction(nameof(ListAllShelf));
        }
        [HttpGet]
        public async Task<IActionResult> EditShelfSize(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var standardSize = await ctx.FindStandardShelfSize(id);
            if (standardSize == null)
            {
                return NotFound();
            }
            return View(standardSize);
        }
        [HttpPost]
        public async Task<IActionResult> EditShelfSize(int? id, StandardShellSize standardSize)
        {
            if (id != standardSize.StandardShellId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await ctx.UpdateStandardShelfSize(standardSize);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StandardSizeExists(standardSize.StandardShellId))
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
            return View(standardSize);
        }

        public bool StandardSizeExists(int id)
        {
            return ctx.StandardSizeExists(id);
        }

        public async Task<IActionResult> ShowCell(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cells = await ctx.ShowCell(id);
            return PartialView("ShowCell", cells);
        }
    }
}
