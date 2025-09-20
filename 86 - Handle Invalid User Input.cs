// Function that reads a number from the user and handles invalid input.
using System;
using System.Collections.Generic;

namespace HandleInvalidInput{
    class Program{
        static void Main(String[] args){
            int num = 0;
            bool success = false;
            
            while(!success){
                try{
                    Console.Write("Enter any number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    success = true;
                } catch(Exception e){
                    Console.WriteLine($"{e.Message}\n");
                }
            }
            
            Console.WriteLine($"You have entered: {num}");
        }
    }
}