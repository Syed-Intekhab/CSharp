// Function that takes a string and returns the number of vowels.
using System;
using System.Collections.Generic;

namespace ReturnVowels{
    class Program{
        static void Main(String[] args){
            Console.Write("Enter something: ");
            string txt = Console.ReadLine();
            
            Console.WriteLine("\nVowels in given string: " + countVowels(txt));
        }
        
        static int countVowels(string text){
            int count = 0;
            text = text.ToLower();
            
            for(int i = 0; i < text.Length; i++){
                if(text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u'){
                    count++;
                }
            }
            
            return count;
        }
    }
}