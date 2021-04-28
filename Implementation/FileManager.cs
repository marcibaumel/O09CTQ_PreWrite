using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O09CTQ_PreWrite.Implementation
{
    public class FileManager
    {
        private string fileName { get; set; }
        private string filePath { get; set; }
        public FileManager(string fileName)
        {
            this.fileName = fileName;
            this.filePath = @"Data/"+fileName+".txt";
        }
        public FileManager() { }
        public void FileGenerator(string Author, int Quantity)
        {
            try
            {   
                if (!FileComparer(Author, Quantity.ToString()))
                {
                    File.Delete(filePath);

                    using (FileStream fs = File.Create(filePath))
                    {
                        byte[] title = new UTF8Encoding(true).GetBytes("Authors is: " + Author + ";");
                        fs.Write(title, 0, title.Length);

                        byte[] author = new UTF8Encoding(true).GetBytes("\t Quantity: " + Quantity);
                        fs.Write(author, 0, author.Length);
                    }
                }                           
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
        public void FileReader()
        {
            try
            {  
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = " ";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s +"\t");
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

        }
        public bool FileComparer(string Author, string Quantity)
        {
            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";

                    string testAuthor = "Author is: " + Author;
                    string testQuantity = "\t Quantity: " + Quantity;

                    string authorData = "";
                    string quantityData = "";

                    while ((s = sr.ReadLine()) != null)
                    {
                        
                        string[] fullName = s.Split(';');
                        authorData = fullName[0];
                        quantityData = fullName[1];

                        if (authorData.Equals(testAuthor) || quantityData.Equals(testQuantity))
                        {
                            return true;
                        }
                    }
                }
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            return false;
        }

        public void ExistingItem(string Title)
        {
            string testFile = @"Data/" + Title + ".txt";
            Console.WriteLine(File.Exists(testFile) ? "File exists." : "File does not exist.");
        }

        
        
    }
}
