// Function that prints first 10 natural numbers.
using System;
using System.Collections.Generic;

namespace PrintNaturalNums{
    class Program{
        static void Main(String[] args){
            printNumbers();
        }
        
        static void printNumbers(){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i);
            }
        }
    }
}