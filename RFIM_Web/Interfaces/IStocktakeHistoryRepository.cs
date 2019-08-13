using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RFIM_Web.Models;
using RFIM_Web.ModelView;

namespace RFIM_Web.Interfaces
{
    public interface IStocktakeHistoryRepository
    {
        List<FullStockTakeHistory> GetStocktakeHistories();
        StocktakeHistory FindStocktake(int id);
        void UpdateStockTakeStatus(StocktakeHistory stocktakeHistory);
        void UpdateStatusBox(Box box);
        Box FindBox(string boxRFID);
    }
}
