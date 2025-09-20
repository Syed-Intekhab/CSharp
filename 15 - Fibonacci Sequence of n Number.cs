// Write a program to print Fibonacci series up to N terms.

using System;

namespace Fibonacci{
    class Program{
        static void Main(String[] args){
            int a = 0, b = 1, num = 0;
            int c = a + b;
            bool isSucceed = false;
            
            while(!isSucceed){
                Console.Write("Enter enter a number: ");
                isSucceed = int.TryParse(Console.ReadLine(), out num);
            }
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            for(int i = 2; i < num; i++){
                Console.WriteLine(c);
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}