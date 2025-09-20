// Function that returns the sum of two integers.
using System;
using System.Collections.Generic;

namespace ReturnSum{
    class Program{
        static void Main(String[] args){
            int sum = returnSum();
            Console.WriteLine(sum);
        }
        
        static int returnSum(){
            return 5 + 5;
        }
    }
}