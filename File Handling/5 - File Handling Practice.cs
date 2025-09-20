using System;
using System.IO;

namespace fileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Practice
            string filePath = "info.txt";

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Name: John Doe");
                sw.WriteLine("Age: 18");
                sw.WriteLine("Email: john@example.com");
            }

            Console.WriteLine("File Created and Data Written Successfully!");

            if(File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File Not Found!");
            }

            Console.WriteLine();

            if (File.Exists(filePath))
            {
                using (StreamWriter sr = new StreamWriter(filePath, true))
                {
                    sr.WriteLine("Skills: Coding, Reading, Learning.");
                }
            }
            else
            {
                Console.WriteLine("File Not Found!");
            }

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File Not Found!");
            }

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