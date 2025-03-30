using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBooksChatGPT.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public Author()
        {
            Books = new List<Book>();
        }
    }
}