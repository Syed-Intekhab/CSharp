// Check Key Exists – Write a program that checks if a given key exists in a dictionary before retrieving it.
using System;
using System.Collections.Generic;

namespace CheckForKey{
    class Program{
        static void Main(String[] args){
            Dictionary<int, string> people = new Dictionary<int, string>(){
                {1, "John"},
                {2, "Jane"}
            };
            people.Add(3, "James");
            
            int num = 0;
            bool success = false;
            
            while(!success){
                Console.Write("Enter a key to search: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            if(people.TryGetValue(num, out string name))
                Console.WriteLine(name);
            else
                Console.WriteLine("Key Not Found!");
        }
    }
}