// Create a class Student with a method DisplayInfo() to print student details.
using System;
using System.Collections.Generic;

namespace StudentDetails{
    class Student{
        public int id;
        public string name;
        public int age;
        public string address;
        
        public void displayInfo(){
            Console.WriteLine($"{id} {name} {age} {address}");
        }
    }
    
    class Program{
        static void Main(String[] args){
            Student student = new Student();
            
            student.id = 101;
            student.name = "John";
            student.age = 18;
            student.address = "New York";
            
            student.displayInfo();
        }
    }
}