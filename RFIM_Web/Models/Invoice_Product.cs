using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Invoice_Product")]
    public class Invoice_Product
    {

        [Key, Column(Order = 0)]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Text, ErrorMessage = "Input is not valid !!")]
        public string InvoiceId { get; set; }
        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }

        [Key, Column(Order = 1)]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Text, ErrorMessage = "Input is not valid !!")]
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Quantity { get; set; }
        public int ProcessQuantity { get; set; }
    }
}
