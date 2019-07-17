using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class ProductDetailList
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public Vendor Vendor { get; set; }
    }
}
