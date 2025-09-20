// Find the smallest element in an array.
using System;

namespace SmallestElem{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {5, 4, 3, 2, 1};
            int smallest = nums[0];
            
            for(int i = 0; i < nums.Length; i++){
                if(smallest > nums[i]){
                    smallest = nums[i];
                }
            }
            
            Console.WriteLine("The smallest element is: " + smallest);
        }
    }
}