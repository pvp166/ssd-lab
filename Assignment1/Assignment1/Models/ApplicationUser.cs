using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "You must provide your first name"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must provide your last name"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [DataType(DataType.Date), Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

    }
}
