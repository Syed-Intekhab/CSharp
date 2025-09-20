using System;

namespace PrimeNumber{
    class Program{
        static void Main(String[] args){
            int num = 0;
            bool success = false, isPrime = true;
            
            while(!success){
                Console.Write("Enter a number: ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            
            if(num > 1){
                for(int i = 2; i <= Math.Sqrt(num); i++){
                    if(num % i == 0){
                        isPrime = false;
                        break;
                    }
                }
            } else {
                isPrime = false;
            }
            
            if(isPrime)
                Console.WriteLine($"{num} is a prime number.");
            else
                Console.WriteLine($"{num} is not a prime number.");
        }
    }
}