using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCKolokviumskaChatGPT.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Course()
        {
            Students = new List<Student>();
        }
    }
}