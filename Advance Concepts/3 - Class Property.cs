// Class Property
using System;
using System.Collections.Generic;
using System.IO;

namespace Property{
    class Car{
        private string brand;
        private string model;
        private int price;
        
        public string Brand{ get; set; }
        public string Model{ get; set; }
        public int Price{ get; set; }
    }
    
    class Program{
        static void Main(String[] args){
            Car car = new Car();
            
            car.Brand = "Ford";
            car.Model = "Mustang";
            car.Price = 5000000;
            
            Console.WriteLine(car.Brand);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Price);
        }
    }
}