using RFIM_Web.Models;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        List<User> GetAllAccountant();
        List<User> GetAllStockkeeper();
        Task<User> FindUser(int? id);
        Task<User> GetUser(int? id);
        Task AddUser(User model);
        Task UpdateUser(User model);
        Task DeleteUser(int id);
        bool UserExists(int id);
        List<Role> GetRole();
        User GetLoggedUser(LoginView model);
        int UserCount();
        int ActiveUserCount();
        int AccountantCount();
        int StockkeeperCount();
    }
}
