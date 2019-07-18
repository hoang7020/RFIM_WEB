using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using RFIM_Web.ModelView;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserRepository ctx;
        public UserController( IUserRepository db)
        {
            ctx = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet, AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(LoginView model)
        {
            var loggedUser =await ctx.GetLoggedUser(model);
            if (loggedUser == null)
            {
                ViewBag.LoiDangNhap = "The username or password that you've entered doesn't match any account.Please try again";
                return View();
            }
            else if (!loggedUser.Status)
            {
                ViewBag.HetHieuLuc = "The account is not actived";
                return View();
            }
            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name, loggedUser.Username),
                new Claim(ClaimTypes.Role, loggedUser.Role.RoleName)
            };

            ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);

            await HttpContext.SignInAsync(claimsPrincipal);

            HttpContext.Session.SetString("User", loggedUser.Username);

            return RedirectToAction("Index", "Admin");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("User");
            return RedirectToAction("Login", "User");
        }

    }
}