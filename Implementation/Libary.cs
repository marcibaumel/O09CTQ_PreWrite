using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace O09CTQ_PreWrite.Implementation
{
    public class Libary 
    {
        [Serializable()]
        public class Book
        {
            [XmlElement("title")]
            public string Title { get; set; }

            [XmlElement("author")]
            public string Author { get; set; }

            [XmlElement("quantity")]
            public int Quantity { get; set; }
        }

        public class DescendingComparer : IComparer<Book>
        {
            public int Compare(Book a, Book b)
            {
                var status = (a.Quantity > b.Quantity) ? -1 : ((a.Quantity == b.Quantity) ? 0 : 1);
                return status;
            }
        }

        [Serializable()]
        [XmlRoot("collection")]
        public class BookCollection
        {
            [XmlArray("libary")]

            [XmlArrayItem("book", typeof(Book))]
            public Book[] Book { get; set; }
        }
    }
}
