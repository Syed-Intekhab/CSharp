// Create a class Person with a constructor that sets name and age, and a method to display them.
using System;
using System.Collections.Generic;

namespace PersonDetails{
    class Person{
        public string name;
        public int age;
        
        public void displayDetails(){
            Console.WriteLine($"Name: {name}\nAge: {age}");
        }
        
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }
    }
    
    class Program{
        static void Main(String[] args){
            Person person = new Person("John", 18);
            
            person.displayDetails();
        }
    }
}