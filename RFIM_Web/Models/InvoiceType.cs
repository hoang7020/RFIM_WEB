using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("InvoiceType")]
    public class InvoiceType
    {
        [Key]
        public int InvoiceTypeId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Text, ErrorMessage = "Input is not valid !!")]
        public string InvoiceTypes { get; set; }

    }
}
