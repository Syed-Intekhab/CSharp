// Function that takes a name and prints "Hello, {name}".
using System;
using System.Collections.Generic;

namespace PrintMessage{
    class Program{
        static void Main(String[] args){
            displayMessage("John");
        }
        
        static void displayMessage(string name){
            Console.WriteLine($"Hello {name}");
        }
    }
}