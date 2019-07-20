using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RFIM_Web.Models;

namespace RFIM_Web.Interfaces
{
    public interface IStocktakeHistoryRepository
    {
        List<StocktakeHistory> GetStocktakeHistories();
    }
}
