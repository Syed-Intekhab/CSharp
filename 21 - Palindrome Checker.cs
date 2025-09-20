using System;

namespace PalindromeCheck{
    class Program{
        static void Main(String[] args){
            string str, rstr = "";
            
            Console.Write("Enter any string: ");
            str = Console.ReadLine();
            
            for(int i = str.Length - 1; i >= 0; i--){
                rstr += str[i];
            }
            
            if(str.Equals(rstr)){
                Console.WriteLine("Palindrome!");
            }
            else{
                Console.WriteLine("Not a Palindrome!");
            }
        }
    }
}