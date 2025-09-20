// Create a list and insert elements dynamically from user input.
using System;
using System.Collections.Generic;

namespace ListInsertion{
    class Program{
        static void Main(String[] args){
            int n = 5;
            List<int> myList = new List<int>(n);
            
            for(int i = 0; i < n; i++){
                bool success = false;
                int num = 0;
                
                while(!success){
                    Console.Write("Enter any number: ");
                    success = int.TryParse(Console.ReadLine(), out num);
                }
                
                myList.Add(num);
            }
            
            foreach(int num in myList){
                Console.WriteLine(num);
            }
        }
    }
}