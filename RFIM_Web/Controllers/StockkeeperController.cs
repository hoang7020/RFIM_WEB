﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;

namespace RFIM_Web.Controllers
{
    [Authorize]
    public class StockkeeperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
    }
}