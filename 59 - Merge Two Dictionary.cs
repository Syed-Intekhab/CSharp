// Merge Dictionaries – Merge two dictionaries. If a key exists in both, sum their values.
using System;
using System.Collections.Generic;

namespace MergeDictionary{
    class Program{
        static void Main(String[] args){
            Dictionary<string, int> fruits1 = new Dictionary<string, int>(){
                {"apple", 2},
                {"banana", 3},
                {"orange", 1}
            };
            
            Dictionary<string, int> fruits2 = new Dictionary<string, int>(){
                {"banana", 5},
                {"orange", 4},
                {"grape", 6}
            };
            
            Dictionary<string, int> merged = new Dictionary<string, int>(fruits1);
            
            foreach(KeyValuePair<string, int> pair in fruits2){
                if(merged.ContainsKey(pair.Key))
                    merged[pair.Key] += pair.Value;
                else
                    merged[pair.Key] = pair.Value;
            }
            
            // Print merged dictionary
            Console.WriteLine("Merged Dictionary:");
            foreach (var pair in merged)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}