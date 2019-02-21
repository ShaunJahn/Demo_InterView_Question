using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace softservedigital.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter your age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter your birth date")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Please enter your salary")]
        public double Salary { get; set; }
    }
}
