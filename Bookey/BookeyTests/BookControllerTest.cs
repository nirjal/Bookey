using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bookey.Controllers;
using Bookey.Models;
using System.Web.Http.Results;

namespace BookeyTests
{
    [TestClass]
    public class BookControllerTest
    {
        
        [TestMethod]
        public void ShouldReturnBookWhenProvidedBookName()
        {

            var bookName = "Alice in Wonderland";
            var bookCtrl = new BookController();
            var result =   bookCtrl.GetBook(bookName);
			var contentResult = result as OkNegotiatedContentResult<Book>;
			Assert.AreEqual(contentResult.Content.Name, "Alice in Wonderland");
			

        }

        [TestMethod]
        public void ShouldReturnBookWhenProvidedPartialBookName()
        {

            var bookNamePartial = "Alice";
            var bookCtrl = new BookController();
			var result = bookCtrl.GetBook(bookNamePartial);
			var contentResult = result as OkNegotiatedContentResult<Book>;
			Assert.AreEqual(contentResult.Content.Name, "Alice in Wonderland");

			// bookCtrl.
		}

		[TestMethod]
        public void ShouldShowIfBookIsAvailable()
        {
			var bookNamePartial = "Alice";
			var bookCtrl = new BookController();
			var result = bookCtrl.GetBook(bookNamePartial);
			var contentResult = result as OkNegotiatedContentResult<Book>;
			Assert.AreEqual(contentResult.Content.Name, "Alice in Wonderland");

		}

        [TestMethod]
        public void ShouldRreturnErrorIfBookNotFound()
        {

        }
    }
}
