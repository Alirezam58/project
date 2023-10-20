using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.datalayer.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Pflichtfeld")]
        [MaxLength(20,ErrorMessage ="nicht mehr als {0} Char")]
        [Display(Name="Role")]
        public string Name { get; set; }
    }
}
