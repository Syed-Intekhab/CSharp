// Reverse a list without using Reverse() method.
using System;
using System.Collections.Generic;

namespace ReverseList{
    class Program{
        static void Main(String[] args){
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);

            int length = myList.Count;
            List<int> myList2 = new List<int>(length);
            
            foreach(int num in myList){
                Console.Write($"{num} ");
            }
            
            for(int i = length - 1; i >= 0; i--){
                myList2.Add(myList[i]);
            }
            Console.WriteLine();
            
            foreach(int num in myList2){
                Console.Write($"{num} ");
            }
        }
    }
}