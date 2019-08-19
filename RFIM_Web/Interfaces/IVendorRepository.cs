using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface IVendorRepository
    {
        List<Vendor> GetAllVendor();
        void CreateVendor(Vendor model);
        void UpdateVendor(Vendor model);
        void DeactiveVendor(Vendor model);
        void ActiveVendor(Vendor model);
        bool VendorExists(int id);
        bool VendorNameExists(string name);
        bool VendorNameExistsExceptId(int id, string name);
        Vendor FindVendorById(int? id);
        Vendor GetVendor(int? id);
        bool VendorExistsInProduct(int? id);
    }
}
