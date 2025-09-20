// Function that accesses an array index with exception handling.
using System;
using System.Collections.Generic;

// IndexOutOfRangeException

namespace HandleArrayIndex{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5};
            int n = 5;
            
            try{
                Console.WriteLine(nums[n]);
            } catch(IndexOutOfRangeException){
                Console.WriteLine("Invalid Array Index!");
            } catch(Exception){
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}