using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace collegeManagementSystem.net.Models
{
    public class Student
    {
        public int StudentId { get; set; } 
        [Required]
        [Display(Name ="Student Name")]
        public string Name { get; set;}
        [Required]
        [Display (Name ="Date Of Birth")]
        public string DOB { get; set; } 
        [Required,Display(Name ="Student Gender")]
        public string Gender { get; set; }

        [Required, Display(Name = "Student Mobile")]

        public string Mobile { get; set; }
        [Required, Display(Name = "Roll Number")]


        public string Rollno { get; set; }
        [Required, Display(Name = "Student Address")]

        public string Address { get; set; }
        [Required, Display(Name = "Email Address")]

        [EmailAddress ]
        public string Email { get; set; }   
        public int? StandardId { get; set; }   
        [ForeignKey("StandardId")]
        public virtual Standard Standard { get; set; }


    }
}