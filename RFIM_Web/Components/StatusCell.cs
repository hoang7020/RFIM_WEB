using Microsoft.AspNetCore.Mvc;
using RFIM_Web.Interfaces;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Components
{
    public class StatusCell : ViewComponent
    {
        protected readonly IShelfRepository ctx;
        public StatusCell(IShelfRepository db)
        {
            ctx = db;
        }
        public IViewComponentResult Invoke(string cellId = "")
        {
            bool status = ctx.PackageInCell(cellId);
            var package = ctx.PackageRFIDInCell(cellId);
            string packageRFID = "";
            if (package != null)
            {
                packageRFID = package.PackageRFID;
            } else
            {
                packageRFID = "Empty";
            }
            CellStatus cellStatus = new CellStatus
            {
                StatusCell = status,
                PackageRFID = packageRFID
            };
            return View(cellStatus);
        }
    }
}
