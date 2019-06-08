using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Shelf")]
    public class Shelf
    {
        [Key]
        public int ShelfId { get; set; }
        [MinLength(16)]
        public string ShelfCode { get; set; }
        public string Description { get; set; }
        public int FloorNumber { get; set; }
        public int CellNumber { get; set; }
    }
}
