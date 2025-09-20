// Create a class Car with fields brand, model, and year. Create an object and display its details.
using System;
using System.Collections.Generic;

namespace CarDetails{
    class Car{
        public string brand;
        public string model;
        public int year;
    }
    
    class Program{
        static void Main(String[] args){
            Car car = new Car();
            
            car.brand = "Ford";
            car.model = "Mustang";
            car.year = 1969;
            
            Console.WriteLine($"{car.brand} {car.model} {car.year}");
        }
    }
}