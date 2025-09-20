// Swap Keys and Values – Given a dictionary of {1: "A", 2: "B", 3: "C"}, create a new dictionary with swapped keys and values.
using System;
using System.Collections.Generic;

namespace SwapKeyWithValue{
    class Program{
        static void Main(String[] args){
            Dictionary<int, char> grades = new Dictionary<int, char>(){
                {1, 'A'},
                {2, 'B'},
                {3, 'C'}
            };
            Dictionary<char, int> swapped = new Dictionary<char, int>();
            
            // Display Dictionary Before Swapped and swapped elemennts
            foreach(KeyValuePair<int, char> pair in grades){
                Console.WriteLine($"{pair.Key} - {pair.Value}");
                swapped.Add(pair.Value, pair.Key);
            }
        
            Console.WriteLine();
            // Display After Swapped
            foreach(KeyValuePair<char, int> pair in swapped)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}