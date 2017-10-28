using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bookey.Models;




namespace Bookey.Controllers
{
    public class BookController : ApiController
    {
        Book[] books = new Book[] {
        new Book {Id=1, Name="Alice in Wonderland", Author="Lewis Caroll", IsAvailable=true },
        new Book {Id=2, Name="Harry Potter", Author="J K Rowling", IsAvailable=false },
        new Book {Id=3, Name="4 Hour work week ", Author="Tim Ferris", IsAvailable=false }
        };

        public IHttpActionResult GetBook(string name)
        {
           Book resultBook =  Array.Find(books, b => b.Name.Contains(name));
            return Ok(resultBook);
		
        }
    }
}
