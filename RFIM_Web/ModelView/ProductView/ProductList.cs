using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class ProductList
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Vendor { get; set; }
        public int? QuantityperBox { get; set; }
    }
}
