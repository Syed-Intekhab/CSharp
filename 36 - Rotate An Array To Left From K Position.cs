// Rotate an array to the left by k positions.
using System;

namespace LeftShift{
    class Prgoram{
        static void Main(String[] args){
            int[] nums = new int[]{1, 2, 3, 4, 5};
            int n = nums.Length, loopCounter = 0, k = 2;
            int[] newNums = new int[n];
            
            // Array Parts
            int[] firstPart = new int[k];
            int[] secondPart = new int[n - k];
            
            // Loop To Get First Part of An Array
            for(int i = 0; i < k; i++){
                firstPart[i] = nums[i];
            }
            
            // Loop To Get Second Part of An Array
            for(int i = k; i < n; i++, loopCounter++){
                secondPart[loopCounter] = nums[i];
            }
            
            // Store second part first in new array.
            for(int i = 0; i < secondPart.Length; i++){
                newNums[i] = secondPart[i];
            }
            
            loopCounter = 0;
            
            // Store first part in new array.
            for(int j = secondPart.Length; j < n; j++, loopCounter++){
                newNums[j] = firstPart[loopCounter];
            }
            
            foreach(int num in newNums){
                Console.Write($"{num} ");
            }
        }
    }
}