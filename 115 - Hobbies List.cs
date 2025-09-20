// Create a list of 3 favorite hobbies and display them.
using System;
using System.Collections.Generic;

namespace MyHobbies{
    class Program{
        static void Main(String[] args){
            List<string> hobbies = new List<string>();
            
            hobbies.Add("Coding");
            hobbies.Add("Reading");
            hobbies.Add("Learning");
            
            foreach(string hobby in hobbies){
                Console.WriteLine(hobby);
            }
        }
    }
}