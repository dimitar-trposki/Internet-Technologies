using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCKolokviumskaChatGPT.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Teacher()
        {
            Courses = new List<Course>();
        }
    }
}