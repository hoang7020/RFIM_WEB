using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RFIM_Web.Models;
using RFIM_Web.ModelView;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly MyDbContext context;
        public UserController(MyDbContext _ctx)
        {
            context = _ctx;
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
            var loggedUser = context.Users.SingleOrDefault(p => p.Username == model.Username && p.Password == model.Password);
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
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, loggedUser.Username) };
            ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
            if (loggedUser.RoleId == 1)
            {
                return RedirectToAction("Index", "Admin");
            } else if(loggedUser.RoleId == 2)
            {
                return RedirectToAction("Index", "Accountant");
            } else
            {
                return RedirectToAction("Index", "Stockkeeper");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "User");
        }

    }
}