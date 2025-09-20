// Append Data To A File.
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
            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }

            // Append data to a file
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Skills: Coding, Reading, Writing.");
            }
            Console.WriteLine("Data Appended Successfully!");
        }
    }
}