// Function that finds min and max in an array using out.
using System;
using System.Collections.Generic;

namespace FindInArray{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            
            int min = returnMin(nums, out int max);
            
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
        
        static int returnMin(int[] nums, out int max){
            int min = nums[0];
            max = nums[0];
            
            foreach(int num in nums){
                if(num < min)
                    min = num;
                
                if(num > max)
                    max = num;
            }
            
            return min;
        }
    }
}