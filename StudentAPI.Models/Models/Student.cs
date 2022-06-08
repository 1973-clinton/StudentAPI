using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Models.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "FirstName cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "FirstName cannot exceed 50 characters")]
        public string LastName { get; set;}

        [EmailAddress(ErrorMessage ="Incorrect email format")]
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.Now;

        [NotMapped]
        public DateTime DateLeft { get; set; }

    }
}
