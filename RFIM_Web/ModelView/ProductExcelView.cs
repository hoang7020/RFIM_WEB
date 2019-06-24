using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class ProductExcelView
    {
        [Key]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Weight { get; set; }
        public string Category { get; set; }
        public string Vendor { get; set; }
    }
}
