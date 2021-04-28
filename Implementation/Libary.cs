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
        [XmlRoot("collection")]
        public class BookCollection
        {
            [XmlArray("libary")]

            [XmlArrayItem("book", typeof(Book))]
            public Book[] Book { get; set; }
        }
    }
}
