using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O09CTQ_PreWrite.Implementation
{
    public class Comparer
    {
        public class DescendingComparer : IComparer<Book>
        {
            public int Compare(Book a, Book b)
            {
                var status = (a.Quantity > b.Quantity) ? -1 : ((a.Quantity == b.Quantity) ? 0 : 1);
                return status;
            }
        }
    }
}
