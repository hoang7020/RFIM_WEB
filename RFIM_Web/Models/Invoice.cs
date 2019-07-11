using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public string InvoiceId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public InvoiceStatus InvoiceStatus { get; set; }

        public int InvoiceTypeId { get; set; }
        [ForeignKey("InvoiceTypeId")]
        public InvoiceType InvoiceType { get; set; }


    }
}
