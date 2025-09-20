// Merge two lists into a single list without duplicates.
using System;
using System.Collections.Generic;

namespace MergeList{
    class Program{
        static void Main(String[] args){
            // Declare Lists
            List<int> myList1 = new List<int>();
            List<int> myList2 = new List<int>();
            List<int> mergedList = new List<int>();
            int elements = 5;
            
            // Get List 1
            Console.WriteLine("List 1: ");
            for(int i = 0; i < elements; i++){
                bool success = false;
                int num = 0;
                
                while(!success){
                    Console.Write("Enter any number: ");
                    success = int.TryParse(Console.ReadLine(), out num);
                }
                
                myList1.Add(num);
            }
            
            // Get List 2
            Console.WriteLine();
            Console.WriteLine("List 2: ");
            for(int i = 0; i < elements; i++){
                bool success = false;
                int num = 0;
                
                while(!success){
                    Console.Write("Enter any number: ");
                    success = int.TryParse(Console.ReadLine(), out num);
                }
                
                myList2.Add(num);
            }
            
            // Merge List 1 into new list
            for(int i = 0; i < elements; i++){
                if(!mergedList.Contains(myList1[i]))
                    mergedList.Add(myList1[i]);
            }
            for(int i = 0; i < elements; i++){
                if(!mergedList.Contains(myList2[i]))
                    mergedList.Add(myList2[i]);
            }
            
            // Display Merged List
            Console.WriteLine();
            Console.WriteLine("Merged List: ");
            foreach(int num in mergedList){
                Console.Write($"{num} ");
            }
        }
    }
}