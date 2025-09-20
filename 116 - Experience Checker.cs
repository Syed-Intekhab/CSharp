// Ask the user for years of experience.
    // - If more htan 5 years -> print "Senior".
    // - If less -> print "Junior".
using System;
using System.Collections.Generic;

namespace Inquiry{
    class Program{
        static void Main(String[] args){
            Console.Write("Enter your experience: ");
            int.TryParse(Console.ReadLine(), out int exp);
            
            if(exp > 5)
                Console.WriteLine("Senior");
            else
                Console.WriteLine("Junior");
        }
    }
}