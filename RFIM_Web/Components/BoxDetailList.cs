using Microsoft.AspNetCore.Mvc;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Components
{
    public class BoxDetailList : ViewComponent
    {
        private readonly MyDbContext ctx;
        public BoxDetailList(MyDbContext db)
        {
            ctx = db;
        }

        public IViewComponentResult Invoke(string packageRFID = "")
        {
            return View(ctx.Boxes.Where(p => p.PackageRFID == packageRFID).ToList());
        }
    }
}
