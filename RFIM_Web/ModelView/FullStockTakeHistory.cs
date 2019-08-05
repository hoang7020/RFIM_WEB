using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class FullStockTakeHistory
    {
        public int StocktakeHistoryId { get; set; }
        public int StocktakeQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime Date { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string UserName { get; set; }
        public bool Status { get; set; }
    }
}
