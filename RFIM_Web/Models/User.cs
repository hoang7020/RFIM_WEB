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
        [MaxLength(50)]
        public string Fullname { get; set; }
        [MaxLength(32)]
        public string Username { get; set; }
        [MaxLength(32)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
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
