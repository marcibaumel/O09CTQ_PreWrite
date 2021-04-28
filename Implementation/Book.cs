using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace O09CTQ_PreWrite.Implementation
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

       public Book(string title, string author, int quantity) {
            Quantity = quantity;
            Title = title;
            Author = author;
        }

        public Book() { }

        public static Book operator +(Book a, Book b)
        {
            if (a.Quantity > b.Quantity)
            {
                return new Book(a.Title, a.Author, a.Quantity);
            }
            else { return new Book(b.Title, b.Author, b.Quantity); }
        }





    }
}

