// Find second largest element in an array.
using System;

namespace SecondLargestElem{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[]{1, 2, 3, 4, 5, 6, 7, 8};
            int largest = nums[0], secondLargest = largest;
            
            for(int i = 0; i < nums.Length - 1; i++){
                if(nums[i + 1] > largest){
                    secondLargest = largest;
                    largest = nums[i + 1];
                }
            }
            
            Console.WriteLine($"Second Largest Elem in Arrya is: {secondLargest}");
        }
    }
}