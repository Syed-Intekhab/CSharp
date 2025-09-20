// Function that calculates power of a number with exponent defaulting to 2.
using System;
using System.Collections.Generic;

namespace CalculatePower{
    class Program{
        static void Main(String[] args){
            calculatePow(2, 4);
            calculatePow(3);
            calculatePow(2);
        }
        
        static void calculatePow(int b, int exp = 2){
            Console.WriteLine(Math.Pow(b, exp));
        }
    }
}