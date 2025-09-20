// Remove a Key – Store a dictionary of product IDs and product names, then remove a specific product by its ID.
using System;
using System.Collections.Generic;

namespace RemoveKey{
    class Program{
        static void Main(String[] args){
            Dictionary<int, string> products = new Dictionary<int, string>(){
                {101, "RAM"},
                {102, "ROM"},
                {103, "Keyboard"},
                {104, "Mouse"},
                {105, "Monitor"}
            };
            int remove = 105;
            
            products.Remove(remove);
            
            foreach(KeyValuePair<int, string> pair in products){
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}