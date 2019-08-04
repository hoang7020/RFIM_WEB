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

        public StocktakeHistory FindStocktake(int id)
        {
            return ctx.StocktakeHistories.Find(id);
        }

        public List<FullStockTakeHistory> GetStocktakeHistories()
        {
            List <FullStockTakeHistory> fullStockTakeHistories = (from sh in ctx.StocktakeHistories
                                                                  group new { sh, sh.Product, sh.User } by new
                                                                  {
                                                                      sh.StocktakeHistoryId,
                                                                      sh.Product.ProductId,
                                                                      sh.Product.ProductName,
                                                                      sh.Status,
                                                                      sh.Date,
                                                                      sh.Quantity,
                                                                      sh.User.Username,
                                                                      sh.LostBox,
                                                                      sh.FoundBox
                                                                  } into sh
                                                                  select new FullStockTakeHistory
                                                                  {
                                                                      StocktakeHistoryId = sh.Key.StocktakeHistoryId,
                                                                      ProductId = sh.Key.ProductId,
                                                                      ProductName = sh.Key.ProductName,
                                                                      Status = sh.Key.Status,
                                                                      Date = sh.Key.Date,
                                                                      StocktakeQuantity = sh.Key.Quantity,
                                                                      AvailableQuantity = ctx.Boxes.Count(x => x.ProductId == sh.Key.ProductId),
                                                                      UserName = sh.Key.Username,
                                                                  }).ToList();
            return fullStockTakeHistories;
        }

        public void UpdateStockTakeStatus(StocktakeHistory stocktakeHistory)
        {
            ctx.Update(stocktakeHistory);
            Save();
        }

        public Box FindBox(string boxRFID)
        {
            return ctx.Boxes.Find(boxRFID);
        }

        public void UpdateStatusBox(Box box)
        {
            ctx.Update(box);
            Save();
        }
        private void Save()
        {
            ctx.SaveChanges();
        }
    }
}
