using Microsoft.AspNetCore.Mvc;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Components
{
    public class ProductDetailList : ViewComponent
    {
        private readonly MyDbContext ctx;
        public ProductDetailList(MyDbContext db)
        {
            ctx = db;
        }

        public IViewComponentResult Invoke()
        {
            return View(ctx.Products);
        }
    }
}
