// Count how many times a specific number appears in an array.
using System;

namespace CountElementPresence{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 2, 3, 4, 2, 1, 5, 2};
            int n = 2, count = 0;
            
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] == n){
                    count++;
                }
            }
            
            Console.WriteLine($"{n} : {count} times");
        }
    }
}