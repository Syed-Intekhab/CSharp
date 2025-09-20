// Write a program to print the factorial of a number.

using System;

namespace CalFact{
    class Program{
        static void Main(String[] args){
            bool isSucceed = false;
            int num = 0, fact = 1;
            
            while(!isSucceed){
                Console.Write("Enter any number: ");
                isSucceed = int.TryParse(Console.ReadLine(), out num);
                Console.WriteLine();
            }
            
            for(int i = num; i >= 1; i--){
                fact *= i;
            }
            
            Console.WriteLine($"Factorial of a given number is: {fact}");
        }
    }
}