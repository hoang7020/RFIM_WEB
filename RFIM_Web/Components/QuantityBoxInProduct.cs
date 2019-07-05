using Microsoft.AspNetCore.Mvc;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Components
{
    public class QuantityBoxInProduct : ViewComponent
    {
        private readonly MyDbContext ctx;
        public QuantityBoxInProduct(MyDbContext db)
        {
            ctx = db;
        }
        public IViewComponentResult Invoke(string productId = "")
        {
            BoxInProduct countBoxInProduct = new BoxInProduct
            {
                CountBoxInProduct = ctx.Boxes.Count(p => p.ProductId == productId)
            };
            return View(countBoxInProduct);
        }
    }
}
