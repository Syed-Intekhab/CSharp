// Write a program to store 5 numbers in an array and display them.

using System;

namespace PrintArray{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[5] {1, 2, 3, 4, 5};
            
            foreach(int num in nums){
                Console.WriteLine(num);
            }
        }
    }
}