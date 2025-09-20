// Write a program to find the largest element in an array.

using System;

namespace LargestInArray{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 8, 3, 4, 5};
            int largest = nums[0];
            
            foreach(int num in nums){
                if(largest < num){
                    largest = num;
                }
            }
            
            Console.WriteLine("Largest Element Is: " + largest);
        }
    }
}