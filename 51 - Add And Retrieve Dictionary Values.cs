// Add and Retrieve Values – Create a dictionary of country names and their capitals, then retrieve and display the capital of a given country.
using System;
using System.Collections.Generic;

namespace AddRetrieveValues{
    class Program{
        static void Main(String[] args){
            Dictionary<string, string> countries = new Dictionary<string, string>(){
                {"India", "Delhi"},
                {"Russia", "Moscow"},
                {"Canada", "Ottawa"},
                {"China", "Beijing"},
                {"United States", "Washington, D.C"}
            };
            
            // countries.Add("India", "Delhi");
            // countries.Add("Russia", "Moscow");
            // countries.Add("Canada", "Ottawa");
            // countries.Add("China", "Beijing");
            // countries.Add("United States", "Washington, D.C");
            
            foreach(KeyValuePair<string, string> pair in countries)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}