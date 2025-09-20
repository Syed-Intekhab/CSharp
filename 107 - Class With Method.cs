// Create a class Animal with a method Speak() that prints a sound.
using System;
using System.Collections.Generic;

namespace Jungle{
    class Animal{
        public void speak(){
            Console.WriteLine("Mew Mew!");
        }
    }
    
    class Program{
        static void Main(String[] args){
            Animal cat = new Animal();
            
            cat.speak();
        }
    }
}