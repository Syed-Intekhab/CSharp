// Function that divides two numbers and handles divide-by-zero.
using System;
using System.Collections.Generic;

namespace HandleDivide{
    class Program{
        static void Main(String[] arg){
            int num1 = 5, num2 = 0;
            
            try{
                Console.WriteLine(num1 / num2);
            } catch(DivideByZeroException){
                Console.WriteLine("Value Cannot Be Divided With Zero!");
            } catch(Exception e){
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}