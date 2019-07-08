using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;

namespace RFIM_Web.Controllers
{
    public class StocktakeController : Controller
    {
        private readonly MyDbContext ctx;
        public StocktakeController(MyDbContext db)
        {
            ctx = db;
        }

        public IActionResult ListAllStocktake()
        {
            var ListStocktake = ctx.StocktakeHistories.Include(p => p.Product).Include(u => u.User).ToList();
            return View(ListStocktake);
        }
    }
}