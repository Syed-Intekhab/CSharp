using System;

namespace LeapYearChecker{
    class Program{
        static void Main(String[] args){
            int year = 1900;
            
            if((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))){
                Console.WriteLine("It's a leap year!");
            } else {
                Console.WriteLine("It's not a leap year!");
            }
        }
    }
}