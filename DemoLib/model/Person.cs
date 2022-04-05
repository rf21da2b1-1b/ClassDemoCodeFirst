using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.model
{
    class Person
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public String Name { get; set; }
    }
}
