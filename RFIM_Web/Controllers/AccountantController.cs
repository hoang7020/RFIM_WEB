﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class AccountantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}