using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bookey.Controllers;
using System.Web;
using System.Web.Http;


namespace BookeyTests
{
    [TestClass]
    public class BookControllerTest
    {
        
        [TestMethod]
        public void ShouldReturnBookWhenProvidedBookName()
        {

            var bookName = "Alice";
            var bookCtrl = new BookController();
            var result =   bookCtrl.GetBook(bookName);

        }

        [TestMethod]
        public void ShouldReturnBookWhenProvidedPartialBookName()
        {

            var bookNamePartial = "Alice";
            var bookCtrl = new BookController();
           // bookCtrl.
        }

        [TestMethod]
        public void ShouldShowIfBookIsAvailable()
        {
        }

        [TestMethod]
        public void ShouldRreturnErrorIfBookNotFound()
        {

        }
    }
}
