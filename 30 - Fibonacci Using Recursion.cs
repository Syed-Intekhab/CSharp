// Fibonacci using recursion.
using System;

namespace Fibonacci{
    class Program{
        static void printFib(int a, int b, int n, int i){
            if(i == n){
                return;
            }
            int c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
            i++;
            printFib(a, b, n, i);
        }
        
        static void Main(String[] args){
            int a = 0, b = 1, n = 0, i = 2;
            bool success = false;
            
            while(!success){
                Console.Write("Enter any number: ");
                success = int.TryParse(Console.ReadLine(), out n);
            }
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            printFib(a, b, n, 1);
        }
    }
}