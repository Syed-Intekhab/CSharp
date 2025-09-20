// Create a class Laptop with brand, RAM, and price. Create an array of objects and display all laptops.
using System;
using System.Collections.Generic;

namespace Shop{
    class Laptop{
        public string brand;
        public int ram;
        public double price;
    }
    
    class Program{
        static void Main(String[] args){
            Laptop[] laptops = new Laptop[3];
            
            laptops[0] = new Laptop {brand = "Lenovo", ram = 4, price = 4500.53};
            laptops[1] = new Laptop {brand = "HP", ram = 8, price = 4600.53};
            laptops[2] = new Laptop {brand = "Dell", ram = 12, price = 4700.53};
            
            Console.WriteLine(laptops[0].brand);
            Console.WriteLine(laptops[0].ram);
            Console.WriteLine(laptops[0].price);
            Console.WriteLine();
            Console.WriteLine(laptops[1].brand);
            Console.WriteLine(laptops[1].ram);
            Console.WriteLine(laptops[1].price);
            Console.WriteLine();
            Console.WriteLine(laptops[2].brand);
            Console.WriteLine(laptops[2].ram);
            Console.WriteLine(laptops[2].price);
            
        }
    }
}