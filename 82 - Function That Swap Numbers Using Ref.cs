// Function that swaps two numbers using ref.
using System;
using System.Collections.Generic;

namespace SwapNumbers{
    class Program{
        static void Main(String[] args){
            int num1 = 5, num2 = 10;
            
            swapNums(ref num1, ref num2);
            
            Console.WriteLine($"Num 1: {num1}");
            Console.WriteLine($"Num 2: {num2}");
        }
        
        static void swapNums(ref int num1, ref int num2){
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}