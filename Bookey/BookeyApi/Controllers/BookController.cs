using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bookey.Models;




namespace Bookey.Controllers
{
	/// <summary>
	/// Search for books
	/// </summary>
	public class BookController : ApiController
    {

			

		Book[] books = new Book[] {
        new Book {Id=1, Name="Alice in Wonderland", Author="Lewis Caroll", IsAvailable=true },
        new Book {Id=2, Name="Harry Potter", Author="J K Rowling", IsAvailable=false },
        new Book {Id=3, Name="4 Hour work week ", Author="Tim Ferris", IsAvailable=false }
        };

		/// <summary>
		/// Find the book by using the book name
		/// </summary>
		/// <param name="Book Name"></param>
		/// <returns></returns>

        public IHttpActionResult GetBook(string bookname)
        {
           Book resultBook =  Array.Find(books, b => b.Name.Contains(bookname));
            return Ok(resultBook);
		
        }
    }
}
