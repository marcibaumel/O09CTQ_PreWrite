using NUnit.Framework;
using O09CTQ_PreWrite.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using static O09CTQ_PreWrite.Implementation.Comparer;
using static O09CTQ_PreWrite.Implementation.Libary;

namespace O09CTQ_PreWrite.UTest
{
    [TestFixture]
    public class ComparerTest
    {

        [Test]
        public void CompareTest_ReciveTwoBooks_GiveBacksInOrder()
        {
            
            bookTest1 = new Book("", "", 2);
            bookTest2 = new Book("", "", 5);
            List<Book> listTest = new List<Book>();
            listTest.Add(bookTest1);
            listTest.Add(bookTest2);

            listTest.Sort(new DescendingComparer());    


            Assert.IsTrue(listTest.First().Equals(bookTest2));
        }

        private Book bookTest1;
        private Book bookTest2;
    }
}
