using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Preview.Models;

namespace WebApi2Preview.Controllers
{
    public class AuthorsController : ApiController
    {
        // GET api/authors
        public IEnumerable<Author> Get()
        {
            return new List<Author> { new Author { AuthorId = 1, Name = "Suprotim" }, new Author { AuthorId = 2, Name = "Sumit" } };
        }

        // GET api/authors/5
        public Author Get(int id)
        {
            if (id == 1)
            {
                return new Author { AuthorId = 1, Name = "Suprotim" };
            }
            else
            {
                return new Author { AuthorId = 2, Name = "Sumit" };
            }
        }

        [HttpGet("api/authors/{authorId}/books")]
        public IEnumerable<Book> GetAuthorBooks(int authorId)
        {
            Book newBook = null;
            if (authorId == 1)
            {
                newBook = new Book { BookId = 1, Title = "51 Recipes in jQuery" };
            }
            else
            {
                newBook = new Book { BookId = 2, Title = "Windows 8 Apps" };
            }
            return new List<Book> { newBook };
        }

        [HttpGet("api/books/{bookId}/authors")]
        public IEnumerable<Author> GetBookAuthors(int bookId)
        {            
            return new List<Author>();
        }

        // POST api/authors
        public void Post([FromBody]string value)
        {
        }

        // PUT api/authors/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/authors/5
        public void Delete(int id)
        {
        }
    }
}
