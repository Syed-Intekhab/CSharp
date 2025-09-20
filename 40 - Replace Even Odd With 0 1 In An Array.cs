// Replace all even numbers in an array with 0 and all odd numbers with 1.
using System;

namespace ReplaceOddEven{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[]{1, 2, 3, 4, 5};
            int length = nums.Length;
            
            foreach(int num in nums){
                Console.Write($"{num} ");
            }
            
            for(int i = 0; i < length; i++){
                if(nums[i] % 2 == 0){
                    nums[i] = 0;
                } else {
                    nums[i] = 1;
                }
            }
            
            Console.WriteLine();
            
            foreach(int num in nums){
                Console.Write($"{num} ");
            }
        }
    }
}