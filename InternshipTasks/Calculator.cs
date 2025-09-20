using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t\t!!!Welcome to my calculator!!!\n");
            Console.WriteLine("Choose 1 for Addition!");
            Console.WriteLine("Choose 2 for Subtraction!");
            Console.WriteLine("Choose 3 for Multiplication!");
            Console.WriteLine("Choose 4 for Division!");
            Console.WriteLine("Choose 5 to close the program!\n\n\n");

            while (true)
            {
                Console.Write("Enter first number: ");
                bool num1Result = int.TryParse(Console.ReadLine(), out int num1);

                Console.Write("Enter second number: ");
                bool num2Result = int.TryParse(Console.ReadLine(), out int num2);

                Console.Write("Enter your choice: ");
                int.TryParse(Console.ReadLine(), out int choice);

                if (choice == 5)
                    break;

                if (num1Result && num2Result)
                    Calculator.Calculate(num1, num2, choice);
                else
                    Console.WriteLine("Invalid Input!");
            }
        }
    }

    class Calculator
    {
        public static void Calculate(int num1, int num2, int choice)
        {
            switch (choice)
            {
                case 1: Console.WriteLine($"Addition of {num1} and {num2} is: {num1 + num2}\n");
                    break;
                case 2: Console.WriteLine($"Subtraction of {num1} and {num2} is: {num1 - num2}\n");
                    break;
                case 3: Console.WriteLine($"Multiplication of {num1} and {num2} is: {num1 * num2}\n");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Division of {num1} / {num2} is: {num1 / num2}\n");
                    else
                        Console.WriteLine($"CAnnot divide a number by zero!\n");
                    break;
                default: Console.WriteLine("Invalid choice!\n");
                    break;
            }
        }
    }
}