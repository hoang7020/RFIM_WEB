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
        User FindUser(int? id);
        User FindUserByName(string username);
        User GetUser(int? id);
        void AddUser(User model);
        void UpdateUser(User model);
        void DeleteUser(int id);
        bool UserExists(int id);
        bool UsernameExists(string name);
        List<Role> GetRole();
        User GetLoggedUser(LoginView model);
        int UserCount();
        int ActiveUserCount();
        int AccountantCount();
        int StockkeeperCount();
    }
}
