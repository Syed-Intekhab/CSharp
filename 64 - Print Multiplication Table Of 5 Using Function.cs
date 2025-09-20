// Function that prints multiplication table of 5.
using System;
using System.Collections.Generic;

namespace PrintTable{
    class Program{
        static void Main(String[] args){
            printTable();
        }
        
        static void printTable(){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"5 X {i} = {5 * i}");
            }
        }
    }
}