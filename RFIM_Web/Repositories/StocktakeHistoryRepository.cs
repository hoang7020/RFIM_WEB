using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFIM_Web.Repositories
{
    public class StocktakeHistoryRepository : IStocktakeHistoryRepository
    {
        protected readonly MyDbContext ctx;
        public StocktakeHistoryRepository(MyDbContext db)
        {
            ctx = db;
        }

        public List<StocktakeHistory> GetStocktakeHistories()
        {
            return ctx.StocktakeHistories.Include(p => p.Product).Include(u => u.User).OrderByDescending(s => s.Date).ToList();
        }
    }
}
