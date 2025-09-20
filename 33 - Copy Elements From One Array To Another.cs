// Copy Elements from one array to another array.
using System;

namespace CopyElements{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5};
            int numsLength = nums.Length;
            
            // Declare a new array with old array length.
            int[] copyNums = new int[numsLength];
            
            // Copy elements from old array to new one.
            for(int i = 0; i < numsLength; i++){
                copyNums[i] = nums[i];
            }
            
            // Display old array
            Console.WriteLine("Old Array: ");
            foreach(int num in nums){
                Console.Write($"{num} ");
            }
            
            // Display new array.
            Console.WriteLine("\n\nNew Array: ");
            foreach(int num in copyNums){
                Console.Write($"{num} ");
            }
            
        }
    }
}