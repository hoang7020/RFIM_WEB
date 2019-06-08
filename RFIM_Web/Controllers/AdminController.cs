using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> EditUser(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var user = await context.Users.FindAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            ViewBag.RoleSelect = new RoleSelectModel
            {
                Data = context.Roles.ToList(),
                Select = user.RoleId
            };
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(int id, User user)
        {
            if(id != user.UserId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(user);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId)){
                        return NotFound();
                    } else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ListAllUser");
            }
            ViewData["RoleId"] = new SelectList(context.Roles, "RoleId", "RoleId", user.RoleId);
            return View(user);
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            ViewData["RoleId"] = new SelectList(context.Roles, "RoleId", "RoleId");
            ViewBag.RoleSelect = new RoleSelectModel
            {
                Data = context.Roles.ToList()
            };
            return PartialView("CreateUser");
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                context.Add(user);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(ListAllUser));
            }
            ViewData["RoleId"] = new SelectList(context.Roles, "RoleId", "RoleId", user.RoleId);
            return PartialView("CreateUser", user);
        }
        public async Task<IActionResult> DeleteUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await context.Users.Include(u => u.Role).FirstOrDefaultAsync(p => p.UserId == id);
            if (user == null)
            {
                return NotFound();
            }
            return PartialView("DeleteUser", user);
        }
        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var user = await context.Users.FindAsync(id);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllUser));
        }
        public bool UserExists(int id)
        {
            return context.Users.Any(p => p.UserId == id);
        }
    }
}