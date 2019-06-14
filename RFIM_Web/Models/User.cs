using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(50, ErrorMessage = "Fullname must be less than 50 characters")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(32, ErrorMessage = "Fullname must be less than 32 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(32, ErrorMessage = "Fullname must be less than 32 characters")]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(50, ErrorMessage = "Fullname must be less than 50 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        [MaxLength(120)]
        public string Note { get; set; }
        public bool Status { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
