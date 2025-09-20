// Merge two arrays into single array.
using System;

namespace MergeTwoArrays{
    class Program{
        static void Main(String[] args){
            // Initialize two arrays.
            int[] nums1 = new int[] {1, 2, 3, 4, 5};
            int[] nums2 = new int[] {6, 7, 8, 9, 10};
            
            // Get length of both arrays.
            int arrayLength = nums1.Length + nums2.Length;
            
            // Declare new array with old arrays length.
            int[] mergedArray = new int[arrayLength];
            int loopCounter = 0;
            
            // Loop throguh each array and store elements in new array
            for(int i = 0; i < nums1.Length; i++){
                mergedArray[loopCounter] = nums1[i];
                loopCounter++;
            }
            
            for(int i = 0; i < nums2.Length; i++){
                mergedArray[loopCounter] = nums2[i];
                loopCounter++;
            }
            
            // Display new array.
            foreach(int num in mergedArray){
                Console.Write($"{num} ");
            }
        }
    }
}