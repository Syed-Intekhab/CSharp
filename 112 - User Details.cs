// Take name, age and location as input from the user and print them in a formatted way.
using System;
using System.Collections.Generic;

namespace UserDetails{
    class Program{
        static void Main(String[] args){
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out int age);
            
            Console.Write("Enter your location: ");
            string location = Console.ReadLine();
            
            Console.WriteLine($"Your name is {name}.");
            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine($"You live in {location}");
        }
    }
}