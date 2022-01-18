using System.ComponentModel.DataAnnotations;

namespace collegeManagementSystem.net.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }  
        public int? StandardId { get; set; }  
        [Required]
        [Display(Name ="StandardId")]

        public virtual Standard Standard { get; set; }
        [Required]
        [Display (Name ="Subject Name")]
        public string SubjectName { get; set; } 

    }
}