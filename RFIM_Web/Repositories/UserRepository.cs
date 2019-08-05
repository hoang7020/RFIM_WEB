using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly MyDbContext ctx;
        public UserRepository(MyDbContext db)
        {
            ctx = db;
        }

        public void AddUser(User model)
        {
            ctx.Add(model);
            Save();
        }

        public void DeleteUser(int id)
        {
            var user = ctx.Users.SingleOrDefault(p => p.RoleId == id);
            ctx.Users.Remove(user);
            Save();
        }

        public User FindUser(int? id)
        {
            return ctx.Users.Find(id);
        }

        public User FindUserByName(string username)
        {
            return ctx.Users.Where(p => p.Username == username).FirstOrDefault();
        }

        public List<User> GetAll()
        {
            return ctx.Users.Where(p => p.RoleId == 2 || p.RoleId == 3)
                .Include(p => p.Role).ToList();
        }
        public List<User> GetAllAccountant()
        {
            return ctx.Users.Where(p => p.RoleId == 2)
                .Include(p => p.Role).ToList();
        }

        public List<User> GetAllStockkeeper()
        {
            return ctx.Users.Where(p => p.RoleId == 3)
                .Include(p => p.Role).ToList();
        }

        public User GetLoggedUser(LoginView model)
        {
            return ctx.Users.Include(p => p.Role)
                .FirstOrDefault(p => p.Username == model.Username && p.Password == model.Password);
        }

        public List<Role> GetRole()
        {
            return ctx.Roles.ToList();
        }

        public User GetUser(int? id)
        {
            return ctx.Users.Include(p => p.Role).FirstOrDefault(p => p.UserId == id);
        }

        public void UpdateUser(User model)
        {
            ctx.Users.Update(model);
            Save();
        }

        public bool UserExists(int id)
        {
            return ctx.Users.Any(p => p.UserId == id);
        }
        public bool UsernameExists(string name)
        {
            return ctx.Users.Any(p => p.Username.Equals(name));
        }
        public bool UsernameExistsExceptId(int id, string name)
        {
            return ctx.Users.Where(p => p.UserId != id).Any(p => p.Username.Equals(name));
        }
       
        public int UserCount()
        {
            return ctx.Users.Count();
        }
        public int ActiveUserCount()
        {
            return ctx.Users.Count(p => p.Status == true);
        }
        public int AccountantCount()
        {
            return ctx.Users.Count(p => p.Role.RoleName == "Accountant");
        }
        public int StockkeeperCount()
        {
            return ctx.Users.Count(p => p.Role.RoleName == "Stockkeeper");
        }
        private void Save()
        {
            ctx.SaveChanges();
        }
    }
}
