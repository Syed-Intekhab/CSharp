// Store skills in an array and print them one by one.
using System;
using System.Collections.Generic;

namespace Skills{
    class Program{
        static void Main(String[] args){
            string[] skills = new string[3];
            
            for(int i = 0; i < skills.Length; i++){
                Console.Write("Enter your skill: ");
                skills[i] = Console.ReadLine();
            }
            
            Console.WriteLine();
            
            foreach(string skill in skills){
                Console.WriteLine(skill);
            }
        }
    }
}