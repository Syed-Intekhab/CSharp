using System;

namespace ReverseNumber{
    class Program{
        static void Main(String[] args){
            // Initialize Variables
            int num = 0, reverse = 0;
            
            // Variable to stop the loop when user entered correct num
            bool success = false;
            
            // Loop until user entered correct number.
            while(!success){
                Console.Write("Enter a number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
    
            // Main logic to reverse the .
            while(num != 0){
                // Get last digit.
                int digit = num % 10;
                
                // Store in reversed number variable.
                reverse = (reverse * 10) + digit;
                
                // Remove last digit.
                num /= 10;
            }
            
            // Print Reversed Number!
            Console.WriteLine(reverse);
        }
    }
}