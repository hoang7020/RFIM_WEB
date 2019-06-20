using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Product Id")]
        public string ProductId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Product Name")]
        [MaxLength(256, ErrorMessage = "Input must less than 256 characters")]
        public string ProductName { get; set; }
        public double? Weight { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
}
