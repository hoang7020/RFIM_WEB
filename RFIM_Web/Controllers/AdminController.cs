using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;
using RFIM_Web.ModelView;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly MyDbContext context;
        public AdminController(MyDbContext _ctx)
        {
            context = _ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListAllUser()
        {
            var dsStaff = context.Users.Where(p => p.RoleId == 2 || p.RoleId == 3)
                .Include(p => p.Role).Select(p => new ListUserView
                {
                    UserId = p.UserId,
                    Fullname = p.Fullname,
                    Username = p.Username,
                    Password = p.Password,
                    Email = p.Email,
                    Phone = p.Phone,
                    Role = p.Role.RoleName,
                    Status = p.Status
                });
            return View(dsStaff);
        }
        [HttpGet]
        public IActionResult ListAccountant()
        {
            var dsAccountant = context.Users.Where(p => p.RoleId == 2).Include(p => p.Role)
                .Select(p => new ListUserView
                {
                    UserId = p.UserId,
                    Fullname = p.Fullname,
                    Username = p.Username,
                    Password = p.Password,
                    Email = p.Email,
                    Phone = p.Phone,
                    Role = p.Role.RoleName,
                    Status = p.Status
                });
            return View(dsAccountant);
        }
        [HttpGet]
        public IActionResult ListStockkeeper()
        {
            var dsStockkeeper = context.Users.Where(p => p.RoleId == 3).Include(p => p.Role)
                .Select(p => new ListUserView
                {
                    UserId = p.UserId,
                    Fullname = p.Fullname,
                    Username = p.Username,
                    Password = p.Password,
                    Email = p.Email,
                    Phone = p.Phone,
                    Role = p.Role.RoleName,
                    Status = p.Status
                });
            return View(dsStockkeeper);
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            if(id != null)
            {
                return NotFound();
            }
            var user = context.Users.SingleOrDefault(p => p.UserId == id);
            if(user != null)
            {
                return NotFound();
            }
            return PartialView("EditUser", user);
        }
    }
}