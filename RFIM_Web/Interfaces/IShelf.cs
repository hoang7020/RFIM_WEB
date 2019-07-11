using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface IShelf
    {
        Task<List<Shelf>> GetAllShelf();
        Task<Shelf> GetShelf(string id);
        Task<Shelf> FindShelf(string id);
        Task<Cell> FindCell(string id);
        Task<StandardShellSize> FindStandardShelfSize(int? id);
        List<Cell> GetAllCellById(string id);
        StandardShellSize GetStandardShellSize(int? id);
        int PackageCountById(string id);
        int CellCount(string id);
        int FloorCount(string id);
        Task AddShelf(Shelf model);
        Task AddFloor(Floor model);
        Task AddCell(Cell model);
        Task UpdateShelf(Shelf model);
        Task UpdateStandardShelfSize(StandardShellSize model);
        Task DeleteShelf(string id);
        Task DeleteFloor(string id);
        Task DeleteCell(string id);
        bool ShelfExists(string id);
        bool FloorExists(string id);
        bool CellExists(string id);
        bool StandardSizeExists(int id);
        Task<List<Cell>> ShowCell(string id);
    }
}
