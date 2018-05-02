using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp23;

namespace ConsoleApp23Test
{
    [TestClass]
    public class TestBook
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange 

            Book book = new Book("Дубровский", "Пушкин", 1812,"SGU");
            bool expected = true;
            //act 
            string temp = "Book";
            bool actual = book.IsEdition(temp);

            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
