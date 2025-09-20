// Count how many positive, negative and zero's in a string.
using System;

namespace PositiveCounter{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, -3, -5, 0, 0, 0, -56};
            int zero = 0, positive = 0, negative = 0;
            
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] < 0){
                    negative++;
                } else if(nums[i] > 0){
                    positive++;
                } else {
                    zero++;
                }
            }
            
            Console.WriteLine("Positive Numbers: " + positive);
            Console.WriteLine("Negative Numbers: " + negative);
            Console.WriteLine("Zeros: " + zero);
        }
    }
}