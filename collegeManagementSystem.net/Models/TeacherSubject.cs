using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace collegeManagementSystem.net.Models
{
    public class TeacherSubject
    {
        public int Id { get; set; } 
        public int? StandardId { get; set; }  
        [ForeignKey("StandardId")]
        public virtual Standard Standard { get; set; }
        public int? SubjectctId { get; set; }   
        [ForeignKey ("SubjectId")]
        public virtual Subject Subject { get; set; }    

        public int? TeacherId { get; set; }
        [ForeignKey ("TeacherId")]
        public virtual Teacher Teacher { get; set;}
    }
}