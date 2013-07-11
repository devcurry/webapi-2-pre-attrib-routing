using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2Preview.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
    }
}