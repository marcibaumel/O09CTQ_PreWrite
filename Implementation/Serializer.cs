using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static O09CTQ_PreWrite.Implementation.Libary;

namespace O09CTQ_PreWrite.Implementation
{
    public class Serializer 
    {
      public BookCollection serializeredXml()
      {
            BookCollection books = null;
            string path = @"Data/Libary.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(BookCollection));

            StreamReader reader = new StreamReader(path);
            books = (BookCollection)serializer.Deserialize(reader);
            reader.Close();

            return books;
        }
    }
}
