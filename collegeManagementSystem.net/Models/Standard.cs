using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace collegeManagementSystem.net.Models
{
    public class Standard
    {
        public int StandardId { get; set; } 
        [Required]
        [Display(Name ="Standard")]
        public string StandardName { get; set; }
    }
}