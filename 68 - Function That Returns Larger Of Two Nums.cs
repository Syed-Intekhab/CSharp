// Function that returns the larger of two numbers.
using System;
using System.Collections.Generic;

namespace ReturnLarger{
    class Program{
        static void Main(String[] args){
            Console.WriteLine(returnLarger());
        }
        
        static int returnLarger(){
            int num1 = 5, num2 = 10;
            return (num1 > num2) ? num1 : num2;
        }
    }
}