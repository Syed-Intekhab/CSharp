using System;

namespace OddEvenChecker{
    class Program{
        static void Main(String[] args){
            bool success = false;
            int num = 0;
            
            while(!success){
                Console.Write("Enter any number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            if(num % 2 == 0) { Console.WriteLine("Even"); }
            else { Console.WriteLine("Odd"); }
        }
    }
}