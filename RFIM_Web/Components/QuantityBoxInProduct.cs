using Microsoft.AspNetCore.Mvc;
using RFIM_Web.Interfaces;
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
        protected readonly IProductRepository ctx;
        public QuantityBoxInProduct(IProductRepository db)
        {
            ctx = db;
        }
        public IViewComponentResult Invoke(string productId = "")
        {
            BoxInProduct countBoxInProduct = new BoxInProduct
            {
                CountBoxInProduct = ctx.GetQuantityBox(productId)
            };
            return View(countBoxInProduct);
        }
    }
}
