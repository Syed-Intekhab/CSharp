// Property
using System;
using System.Collections.Generic;
using System.IO;

namespace Property{
    class Person{
        private string name;
        
        // public string Name{
        //     get { return name; }
        //     set { name = value; }
        // }
        
        public string Name{ get; set; }
    }
    
    class Program{
        static void Main(String[] args){
            Person person = new Person();
            
            person.Name = "John";
            Console.WriteLine(person.Name);
        }
    }
}