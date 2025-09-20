// Basic Structure Definition & Access
using System;
using System.Collections.Generic;

namespace PersonDetails{
    class Program{
        static void Main(String[] args){
            Person person = new Person();
            
            person.name = "John";
            person.age = 18;
            
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
        }
    }
    
    struct Person{
        public string name;
        public int age;
    }
}