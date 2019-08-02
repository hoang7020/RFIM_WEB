using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class AccountantHomePage
    {
        public int Categories { get; set; }
        public int Vendors { get; set; }
        public int Products { get; set; }
        public int Shelfs { get; set; }
        public int ReceivePendingCount { get; set; }
        public int IssuePendingCount { get; set; }
        public List<Invoice> Receives { get; set; }
        public List<Invoice> Issues { get; set; }
    }
}
