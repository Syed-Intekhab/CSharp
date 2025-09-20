// Check if a list contains a specific value.
using System;
using System.Collections.Generic;

namespace CheckForElement{
    class Program{
        static void Main(String[] args){
            List<int> nums = new List<int>(){1, 2, 3, 4, 5, 6, 7};
            int length = nums.Count, num = 0, index = -1;
            bool success = false;
            
            while(!success){
                Console.Write("Enter a number to find: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            for(int i = 0; i < length; i++)
                if(nums[i] == num)
                    index = i;
                    
            Console.WriteLine(index != -1 ? $"Number Found At Index {index}" : "Number Not Found!");
        }
    }
}