using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD

=======
>>>>>>> dev_thinh3
namespace RFIM_Web.Models
{
    [Table("StocktakeHistory")]
    public class StocktakeHistory
    {
        [Key]
        public int StocktakeHistoryId { get; set; }
<<<<<<< HEAD
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

=======
        [Required(ErrorMessage = "This field is required")]
        public int Quantity { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
>>>>>>> dev_thinh3
    }
}
