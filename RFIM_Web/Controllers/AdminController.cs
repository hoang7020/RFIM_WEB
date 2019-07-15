using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using RFIM_Web.Utils;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IUser ctx;
        public AdminController(IUser db)
        {
            ctx = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListAllUser()
        {
            var dsStaff = ctx.GetAll();
            return View(dsStaff);
        }
        [HttpGet]
        public IActionResult ListAccountant()
        {
            var dsAccountant = ctx.GetAllAccountant();
            return View(dsAccountant);
        }
        [HttpGet]
        public IActionResult ListStockkeeper()
        {
            var dsStockkeeper = ctx.GetAllStockkeeper();
            return View(dsStockkeeper);
        }
        [HttpGet]
        public async Task<IActionResult> EditUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await ctx.FindUser(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await ctx.UpdateUser(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ListAllUser");
            }
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                await ctx.AddUser(user);
                return RedirectToAction(nameof(ListAllUser));
            }
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }
        public async Task<IActionResult> DeleteUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await ctx.GetUser(id);
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
            var user = await ctx.FindUser(id);
            user.Status = false;
            await ctx.UpdateUser(user);
            return RedirectToAction(nameof(ListAllUser));
        }
        public async Task<IActionResult> ActiveUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await ctx.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return PartialView("ActiveUser", user);
        }
        [HttpPost, ActionName("ActiveUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmActive(int id)
        {
            var user = await ctx.FindUser(id);
            user.Status = true;
            await ctx.UpdateUser(user);
            return RedirectToAction(nameof(ListAllUser));
        }
        public bool UserExists(int id)
        {
            return ctx.UserExists(id);
        }

        public IActionResult BackToUserList()
        {
            return RedirectToAction(nameof(ListAllUser));
        }
    }
}