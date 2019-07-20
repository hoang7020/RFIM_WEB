using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class ProductExtendAttr
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? QuantityPerBox { get; set; }
        public string Category { get; set; }
        public string Vendor { get; set; }
        public int InstockQuantity { get; set;}
    }
}
