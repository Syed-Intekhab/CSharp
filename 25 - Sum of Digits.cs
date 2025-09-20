using System;

namespace SubOfDigits{
    class Program{
        static void Main(String[] args){
            // Variable initialization.
            int num = 0, sum = 0;
            
            // Variable to stop loop when user entered correct number.
            bool success = false;
            
            // Take number from user
            while(!success){
                Console.Write("Enter any number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            // Loop until num becomes 0
            while(num != 0){
                // Take the last digit and add in sum varialbe
                sum += num % 10;
                
                // Remove last digit
                num /= 10;
            }
            
            // Print last digit.
            Console.WriteLine($"Sum of given number is: {sum}");
        }
    }
}