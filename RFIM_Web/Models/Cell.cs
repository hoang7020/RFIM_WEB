using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Cell")]
    public class Cell
    {
       [Key]
        public string CellId { get; set; }
        public string CellRFID { get; set; }
        public string FloorId { get; set; }
        [ForeignKey("FloorId")]
        public Floor Floor { get; set; }
    }
}
