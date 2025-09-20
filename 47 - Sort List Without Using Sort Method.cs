// Sort a list in ascending order without using Sort()
using System;
using System.Collections.Generic;

namespace SortList{
    class Program{
        static void Main(String[] args){
            // Declare List
            List<int> nums = new List<int>(){1, 3, 5, 2, 4};
            int n = nums.Count;
            
            // Bubble Sorts
            for(int i = 0; i < n; i++){
                for(int j = 0; j < n - i - 1; j++){
                    if(nums[j] > nums[j + 1]){
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            
            // Display Sorted List
            Console.WriteLine("Sorted List: ");
            foreach(int num in nums){
                Console.Write(num + " ");
            }
        }
    }
}