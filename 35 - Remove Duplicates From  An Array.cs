// Remove all duplicate elements from an array.
using System;

namespace RemoveDuplicates{
    class Program{
        static void Main(String[] args){
            // Initialize an array.
            int[] nums = new int[] {1, 2, 3, 3, 2, 5, 4, 5, 2, 1, 4};
            int length = nums.Length;
            
            for (int i = 0; i < length; i++){
                for (int j = i + 1; j < length; j++){
                    if (nums[i] == nums[j]){
                        // Shift elements left
                        for (int k = j; k < length - 1; k++){
                            nums[k] = nums[k + 1];
                        }
                        length--; // Reduce the effective size
                        j--; // Check the new element at this position
                    }
                }
            }
            
            for(int i = 0; i < length; i++){
                Console.Write($"{nums[i]} ");
            }
        }
    }
}