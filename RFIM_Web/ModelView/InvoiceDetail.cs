using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class InvoiceDetail
    {
        public Invoice Invoices { get; set; }
        public List<ProductList> productList { get; set; }
    }
}
