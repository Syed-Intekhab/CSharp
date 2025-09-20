// Vowels and Consonants Counter
using System;

namespace VowelsCounter{
    class Program{
        static void Main(String[] args){
            string txt = "";
            int vowels = 0, consonants = 0;
            
            // Get user input
            Console.Write("Enter any something: ");
            txt = Console.ReadLine().ToLower();
            
            // Loop through the string
            foreach(char ch in txt){
                // Check if character is vowel
                if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
            
            Console.WriteLine($"Number of vowels are {vowels}");
            Console.WriteLine($"Number of consonants are {consonants}");
        }
    }
}