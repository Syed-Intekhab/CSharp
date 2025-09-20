using System;

namespace UserInput{
    class Program{
        static void Main(String[] args){
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Your name is: {name}");
        }
    }
}