using Microsoft.AspNetCore.Mvc;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Components
{
    public class QuantityBoxInPackage : ViewComponent
    {
        private readonly MyDbContext ctx;
        public QuantityBoxInPackage(MyDbContext db)
        {
            ctx = db;
        }
        public IViewComponentResult Invoke(string packageRFID = "") 
        {
            QuantityBox boxCount = new QuantityBox
            {
                BoxCount = ctx.Boxes.Count(p => p.PackageRFID == packageRFID && p.Status == true)
            }; 
            return View(boxCount);
        }
    }
}
