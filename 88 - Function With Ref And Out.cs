// Function with ref and out parameters together (swap numbers and return sum).
using System;
using System.Collections.Generic;

namespace RefAndOutParam{
    class Program{
        static void Main(String[] args){
            int num1 = 5, num2 = 10;
            returnSum(ref num1, ref num2, out int sum);
            
            Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
        }
        
        static void returnSum(ref int num1, ref int num2, out int sum){
            sum = num1;
            num1 = num2;
            num2 = sum;
            
            sum = num1 + num2;
        }
    }
}