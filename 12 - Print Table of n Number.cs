// Write a program to print numbers from 1 to 10 using a loop.

using System;

namespace PrintTable{
    class Program{
        static void Main(String[] args){
            bool isSucceed = false;
            int num = 0;
            
            while(!isSucceed){
                Console.Write("Enter a number: ");
                isSucceed = int.TryParse(Console.ReadLine(), out num);
            }
            
            for(int i = 1; i < 11; i++){
                Console.WriteLine(num * i);
            }
            
        }
    }
}