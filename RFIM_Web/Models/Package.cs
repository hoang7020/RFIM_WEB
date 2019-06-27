using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Package")]
    public class Package
    {
        [Key]
        public string PackageRFID { get; set; }
        public string Description { get; set; }
        public string CellId { get; set; }
        [ForeignKey("CellId")]
        public Cell Cell { get; set; }
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
