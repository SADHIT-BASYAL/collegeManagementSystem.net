using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace collegeManagementSystem.net.Models
{
    public class TeacherAttendence
    {
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual TeacherAttendence Teacher { get; set; }
        [Required]
        public bool Status { get; set; }    
        public DateTime Date { get; set; }
    }
}