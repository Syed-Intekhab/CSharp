using System;

namespace Armstrong{
    class Program{
        static void Main(String[] args){
            int num = 0, splitDigit, digitLength = 0, sum = 0;
            bool success = false;
            
            while(!success){
                Console.Write("Enter a number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            digitLength = Convert.ToString(num).Length;
            splitDigit = num;
            
            while(splitDigit != 0){
                sum += (int) Math.Pow((splitDigit % 10), digitLength);
                splitDigit /= 10;
            }
            
            if(sum == num)
                Console.WriteLine($"{num} is an Armstrong number!");
            else
                Console.WriteLine($"{num} is not a Armstrong number!");
        }
    }
}