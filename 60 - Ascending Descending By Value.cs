// Sort by Value – Sort a dictionary by its values (ascending or descending) and display the results.
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortByValue{
    class Program{
        static void Main(String[] args){
            Dictionary<string, int> fruits = new Dictionary<string, int>(){
                { "apple", 5 },
                { "banana", 2 },
                { "orange", 8 },
                { "grape", 1 }
            };
            
            // Sort By Value Ascendingvar
            var ascending = fruits.OrderBy(pair => pair.Value);
            
            Console.WriteLine("Ascending Order By Value: ");
            foreach(var pair in ascending)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
                
            // Sort By Value Descending
            var descending = fruits.OrderByDescending(pair => pair.Value);
            
            Console.WriteLine("\nDescending Order By Value: ");
            foreach(var pair in descending)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}