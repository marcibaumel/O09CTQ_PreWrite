using NUnit.Framework;
using O09CTQ_PreWrite.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O09CTQ_PreWrite.UTest
{
    [TestFixture]
    public class BookTest
    {
        [TestCase(1, 2, 7, 4)]
        public void OperatorTest(int a, int b, int c, int d)
        {
            Book testBook1 = new Book();
            Book testBook2 = new Book();

            testBook1.Quantity = a;
            testBook2.Quantity = b;

            Assert.IsTrue((testBook1 + testBook2).Quantity.Equals(b));

            testBook1.Quantity = c;
            testBook2.Quantity = d;

            Assert.IsTrue((testBook1 + testBook2).Quantity.Equals(c));
        }
    }
}
