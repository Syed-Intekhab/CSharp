// Remove all elements greater than a given value from a list.
using System;
using System.Collections.Generic;

namespace RemoveElements{
    class Program{
        static void Main(String[] args){
            int n = 5, length = 5;
            List<int> nums = new List<int>(length);
            
            for(int i = 0; i < n; i++){
                int num = 0;
                bool success = false;
                
                while(!success){
                    Console.Write("Enter any number: ");
                    success = int.TryParse(Console.ReadLine(), out num);
                }
                
                nums.Add(num);
            }
            
            for(int i = nums.Count - 1; i >= 0; i--){
                if(nums[i] > n){
                    nums.RemoveAt(i);
                }
            }
            
            foreach(int num in  nums){
                Console.Write($"{num} ");
            }
        }
    }
}