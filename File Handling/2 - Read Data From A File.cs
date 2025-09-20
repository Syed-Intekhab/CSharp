// Read Data From A File.
using System;
using System.IO;

namespace fileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "resume.txt";

            // Create File
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Name: John Doe");
                sw.WriteLine("Age: 18");
                sw.WriteLine("Email: john@example.com");
            }
            Console.WriteLine("File created and written successfully!");

            // Read from a file
            if(File.Exists(filePath)){
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            } else {
                Console.WriteLine("File Not Found!");
            }
        }
    }
}