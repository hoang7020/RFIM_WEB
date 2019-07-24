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
    public class PackageInShelf : ViewComponent
    {
        protected readonly IShelfRepository ctx;
        public PackageInShelf(IShelfRepository db)
        {
            ctx = db;
        }
        public IViewComponentResult Invoke(string shelfId = "")
        {
            int countPackageInShelf = 0;
            var cells = ctx.GetAllCellById(shelfId);
            cells.ForEach(cell =>
            {
                if (ctx.PackageInCell(cell.CellId))
                {
                    countPackageInShelf++;
                }
            });
            ShelfStatus ss = new ShelfStatus
            {
                PackageCountInShelf = countPackageInShelf
            };
            return View(ss);
        }
    }
}
