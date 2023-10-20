using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.datalayer.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Pflichtfeld")]
        [MaxLength(30,ErrorMessage ="nicht mehr als {0} Char")]
        [Display(Name ="Benotzer Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Pflichtfeld")]
        [MaxLength(50, ErrorMessage = "nicht mehr als {0} Char")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pflichtfeld")]
        [MaxLength(50, ErrorMessage = "nicht mehr als {0} Char")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Pflichtfeld")]
        public bool IsActived { get; set; }

        [Required(ErrorMessage = "Pflichtfeld")]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Pflichtfeld")]
        public int RoleId { get; set; }

        public Role role { get; set; }
    }
}
