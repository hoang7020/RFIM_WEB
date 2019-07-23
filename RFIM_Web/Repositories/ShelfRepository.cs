using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Repositories
{
    public class ShelfRepository : IShelfRepository
    {
        protected readonly MyDbContext ctx;
        public ShelfRepository(MyDbContext db)
        {
            ctx = db;
        }
        public List<Shelf> GetAllShelf()
        {
            return ctx.Shelfs.ToList();
        }

        public Shelf GetShelf(string id)
        {
            return  ctx.Shelfs.FirstOrDefault(p => p.ShelfId == id);
        }
        public Shelf FindShelf(string id)
        {
            return ctx.Shelfs.Find(id);
        }
        public Cell FindCell(string id)
        {
            return ctx.Cells.Find(id);
        }
        public Floor FindFloor(string id)
        {
            return ctx.Floors.Find(id);
        }
        
        public StandardShellSize FindStandardShelfSize(int? id)
        {
            return ctx.StandardShellSizes.Find(id);
        }
        public List<Cell> GetAllCellById(string id)
        {
            return ctx.Cells.Where(p => p.CellId.Contains(id)).ToList();
        }
        public StandardShellSize GetStandardShellSize(int? id)
        {
            return ctx.StandardShellSizes.SingleOrDefault(p => p.StandardShellId == id);
        }

        public int PackageCountById(string id)
        {
            return ctx.Packages.Count(p => p.CellId == id);
        }

        
        public int CellCount(string id)
        {
            return ctx.Cells.Where(p => p.CellId.Contains(id)).Count();
        }
        public int FloorCount(string id)
        {
            return ctx.Floors.Where(p => p.FloorId.Contains(id)).Count();
        }
        public void AddShelf(Shelf model)
        {
            ctx.Add(model);
            Save();
        }

        public void AddFloor(Floor model)
        {
            ctx.Add(model);
            Save();
        }

        public void AddCell(Cell model)
        {
            ctx.Add(model);
            Save();
        }

        public void UpdateShelf(Shelf model)
        {
            ctx.Update(model);
            Save();
        }
        public void UpdateFloor(Floor model)
        {
            ctx.Update(model);
            Save();
        }
        public void UpdateCell(Cell model)
        {
            ctx.Update(model);
            Save();
        }

        public void UpdateStandardShelfSize(StandardShellSize model)
        {
            ctx.Update(model);
            Save();
        }

        public void DeleteShelf(string id)
        {
            var shelf = ctx.Shelfs.SingleOrDefault(p => p.ShelfId == id);
            ctx.Shelfs.Remove(shelf);
            Save();
        }
        public void DeleteFloor(string id)
        {
            var floor = ctx.Floors.SingleOrDefault(p => p.FloorId == id);
            ctx.Floors.Remove(floor);
            Save();
        }
        public void DeleteCell(string id)
        {
            var cell = ctx.Cells.SingleOrDefault(p => p.CellId == id);
            ctx.Cells.Remove(cell);
            Save(); 
        }
        private void Save()
        {
            ctx.SaveChanges();
        }

        public bool ShelfExists(string id)
        {
            return ctx.Shelfs.Any(p => p.ShelfId == id);
        }

        public bool FloorExists(string id)
        {
            return ctx.Floors.Any(p => p.FloorId == id);
        }
        public bool CellExists(string id)
        {
            return ctx.Cells.Any(p => p.CellId == id);
        }
        public bool StandardSizeExists(int id)
        {
            return ctx.StandardShellSizes.Any(p => p.StandardShellId == id);
        }
        public List<Cell> ShowCell(string id)
        {
            return ctx.Cells.Include(p => p.Floor).Where(p => p.CellId.Contains(id)).ToList();
        }
    }
}
