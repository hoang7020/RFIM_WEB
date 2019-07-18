using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface IHomeRepository
    {
        int CategoryCount();
        int VendorCount();
        int ProductCount();
        int ShelfCount();
        int ReceivesPendingCount();
        int IssuesPendingCount();
        List<Invoice> GetReceives();
        List<Invoice> GetIssues();
    }
}
