using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Floor")]
    public class Floor
    {
        [Key]
        public string FloorId { get; set; }
        public string ShelfId { get; set; }
        [ForeignKey("ShelfId")]
        public Shelf Shelf { get; set; }
    }
}
