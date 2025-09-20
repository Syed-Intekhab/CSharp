// Write a program to count the number of even and odd elements in an array.
using System;

namespace EvenOddChecker{
    class Program{
        static void Main(String[] args){
            int[] nums = new int[] {1, 2, 3, 4, 5, 6};
            int even = 0, odd = 0;
            
            foreach(int num in nums){
                if(num % 2 == 0) even++;
                else odd++;
            }
            
            Console.WriteLine("Count Of Even Numbers Is: " + even);
            Console.WriteLine("Count Of Odd Numbers Is: " + odd);
        }
    }
}