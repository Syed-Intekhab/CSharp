using System;

namespace SwapVariables{
    class Program{
        static void Main(String[] args){
            int a = 5;
            int b = 7;
            
            Console.WriteLine("Values Before Swap: ");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            
            a = a ^ b; // 0 1 0 = 2
            b = a ^ b; // 1 0 1 = 5
            a = a ^ b; // 1 1 1 = 7
            
            Console.WriteLine("\nValues After Swap: ");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
        }
    }
}