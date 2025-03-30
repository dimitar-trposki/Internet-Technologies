using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVCKolokviumskaChatGPT.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Студентски број")]
        [RegularExpression(@"\d{6}", ErrorMessage = "The code must contain only 6 digits!")]
        public int StudentNumber { get; set; }
        public string Year { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
    }
}