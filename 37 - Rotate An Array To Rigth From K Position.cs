// Rotate an array to the right by k positions.
using System;

namespace ShiftArray{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[]{1, 2, 3, 4, 5};
            int n = nums.Length, k = 2, loopCounter = 0;
            int[] newNums = new int[n];
            
            int[] firstPart = new int[n - k];
            int[] secondPart = new int[k];
            
            // Get first part.
            for(int i = 0; i < n - k; i++){
                firstPart[i] = nums[i];
            }
            
            // Get second part.
            for(int i = n - k; i < n; i++, loopCounter++){
                secondPart[loopCounter] = nums[i];
            }
            
            // Store Second Part In New Array First.
            for(int i = 0; i < k; i++){
                newNums[i] = secondPart[i];
            }
            
            loopCounter = 0;
            
            // Store First Part in New Array.
            for(int i = k; i < n; i++, loopCounter++){
                newNums[i] = firstPart[loopCounter];
            }
            
            // Display New Array
            foreach(int num in newNums){
                Console.Write($"{num} ");
            }
        }
    }
}