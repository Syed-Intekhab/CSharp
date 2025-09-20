// Function that prints student details (name mandatory, age optional with default 18).
using System;
using System.Collections.Generic;

namespace StudentDetails{
    class Program{
        static void Main(String[] args){
            string name = "John";
            int age = 18;
            
            printDetails(name, age);
            
            Console.WriteLine();
            
            printDetails("Jane");
        }
        
        static void printDetails(string name, int age = default){
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}