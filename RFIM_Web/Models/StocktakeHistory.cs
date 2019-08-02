using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("StocktakeHistory")]
    public class StocktakeHistory
    {
        [Key]
        public int StocktakeHistoryId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string LostBox { get; set; }
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int StocktakeStatusId { get; set; }
        [ForeignKey("StocktakeStatusId")]
        public StocktakeStatus StocktakeStatus { get; set; }
    }
}
