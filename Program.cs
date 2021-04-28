using O09CTQ_PreWrite.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static O09CTQ_PreWrite.Implementation.Comparer;
using static O09CTQ_PreWrite.Implementation.Libary;

namespace O09CTQ_PreWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Book>();
            Serializer serializer = new Serializer();
            FileManager fileManager = new FileManager();
            BookCollection books = serializer.serializeredXml();

            Console.WriteLine("Every books: \n");
            list = books.Book.ToList();     
            foreach(var i in list)
            {
                Console.WriteLine(i.Title);
            }
            Console.WriteLine();
            Console.ReadLine();

            
            Console.WriteLine("Books in descending order by quantity:\n");
            list.Sort(new DescendingComparer());
            foreach (var i in list)
            {
                Console.WriteLine(i.Title);
                fileManager = new FileManager(i.Title);              
            }
            Console.ReadLine();


            Console.WriteLine("Creating book file:\n");
            foreach (var i in list)
            {
                fileManager = new FileManager(i.Title);
                fileManager.FileGenerator(i.Author, i.Quantity);
                Console.WriteLine(i.Title + " has been created.");
            }
            Console.ReadLine();


            Console.WriteLine("Read back file data:\n");
            foreach (var i in list)
            {
                fileManager = new FileManager(i.Title);
                fileManager.FileReader();
            }
            Console.ReadLine();


            string testData = "The Hunger Games";
            Console.WriteLine($"Existing Item: {testData}");
            fileManager.ExistingItem(testData);
            Console.ReadLine();


            Console.WriteLine("Operator Overloading Test:");
            Book bookTest1 = books.Book[1];
            Book bookTest2 = books.Book[2];
            var testItem = bookTest1 + bookTest2;
            Console.WriteLine(testItem.Title);
            Console.ReadLine();

        }
    }
}
