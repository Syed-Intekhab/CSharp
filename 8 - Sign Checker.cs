using System;

namespace CheckSign{
    class Program{
        static void Main(String[] args){
            bool success = false;
            int num = 0;
            
            while(!success){
                Console.Write("Enter any number: ");
                success = int.TryParse(Console.ReadLine(), out num);
                Console.WriteLine();
            }
            
            if(num == 0){
                Console.WriteLine("Entered number was zero.");
            } else if(num > 0){
                Console.WriteLine("Entered number was Positive");
            } else {
                Console.WriteLine("Entered number was Negative");
            }
        }
    }
}