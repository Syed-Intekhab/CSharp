// Function that takes optional parameters and uses try-catch inside.
using System;
using System.Collections.Generic;

// IndexOutOfRangeException

namespace OptionalParam{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5};
            
            Console.WriteLine(returnElement(ref nums));
            Console.WriteLine(returnElement(ref nums, 5));
            Console.WriteLine(returnElement(ref nums, 3));
        }
        
        static int returnElement(ref int[] nums, int n = 0){
            try{
                return nums[n];
            } catch(IndexOutOfRangeException){
                Console.WriteLine("Invalid Index.");
            } catch(Exception){
                Console.WriteLine("Something Went Wrong.");
            }
                
            return -1;
        }
    }
}