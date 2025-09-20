// Function that returns both quotient and remainder using out parameters.
using System;
using System.Collections.Generic;

namespace ReturnTwoValues{
    class Program{
        static void Main(String[] args){
            int num = 4, d = 2;
            
            int remainder = returnRemainder(num, d, out int quotient);
            
            Console.WriteLine(num);
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }
        
        static int returnRemainder(int n, int d, out int quotient){
            quotient = n / d;
            return n % d;
        }
    }
}