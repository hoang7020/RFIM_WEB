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
    public class UserRepository : IUser
    {
        protected readonly MyDbContext ctx;
        public UserRepository(MyDbContext db)
        {
            ctx = db;
        }

        public async Task AddUser(User model)
        {
            ctx.Add(model);
            await Save();
        }

        public async Task DeleteUser(int id)
        {
            var user = await ctx.Users.SingleOrDefaultAsync(p => p.RoleId == id);
            ctx.Users.Remove(user);
            await Save();
        }

        public async Task<User> FindUser(int? id)
        {
           return await ctx.Users.FindAsync(id);
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
                .SingleOrDefault(p => p.Username == model.Username && p.Password == model.Password);
        }

        public List<Role> GetRole()
        {
            return ctx.Roles.ToList();
        }

        public async Task<User> GetUser(int? id)
        {
            return await ctx.Users.Include(p => p.Role).FirstOrDefaultAsync(p => p.UserId == id);
        }

        public async Task UpdateUser(User model)
        {
            ctx.Users.Update(model);
            await Save();
        }

        public bool UserExists(int id)
        {
            return ctx.Users.Any(p => p.UserId == id);
        }
        private async Task Save()
        {
            await ctx.SaveChangesAsync();
        }
    }
}
