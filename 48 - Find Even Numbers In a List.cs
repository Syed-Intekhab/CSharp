// Find all even numbers in a list and store them in a new list.
using System;
using System.Collections.Generic;

namespace FindEven{
    class Program{
        static void Main(String[] args){
            // Declare Lists
            List<int> nums = new List<int>(){1, 2, 3, 4, 5, 6, 8};
            int length = nums.Count;
            List<int> evenNums = new List<int>(length);
            
            // Store Even Numbers In Even Numbers List
            foreach(int num in nums)
                if(num % 2 == 0)
                    evenNums.Add(num);
            
            // Display Even Numbers List
            foreach(int num in evenNums)
                Console.Write($"{num} ");
        }
    }
}