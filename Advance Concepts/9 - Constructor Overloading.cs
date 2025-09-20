using System;
using System.Collections.Generic;
using System.IO;

namespace Constructors{
    class Car{
        public string brand;
        public string model;
        public int price;
        
        // Default Constructor
        public Car(){
            brand = "Unknown";
            model = "Unknown";
            price = 0;
            Console.WriteLine("Default Constructor is called!");
        }
        
        // Parameterized Constructor
        public Car(string brand, string model, int price){
            this.brand = brand;
            this.model = model;
            this.price = price;
            Console.WriteLine("Parameterized Constructor is called!");
        }
    }
    
    class Program{
        static void Main(String[] args) {
            Car car1 = new Car();
            Console.WriteLine($"{car1.brand} {car1.model} {car1.price}");
            
            Console.WriteLine();
            
            Car car2 = new Car("Ford", "Mustang", 5000000); // Values Passed
            Console.WriteLine($"{car2.brand} {car2.model} {car2.price}");
        }
    }
}