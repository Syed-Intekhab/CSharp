// Create a menu with options (1: Add skill, 2: view skill, 3: Exit) using a switch statment.
using System;
using System.Collections.Generic;

namespace MySkills{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Choose 1 to add skill.");
            Console.WriteLine("Choose 2 to view skill.");
            Console.WriteLine("Choose 3 to exit.");
            
            List<string> skills = new List<string>();
            int ch = 0;
            
            while(ch != 3){
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                int.TryParse(Console.ReadLine(), out ch);
                
                switch(ch){
                    case 1:
                        Console.Write("Add new skill: ");
                        skills.Add(Console.ReadLine());
                        break;
                    case 2:
                        foreach(string skill in skills){
                            Console.WriteLine(skill);
                        }
                        break;
                    case 3:
                        Console.Write("Closing...");
                        break;
                    default: Console.WriteLine("Invalid Choice...");
                        break;
                }
            }
        }
    }
}