// Write a program to find the sum of elements in an array.

using System;

namespace SumOfArray{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5};
            int sum = 0;
            
            foreach(int num in nums){
                sum += num;
            }
            
            Console.WriteLine("Sum of array elements is: " + sum);
        }
    }
}