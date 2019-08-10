using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategory();
        void CreateCategory(Category model);
        void UpdateCategory(Category model);
        void DeactiveCategory(Category model);
        void ActiveCategory(Category model);
        bool CategoryExists(int id);
        bool CategoryNameExists(string name);
        Category FindCategoryById(int? id);
        Category GetCategory(int? id);
        bool CategoryExistsInProduct(int? id);
    }
}
