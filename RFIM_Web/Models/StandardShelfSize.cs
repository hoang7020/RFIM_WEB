using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("StandardShelfSize")]
    public class StandardShelfSize
    {
        [Key]
        public int StandardShelfId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Range(1,1000000000, ErrorMessage = "Number must be more than zero")]
        public int? StandardFloor { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Range(1, 1000000000, ErrorMessage = "Number must be more than zero")]
        public int? StandardCell { get; set; }
    }
}
