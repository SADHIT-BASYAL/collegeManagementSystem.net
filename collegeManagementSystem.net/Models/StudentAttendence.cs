using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace collegeManagementSystem.net.Models
{
    public class StudentAttendence
    {
        public int Id { get; set; } 
        public int? StandardId { get; set; }    
        [ForeignKey("StandardId")]
        public virtual Student Student { get; set; }
        public int? SubjectId { get; set; }
        [ForeignKey("SubjectId")]

        public virtual Subject Subject { get; set; }
        public 
    }
}