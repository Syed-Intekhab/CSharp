// Find the largest and smallest elements in a list.
using System;
using System.Collections.Generic;

namespace FindLargest{
    class Program{
        static void Main(String[] args){
            List<int> myList = new List<int>();
            myList.Add(5);
            myList.Add(4);
            myList.Add(6);
            myList.Add(7);
            myList.Add(3);
            myList.Add(12);
            
            int largest = myList[0];
            int smallest = myList[0];
            
            for(int i = 1; i < myList.Count; i++){
                if(myList[i] > largest){
                    largest = myList[i];
                }
                
                if(myList[i] < smallest){
                    smallest = myList[i];
                }
            }
            
            Console.WriteLine($"Largest Element is: {largest}");
            Console.WriteLine($"Smallest Element is: {smallest}");
        }
    }
}