// Function that takes a number and prints its multiplication table.
using System;
using System.Collections.Generic;

namespace MultiplicationTable{
    class Program{
        static void Main(String[] args){
            printTable(5);
        }
        
        static void printTable(int num){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}