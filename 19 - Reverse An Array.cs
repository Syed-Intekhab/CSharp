// Write a program to reverse an array.
using System;

namespace ReverseArray{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5};
            
            Array.Reverse(nums);
            
            foreach(int num in nums){
                Console.Write(num + " ");
            }
        }
    }
}