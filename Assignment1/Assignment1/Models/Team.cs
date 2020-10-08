using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "You must provide your team name"), Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date), Display(Name = "Establish Date")]
        public DateTime? EstablishDate { get; set; }
    }
}
