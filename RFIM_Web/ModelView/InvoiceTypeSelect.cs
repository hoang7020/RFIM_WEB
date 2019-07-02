using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class InvoiceTypeSelect
    {
        public List<InvoiceType> Data { get; set; }
        public int? Select { get; set; }
    }
}
