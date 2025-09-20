// Function that takes a number and returns its reverse.
using System;
using System.Collections.Generic;

namespace ReverseNumber{
    class Program{
        static void Main(String[] args){
            int num = 0;
            bool success = false;
            
            while(!success){
                Console.Write("Enter any number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            Console.WriteLine(reverseNum(num));
        }
        
        static int reverseNum(int num){
            int reverse = 0;
            
            while(num != 0){
                int digit = num % 10;
                reverse = (reverse * 10) + digit;
                num /= 10;
            }
            
            return reverse;
        }
    }
}