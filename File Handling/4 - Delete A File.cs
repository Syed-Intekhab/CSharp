using System;
using System.IO;

namespace fileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "resume.txt";

            // Delete a file
            if(File.Exists(filePath))
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