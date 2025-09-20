using System;

namespace LargestOfThree{
    class Program{
        static void Main(String[] args){
            bool num1Result, num2Result, num3Result;
            num1Result = num2Result = num3Result = false;
            int num1 = 0, num2 = 0, num3 = 0;
            
            while(!(num1Result && num2Result && num3Result)){
                Console.Write("Enter any number: ");
                num1Result = int.TryParse(Console.ReadLine(), out num1);
                
                Console.Write("Enter any number: ");
                num2Result = int.TryParse(Console.ReadLine(), out num2);
                
                Console.Write("Enter any number: ");
                num3Result = int.TryParse(Console.ReadLine(), out num3);
                
                Console.WriteLine();
            }
            
            if(num1 > num2 && num1 > num3){
                Console.WriteLine(num1);
            } else if(num2 > num1 && num2 > num3){
                Console.WriteLine(num2);
            } else if(num3 > num1 && num3 > num2){
                Console.WriteLine(num3);
            }
            
        }
    }
}