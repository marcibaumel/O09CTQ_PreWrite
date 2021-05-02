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

            /// <summary>
            /// First we serialized our XML to a collection 
            /// </summary>
            BookCollection books = serializer.serializeredXml();

            Console.WriteLine("Every books: \n");
            /// <summary>
            /// We make a list from our collection
            /// </summary>
            list = books.Book.ToList();     
            foreach(var i in list)
            {
                Console.WriteLine(i.Title);
            }
            Console.WriteLine();
            Console.ReadLine();

            /// <summary>
            /// With our compare class, we can make a descending order in the list by there quantity.
            /// </summary>
            Console.WriteLine("Books in descending order by quantity:\n");
            list.Sort(new DescendingComparer());
            foreach (var i in list)
            {
                Console.WriteLine(i.Title);
                fileManager = new FileManager(i.Title);              
            }
            Console.ReadLine();


            /// <summary>
            /// With our list, we make a new file.
            /// Title   -File name
            /// File Content: Author and Quantity
            /// If something happened with our data in our XML we delete the previous file and make a new file with the new data.
            /// </summary>
            Console.WriteLine("Creating book file:\n");
            foreach (var i in list)
            {
                fileManager = new FileManager(i.Title);
                fileManager.FileGenerator(i.Author, i.Quantity);
                Console.WriteLine(i.Title + " has been created.");
            }
            Console.ReadLine();

            /// <summary>
            /// We read back the data from the files.
            /// </summary>
            Console.WriteLine("Read back file data:\n");
            foreach (var i in list)
            {
                fileManager = new FileManager(i.Title);
                fileManager.FileReader();
            }
            Console.ReadLine();

            /// <summary>
            /// We check there is a file with the given name.
            /// </summary>
            string testData = "The Hunger Games";
            Console.WriteLine($"Existing Item: {testData}");
            if (fileManager.ExistingItem(testData))
            {
                Console.WriteLine("Existing!");
            }
            else
            {
                Console.WriteLine("Not Existing!");
            }
            Console.ReadLine();

            /// <summary>
            /// With this method I demonstrate my operator overloading method.
            /// Book1 + Book2 => we get a book, which has more quantity.
            /// </summary>
            Console.WriteLine("Operator Overloading:");
            Book bookTest1 = books.Book[1];
            Book bookTest2 = books.Book[2];
            var testItem = bookTest1 + bookTest2;
            Console.WriteLine(testItem.Title);
            Console.ReadLine();


            /// <summary>
            /// With this method I demonstrate I can change a file name and I can keep the old content.
            /// </summary>
            Console.WriteLine("File Name Changer: Old file name - The Hunger Games || New file name - The Hungerer Games");
            fileManager.FileNameChanger("The Hunger Games", "The Hungerer Games");
            
            testData = "The Hungerer Games";

            Console.WriteLine($"Existing Item: {testData}");
            if (fileManager.ExistingItem(testData))
            {
                Console.WriteLine("Existing!");
            }
            else
            {
                Console.WriteLine("Not Existing!");
            }
            Console.ReadLine();

            Console.WriteLine("\nPress a key to exit!");
            Console.ReadLine();

        }
    }
}
