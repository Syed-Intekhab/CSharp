// Function that doubles the value of a variable using ref.
using System;
using System.Collections.Generic;

namespace DoubleValue{
    class Program{
        static void Main(String[] args){
            int num = 10;
            
            doubleNum(ref num);
            
            Console.WriteLine(num);
        }
        
        static void doubleNum(ref int num){
            num *= 2;
        }
    }
}