using System;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            // Text Color.
            Console.ForegroundColor = ConsoleColor.Black;
            
            // Background Color (Console/Terminal Color).
            Console.BackgroundColor = ConsoleColor.White;
            
            // Clear Console/Terminal
            Console.Clear();
            
            Console.WriteLine("Hello World!");
        }
    }
}