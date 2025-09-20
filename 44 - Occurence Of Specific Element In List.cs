// Count how many times a specific value occurs in a list.
using System;
using System.Collections.Generic;

namespace OccurenceOfElem{
    class Program{
        static void Main(String[] args){
            int n = 1, count = 0;
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(1);
            myList.Add(5);
            myList.Add(1);
            myList.Add(3);
            myList.Add(1);
            
            
            for(int i = 0; i < myList.Count; i++){
                if(myList[i] == n)
                    count++;
            }
            
            Console.WriteLine($"{n} : {count} times");
        }
    }
}