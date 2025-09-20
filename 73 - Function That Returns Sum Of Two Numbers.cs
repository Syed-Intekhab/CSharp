// Function that takes two numbers and prints their sum.
using System;
using System.Collections.Generic;

namespace PrintSum{
    class Program{
        static void Main(String[] args){
            Console.WriteLine($"Sum of 5 and 10 is: {returnSum(5, 10)}");
        }
        
        static int returnSum(int num1, int num2){
            return num1 + num2;
        }
    }
}