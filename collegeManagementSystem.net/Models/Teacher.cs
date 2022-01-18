using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace collegeManagementSystem.net.Models
{
    public class Teacher
    {
        public int TeachertId { get; set; }
        [Required]
        [Display(Name = "Teacher Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        public string DOB { get; set; }
        [Required, Display(Name = "Teacher Gender")]
        public string Gender { get; set; }

        [Required, Display(Name = "Mobile Mobile")]

        public string Mobile { get; set; }
        
        [Required, Display(Name = "Email Address")]

        [EmailAddress]
        public string Email { get; set; }
        [Required, Display(Name = "Teacher Address")]
        public string Address { get; set; }
    }
}