using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Vendor")]
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Text, ErrorMessage = "Input is not valid !!")]
        public string VendorName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
