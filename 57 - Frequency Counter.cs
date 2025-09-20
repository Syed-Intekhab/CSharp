// Frequency Counter – Count the frequency of each word in a sentence using a dictionary.
using System;
using System.Collections.Generic;

namespace FrequencyCounter{
    class Program{
        static void Main(String[] args){
            Console.Write("Type Something: ");
            string sentence = Console.ReadLine();
            
            sentence = sentence.ToLower();
            
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Dictionary<string, int> frequency = new Dictionary<string, int>();
            
            foreach(string word in words){
                if(frequency.ContainsKey(word))
                    frequency[word]++;
                else
                    frequency[word] = 1;
            }
            
            Console.WriteLine("\nWord Frequency: ");
            foreach(KeyValuePair<string, int> pair in frequency){
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}