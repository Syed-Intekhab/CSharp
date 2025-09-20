using System;
using System.Collections.Generic;
using System.IO;

namespace Constructors{
    class Car{
        public string brand;
        public string model;
        public int price;
        
        public Car(){
            brand = "Unknown";
            model = "Unknown";
            price = 0;
            Console.WriteLine("Default Constructor is called!");
            Console.WriteLine();
        }
    }
    
    class Program{
        static void Main(String[] args) {
            Car car = new Car();
            Console.WriteLine($"{car.brand} {car.model} {car.price}");
        }
    }
}