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
        Task AddProduct(Product model);
        Task<Product> FindProductById(string id);
        bool ProductNameExistExceptId(string id, string name);
        Task UpdateProduct(Product model);
        Task<Product> GetProduct(string id);
        Task<List<Package>> GetAllPackageById(string id);
        Product GetProductById(string id);
    }
}
