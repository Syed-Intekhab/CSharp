using System;

namespace LargestNum{
    class Program{
        static void Main(String[] args){
            bool num1Result = false, num2Result = false;
            int num1 = 0, num2 = 0;
            
            while(!(num1Result && num2Result)){
                Console.Write("Enter any number: ");
                num1Result = int.TryParse(Console.ReadLine(), out num1);
                
                Console.Write("Enter another number: ");
                num2Result = int.TryParse(Console.ReadLine(), out num2);
                
                Console.WriteLine();
            }
            
            Console.Write("The large number is: ");
            if(num1 > num2){
                Console.WriteLine(num1);
            } else {
                Console.WriteLine(num2);
            }
        }
    }
}