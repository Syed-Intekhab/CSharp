using System;

namespace FindSquare{
    class Program{
        static void Main(String[] args){
            bool success = false;
            int num = 0;
    
            while(!success){
                Console.Write("Enter any number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            int square = num * num;
            int cube = num * num * num;
            
            Console.WriteLine("Cube of given number is: " + cube);
            Console.WriteLine("Square of given number is: " + square);
        }
    }
}