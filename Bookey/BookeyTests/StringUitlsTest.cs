using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookeyTests
{
    [TestClass]
    public class StringUitlsTest
    {
		[TestMethod]
		public void ShouldDoAStringLikeMatch() {
			var testString = "Hello World";

			var result = testString.Contains("Hello");

			Assert.IsTrue(result);

		}

		//[TestMethod]
		//public void ShouldReturnBookWhenProvidedBookName()
		//{

		//	var bookName = "Alice";
		//	var bookCtrl = new BookController();
		//	var result = bookCtrl.GetBook(bookName);

		//}


	}
}
