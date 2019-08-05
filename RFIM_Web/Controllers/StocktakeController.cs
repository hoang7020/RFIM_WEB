using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;
using RFIM_Web.Repositories;
using RFIM_Web.Interfaces;

namespace RFIM_Web.Controllers
{
    public class StocktakeController : Controller
    {
        private readonly IStocktakeHistoryRepository context;
        public StocktakeController(IStocktakeHistoryRepository _context)
        {
            context = _context;
        }

        public IActionResult ListAllStocktake()
        {
            return View(context.GetStocktakeHistories());
        }

        public IActionResult EditStocktake(int id)
        {
            var stocktake = context.FindStocktake(id);
            if (stocktake == null)
            {
                return NotFound();
            }
            else
            {
                return PartialView("EditStocktake", stocktake);
            }
        }

        [HttpPost, ActionName("EditStocktake")]
        [ValidateAntiForgeryToken]
        public IActionResult WipeConfirm(int id)
        {
            StocktakeHistory stocktake = context.FindStocktake(id);
            string[] ListFoundRFID = stocktake.FoundBox.ToString().Split(",");
            string[] ListLostRFID = stocktake.LostBox.ToString().Split(",");
            if ((!string.IsNullOrEmpty(ListFoundRFID[0])))
            {
                foreach (string foundBoxRFID in ListFoundRFID)
                {
                    Box box = context.FindBox(foundBoxRFID);
                    if (box != null)
                    {
                        box.Status = true;
                        context.UpdateStatusBox(box);
                    }
                }
            }
            if ((!string.IsNullOrEmpty(ListLostRFID[0])))
            {
                foreach (string lostBoxRFID in ListLostRFID)
                {
                    Box box = context.FindBox(lostBoxRFID);
                    if (box != null)
                    {
                        box.Status = false;
                        context.UpdateStatusBox(box);
                    }
                }
            }
            stocktake.Status = false;
            context.UpdateStockTakeStatus(stocktake);
            return RedirectToAction(nameof(ListAllStocktake));
        }

        public IActionResult BackToStocktakeList()
        {
            return RedirectToAction(nameof(ListAllStocktake));

        }
    }
}