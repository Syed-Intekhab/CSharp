using System;

namespace FactorialNumber{
    class Program{
        static int returnFact(int n){
            if(n == 1 || n == 0){
                return 1;
            }
            
            return n * returnFact(n - 1);
        }
        
        static void Main(String[] args){
            int num = 0;
            bool success = false;
            
            // Loop until entered correct number.
            while(!success){
                Console.Write("Enter any number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            Console.WriteLine(returnFact(num));
        }
    }
}