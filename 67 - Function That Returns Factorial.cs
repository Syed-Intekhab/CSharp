// Function that returns the factorial of a number.
using System;
using System.Collections.Generic;

namespace ReturnFactorial{
    class Program{
        static void Main(String[] args){
            int num = 5;
            int fact = returnFact(num);
            Console.WriteLine($"Factorial of {num} is: {fact}");
        }
        
        static int returnFact(int n){
            if(n == 1 || n == 0){
                return 1;
            }
            
            return n * returnFact(n - 1);
        }
    }
}