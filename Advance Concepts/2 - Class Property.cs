// Class Property
using System;
using System.Collections.Generic;
using System.IO;

namespace Property{
    class Student{
        private string name;
        private int rollNumber;
        
        // public string Name{
        //     get { return name; }
        //     set { name = value; }
        // }
        
        // public int RollNumber{
        //     get { return rollNumber; }
        //     set { rollNumber = value; }
        // }
        
        public string Name{ get; set; }
        public int RollNumber{ get; set; }
    }
    
    class Program{
        static void Main(String[] args){
            Student student = new Student();
            
            student.Name = "John Doe";
            student.RollNumber = 101;
            
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Roll Number: " + student.RollNumber);
        }
    }
}