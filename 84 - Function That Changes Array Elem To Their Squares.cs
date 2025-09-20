// Function that changes all array elements to their squares using ref.
using System;
using System.Collections.Generic;

namespace SquareArray{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            
            Console.WriteLine("Array Before Changing Values: ");
            foreach(int num in nums){
                Console.Write($"{num} ");
            }
            
            squareArrayElements(ref nums);
            
            Console.WriteLine("\n\nArray After Changing Values: ");
            foreach(int num in nums){
                Console.Write($"{num} ");
            }
        }
        
        static void squareArrayElements(ref int[] nums){
            for(int i = 0; i < nums.Length; i++){
                nums[i] *= nums[i];
            }
        }
    }
}