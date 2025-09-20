// Function that displays today’s date and time.
using System;
using System.Collections.Generic;

namespace DisplayDateTime{
    class Program{
        static void Main(String[] args){
            printDateTime();
        }
        
        static void printDateTime(){
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
    }
}