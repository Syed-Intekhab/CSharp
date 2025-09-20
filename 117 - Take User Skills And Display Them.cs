// Ask the user how many skills they have then take skill names as input and display them.
using System;
using System.Collections.Generic;

namespace UserSkills{
    class Program{
        static void Main(String[] args){
            string[] skills;
            
            Console.Write("Enter the number of skills you have: ");
            int.TryParse(Console.ReadLine(), out int n);
            
            skills = new string[n];
            
            for(int i = 0; i < n; i++){
                Console.Write("Enter your skill: ");
                skills[i] = Console.ReadLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Your skills: ");
            foreach(string skill in skills){
                Console.WriteLine(skill);
            }
        }
    }
}