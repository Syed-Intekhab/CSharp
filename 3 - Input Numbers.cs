using System;

namespace SumOfTwoNum{
    class Program{
        static void Main(String[] args){
            bool success = true;
            
            while(success){
                Console.Write("Enter any number: ");
                bool num1Result = int.TryParse(Console.ReadLine(), out int num1);
                Console.Write("Enter any number: ");
                bool num2Result = int.TryParse(Console.ReadLine(), out int num2);
                if(num1Result && num2Result){
                    Console.WriteLine($"Sum of two number is: {num1 + num2}");
                    success = false;
                }
                Console.WriteLine();
            }
        }
    }
}