using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("StocktakeStatus")]
    public class StocktakeStatus
    {
        [Key]
        public int StocktakeStatusId { get; set; }
        public string StocktakeStatusName { get; set; }
    }
}
