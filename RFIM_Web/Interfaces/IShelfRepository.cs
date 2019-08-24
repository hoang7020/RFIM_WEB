using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface IShelfRepository
    {
        List<Shelf> GetAllShelf();
        Shelf GetShelf(string id);
        Shelf FindShelf(string id);
        Floor FindFloor(string id);
        Cell FindCell(string id);
        StandardShelfSize FindStandardShelfSize(int? id);
        List<Cell> GetAllCellById(string id);
        StandardShelfSize GetStandardShellSize(int? id);
        int PackageCountById(string id);
        int CellCount(string id);
        int FloorCount(string id);
        void AddShelf(Shelf model);
        void AddFloor(Floor model);
        void AddCell(Cell model);
        void UpdateShelf(Shelf model);
        void UpdateFloor(Floor model);
        void UpdateCell(Cell model);
        void UpdateStandardShelfSize(StandardShelfSize model);
        void DeleteShelf(string id);
        void DeleteFloor(string id);
        void DeleteCell(string id);
        void DeactiveShelf(Shelf model);
        void DeactiveFloor(Floor model);
        void DeactiveCell(Cell model);
        void ActiveShelf(Shelf model);
        void ActiveFloor(Floor model);
        void ActiveCell(Cell model);
        bool ShelfExists(string id);
        bool FloorExists(string id);
        bool CellExists(string id);
        bool StandardSizeExists(int id);
        List<Cell> ShowCell(string id);
        bool PackageInCell(string id);
        Package PackageRFIDInCell(string id);

        bool DuplicateCoorX(int? id);
        bool DuplicateCoorY(int? id);
        bool DuplicateCoorXExceptId(string id, int? coorX);
        bool DuplicateCoorYExceptId(string id, int? coorY);
    };
}
