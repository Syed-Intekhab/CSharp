// Function that processes a list of integers, returns sum and average via out, and catches any exception.
using System;
using System.Collections.Generic;

namespace SumAndAverage{
    class Program{
        static void Main(String[] args){
            List<int> list = new List<int>(){1, 2, 3, 4, 5};
            
            processList(ref list, out int average, out int sum);
            Console.WriteLine($"Sum of list is: {sum}");
            Console.WriteLine($"Average of list is: {average}");
        }
        
        static void processList(ref List<int> list, out int average, out int sum){
            sum = 0;
            average = 0;
            int length = list.Count;
            
            foreach(int num in list){
                sum += num;
            }
            
            average = sum / length;
        }
    }
}