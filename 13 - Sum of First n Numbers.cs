// Write a program to calculate the sum of first N natural numbers.

using System;

namespace PrintSumOfNNumbers{
    class Program{
        static void Main(String[] args){
            bool isSucceed = false;
            int num = 0, sum = 0;
            
            while(!isSucceed){
                Console.Write("Enter any number: ");
                isSucceed = int.TryParse(Console.ReadLine(), out num);
            }
            
            for(int i = 1; i <= num; i++){
                sum += i;
            }
            
            Console.WriteLine(sum);
        }
    }
}