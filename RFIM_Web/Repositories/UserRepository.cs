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

        public async Task<List<User>> GetAll()
        {
            return await ctx.Users.Where(p => p.RoleId == 2 || p.RoleId == 3)
                .Include(p => p.Role).ToListAsync();
        }
        public async Task<List<User>> GetAllAccountant()
        {
            return await ctx.Users.Where(p => p.RoleId == 2)
                .Include(p => p.Role).ToListAsync();
        }

        public async Task<List<User>> GetAllStockkeeper()
        {
            return await ctx.Users.Where(p => p.RoleId == 3)
                .Include(p => p.Role).ToListAsync();
        }

        public async Task<User> GetLoggedUser(LoginView model)
        {
            return await ctx.Users.Include(p => p.Role)
                .SingleOrDefaultAsync(p => p.Username == model.Username && p.Password == model.Password);
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
        private async Task Save()
        {
            await ctx.SaveChangesAsync();
        }
    }
}
