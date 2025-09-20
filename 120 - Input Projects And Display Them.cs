// Loop to ask for 3 projects names and display them.
using System;
using System.Collections.Generic;

namespace Projects{
    class Program{
        static void Main(String[] args){
            string[] projects = new string[3];
            
            for(int i = 0; i < projects.Length; i++){
                Console.Write("Enter project name: ");
                projects[i] = Console.ReadLine();
            }
            
            Console.WriteLine();
            
            foreach(string project in projects){
                Console.WriteLine(project);
            }
        }
    }
}