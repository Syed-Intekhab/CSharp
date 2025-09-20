// Remove all elements from a list that are less than a given number.
using System;
using System.Collections.Generic;

namespace RemoveElements{
    class Program{
        static void Main(String[] args){
            // Declare List
            List<int> nums = new List<int>(){1, 2, 3, 4, 5, 6, 7};
            int length = nums.Count, n = 3;
            
            // Revemo Elements Less than n.
            for(int i = length - 1; i >= 0; i--)
                if(nums[i] < n)
                    nums.RemoveAt(i);
                    
            // Display New List
            Console.WriteLine("List: ");
            foreach(int num in nums){
                Console.Write($"{num} ");
            }
        }
    }
}