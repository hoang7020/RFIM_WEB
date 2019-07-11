using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("InvoiceStatus")]
    public class InvoiceStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string Status { get; set; }

    }
}
