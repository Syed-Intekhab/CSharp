// Sort array without using built-in method.
using System;

namespace SortArray{
    class Progra{
        static void Main(String[] args){
            // Unsorted array
            int[] arr = { 5, 3, 8, 1, 2 };
            int arrayLength = arr.Length;
            
            // Bubble Sort
            for(int i = 0; i < arrayLength - 1; i++){
                for(int j = 0; j < arrayLength - i - 1; j++){
                    if(arr[j] > arr[j + 1]){
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            
            // Display Sorted Array
            foreach(int num in arr){
                Console.Write($"{num} ");
            }
        }
    }
}