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
        [Display(Name = "Shelf Id*")]
        [Required(ErrorMessage = "Shelf Code is required")]
        [MaxLength(16, ErrorMessage = "Shelf Code has less than 16 characters")]
        public string ShelfId { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Floor Number is required")]
        [Display(Name = "Floor Number*")]
        public int? FloorNumber { get; set; }
        [Display(Name = "Cell Number*")]
        [Required(ErrorMessage = "Cell Number is required")]
        public int? CellNumber { get; set; }
        public int CoorX { get; set; }
        public int CoorY { get; set; }
    }
}
