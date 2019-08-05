using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProduct();
        List<Category> GetAllCategory();
        List<Vendor> GetAllVendor();
        bool ProductIdExists(string id);
        bool ProductNameExists(string name);
        void AddProduct(Product model);
        Product FindProductById(string id);
        bool ProductNameExistExceptId(string id, string name);
        bool ProductExistInPackage(string id);
        void UpdateProduct(Product model);
        Product GetProduct(string id);
        List<Package> GetAllPackageById(string id);
        Product GetProductById(string id);
        int GetQuantityBox(string id);
    }
}
