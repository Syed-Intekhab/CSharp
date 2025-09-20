// Function that returns true if a number is even, false otherwise.
using System;
using System.Collections.Generic;

namespace ReturnBool{
    class Program{
        static void Main(String[] args){
            Console.WriteLine(returnBool());
        }
        
        static bool returnBool(){
            return 24 % 2 == 0 ? true : false;
        }
    }
}