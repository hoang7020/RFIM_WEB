using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Box")]
    public class Box
    {
        [Key]
        public string BoxRFID { get; set; }
        public string PackageRFID { get; set; }
        [ForeignKey("PackageRFID")]
        public Package Package { get; set; }
        public bool Status { get; set; }
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
