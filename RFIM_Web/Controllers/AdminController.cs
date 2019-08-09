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
        private readonly IUserRepository ctx;
        private readonly IHomeRepository _ctx;
        public AdminController(IUserRepository db, IHomeRepository _db)
        {
            ctx = db;
            _ctx = _db;
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
        public IActionResult CreateUser()
        {
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                if (ctx.UsernameExists(user.Username))
                {
                    ViewBag.UsernameExisted = "Username is already existed !!!!";
                    ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
                    return View(user);
                }
                user.Status = true;
                ctx.AddUser(user);
                return RedirectToAction(nameof(ListAllUser));
            }
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }

        [HttpGet]
        public IActionResult EditUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = ctx.FindUser(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (ctx.UsernameExists(user.Username))
                {
                    ViewBag.UsernameExisted = "Username is already existed !!!!";
                    ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
                    return View(user);
                } else 
                {
                    try
                    {
                        user.Status = true;
                        ctx.UpdateUser(user);
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
                }
                return RedirectToAction("ListAllUser");
            }
            ViewData["RoleId"] = new SelectList(ctx.GetRole(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }
       
        public IActionResult DeleteUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = ctx.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return PartialView("DeleteUser", user);
        }
        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            var user = ctx.FindUser(id);
            ctx.DeactiveUser(user);
            return RedirectToAction(nameof(ListAllUser));
        }
        public IActionResult ActiveUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = ctx.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return PartialView("ActiveUser", user);
        }
        [HttpPost, ActionName("ActiveUser")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmActive(int id)
        {
            var user = ctx.FindUser(id);
            ctx.ActiveUser(user);
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
        public IActionResult Index()
        {
            int totalUser = ctx.UserCount();
            int totalActiveUser = ctx.ActiveUserCount();
            int totalAccountant = ctx.AccountantCount();
            int totalStockkeeper = ctx.StockkeeperCount();
            ViewBag.UserCount = new AdminHomePage
            {
                Users = totalUser,
                ActiveUsers = totalActiveUser,
                Accountants = totalAccountant,
                Stockkeepers = totalStockkeeper
            };
            int totalCategory = _ctx.CategoryCount();
            int totalVendor = _ctx.VendorCount();
            int totalProduct = _ctx.ProductCount();
            int totalShelf = _ctx.ShelfCount();
            int receivePending = _ctx.ReceivesPendingCount();
            int issuePending = _ctx.IssuesPendingCount();
            List<Invoice> listReceives = _ctx.GetReceives();
            List<Invoice> listIssues = _ctx.GetIssues();
            ViewBag.AccountantInfo = new AccountantHomePage
            {
                Categories = totalCategory,
                Vendors = totalVendor,
                Products = totalProduct,
                Shelfs = totalShelf,
                ReceivePendingCount = receivePending,
                IssuePendingCount = issuePending,
                Receives = listReceives,
                Issues = listIssues
            };
            return View();
        }
    }
}