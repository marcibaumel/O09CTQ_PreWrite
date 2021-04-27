using O09CTQ_PreWrite.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static O09CTQ_PreWrite.Implementation.Libary;

namespace O09CTQ_PreWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Book>();
            Serializer serializer = new Serializer();
            BookCollection books = serializer.serializeredXml();
            
            list = books.Book.ToList();

            
            
            foreach(var i in list)
            {
                Console.WriteLine(i.Title);
            }

            Console.WriteLine();

            list.Sort(new DescendingComparer());

            foreach (var i in list)
            {
                Console.WriteLine(i.Title);
            }

            Console.ReadLine();
        }
    }
}
