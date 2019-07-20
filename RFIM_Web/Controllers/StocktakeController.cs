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
    }
}