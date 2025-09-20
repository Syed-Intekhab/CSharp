using System;

namespace StarPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Triangle Pattern
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            // Triangle Pattern
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            // Kite Pattern
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }

                for(int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
