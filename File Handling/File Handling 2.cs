using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Handling_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "fileHandling1.txt";

            // Write Data Into File If Exists Or Create New File Then Write.
            //if(!File.Exists(filePath))
            //{
            //    using (StreamWriter sw = new StreamWriter(filePath))
            //    {
            //        sw.WriteLine("Name: John Doe");
            //        sw.WriteLine("Age: 18");
            //        sw.WriteLine("Email: john@example.com");
            //    }

            //    Console.WriteLine("Data Written Successfully!");
            //}
            //else
            //{
            //    Console.WriteLine("No Need To Create A New File! File Exists...");
            //}

            //Console.WriteLine();

            //// Read Data And Print To Console.
            //if (File.Exists(filePath))
            //{
            //    using (StreamReader sr = new StreamReader(filePath))
            //    {
            //        string content = sr.ReadToEnd();
            //        Console.WriteLine(content);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File Not Found!");
            //}

            //Console.WriteLine();

            //// Append Data To File If Exists.
            ////if (File.Exists(filePath))
            ////{
            ////    using (StreamWriter sw = new StreamWriter(filePath, true))
            ////    {
            ////        sw.WriteLine("Skills: Coding, Reading, Learning");
            ////    }

            ////    Console.WriteLine("Data Appended Successfully!");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("File Not Found!");
            ////}

            //Console.WriteLine();

            //// Print File Data To Console With Specific Skill Index.
            //if (File.Exists(filePath))
            //{
            //    using (StreamReader sr = new StreamReader(filePath))
            //    {
            //        string content = sr.ReadToEnd();
            //        Console.WriteLine(content);

            //        Console.WriteLine();
            //        if (content.Contains("Coding")) ;
            //        {
            //            Console.WriteLine(content.IndexOf("Coding"));
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File Not Found!");
            //}
            
            //Delete File If Exists.
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("File Not Found!");
            }

        }
    }
}
