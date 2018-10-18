using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter yout email adress")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter a valid email adress")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter yout phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify wheter you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
