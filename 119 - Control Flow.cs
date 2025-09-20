// Ask the user for their age check if they are eligible for a job (age >= 18).
using System;
using System.Collections.Generic;

namespace ControlFlow{
    class Program{
        static void Main(String[] args){
            int age = 0;
            bool success = false;
            
            while(!success){
                Console.Write("Enter your age: ");
                success = int.TryParse(Console.ReadLine(), out age);
            }
            
            if(age >= 18)
                Console.WriteLine("Eligible!");
            else
                Console.WriteLine("Not Eligible!");
        }
    }
}