// Count Keys – Create a dictionary of fruits and prices, then display the total number of items.
using System;
using System.Collections.Generic;

namespace CountKeys{
    class Program{
        static void Main(String[] args){
            Dictionary<string, int> fruits = new Dictionary<string, int>(){
                {"Mango", 20},
                {"Banana", 30},
                {"Apple", 40},
                {"Grapes", 50}
            };
            
            Console.WriteLine(fruits.Count);
        }
    }
}