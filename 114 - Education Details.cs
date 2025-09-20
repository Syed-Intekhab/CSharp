// Store education details in variables and print them with labels (eg. Degree BCA).
using System;
using System.Collections.Generic;

namespace EducationDetails{
    class Program{
        static void Main(String[] args){
            Console.Write("Enter your college name: ");
            string college = Console.ReadLine();
            
            Console.Write("Enter your degree: ");
            string degree = Console.ReadLine();
            
            Console.Write("Enter your percentage: ");
            string percentage = Console.ReadLine();
            
            Console.WriteLine("College: " + college);
            Console.WriteLine("Degree: " + degree);
            Console.WriteLine("Percentage: " + percentage + "%");
        }
    }
}