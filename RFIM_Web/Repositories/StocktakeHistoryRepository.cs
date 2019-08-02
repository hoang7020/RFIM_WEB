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

        public List<FullStockTakeHistory> GetStocktakeHistories()
        {
            List <FullStockTakeHistory> fullStockTakeHistories = (from b in ctx.Boxes
                                             from sh in ctx.StocktakeHistories
                                             group new { sh, sh.StocktakeStatus, sh.User, b.Product, b } by new
                                             {
                                                 sh.StocktakeHistoryId,
                                                 sh.ProductId,
                                                 sh.StocktakeStatus.StocktakeStatusName,
                                                 sh.User.Username,
                                                 sh.Quantity,
                                                 sh.Date,
                                                 Product = sh.Product.ProductId,
                                                 sh.Product.ProductName,
                                                 sh.Description
                                             } into sh
                                             select new FullStockTakeHistory
                                             {
                                                 StocktakeHistoryId = sh.Key.StocktakeHistoryId,
                                                 ProductId = sh.Key.ProductId,
                                                 Date = sh.Key.Date,
                                                 StocktakeQuantity = sh.Key.Quantity,
                                                 StocktakeStatusName = sh.Key.StocktakeStatusName,
                                                 UserName = sh.Key.Username,
                                                 ProductName = sh.Key.ProductName,
                                                 Description = sh.Key.Description,
                                                 AvailableQuantity = sh.Count(p => p.b.ProductId != null)
                                             }).ToList();
            return fullStockTakeHistories;
        }
    }
}
