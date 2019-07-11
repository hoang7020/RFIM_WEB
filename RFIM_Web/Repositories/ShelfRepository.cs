using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Repositories
{
    public class ShelfRepository : IShelf
    {
        protected readonly MyDbContext ctx;
        public ShelfRepository(MyDbContext db)
        {
            ctx = db;
        }
        public async Task<List<Shelf>> GetAllShelf()
        {
            return await ctx.Shelfs.ToListAsync();
        }

        public async Task<Shelf> GetShelf(string id)
        {
            return await ctx.Shelfs.FirstOrDefaultAsync(p => p.ShelfId == id);
        }
        public async Task<Shelf> FindShelf(string id)
        {
            return await ctx.Shelfs.FindAsync(id);
        }
        public async Task<Cell> FindCell(string id)
        {
            return await ctx.Cells.FindAsync(id);
        }
        public async Task<StandardShellSize> FindStandardShelfSize(int? id)
        {
            return await ctx.StandardShellSizes.FindAsync(id);
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
        public async Task AddShelf(Shelf model)
        {
            ctx.Add(model);
            await Save();
        }

        public async Task AddFloor(Floor model)
        {
            ctx.Add(model);
            await Save();
        }

        public async Task AddCell(Cell model)
        {
            ctx.Add(model);
            await Save();
        }

        public async Task UpdateShelf(Shelf model)
        {
            ctx.Update(model);
            await Save();
        }

        public async Task UpdateStandardShelfSize(StandardShellSize model)
        {
            ctx.Update(model);
            await Save();
        }

        public async Task DeleteShelf(string id)
        {
            var shelf = await ctx.Shelfs.SingleOrDefaultAsync(p => p.ShelfId == id);
            ctx.Shelfs.Remove(shelf);
            await Save();
        }
        public async Task DeleteFloor(string id)
        {
            var floor = await ctx.Floors.SingleOrDefaultAsync(p => p.FloorId == id);
            ctx.Floors.Remove(floor);
            await Save();
        }
        public async Task DeleteCell(string id)
        {
            var cell = await ctx.Cells.SingleOrDefaultAsync(p => p.CellId == id);
            ctx.Cells.Remove(cell);
            await Save();
        }
        private async Task Save()
        {
            await ctx.SaveChangesAsync();
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
        public async Task<List<Cell>> ShowCell(string id)
        {
            return await ctx.Cells.Include(p => p.Floor).Where(p => p.CellId.Contains(id)).ToListAsync();
        }
    }
}
