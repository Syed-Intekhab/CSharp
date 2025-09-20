// Input Validation Property
using System;
using System.Collections.Generic;
using System.IO;

namespace Property{
    class Product{
        private double price;
        public double Price{
            get{ return price; }
            set{
                if(value < 0)
                    price = 0;
                else
                    price = value;
            }
        }
    }
    
    class Program{
        static void Main(String[] args){
            Product product = new Product();
            
            product.Price = -10.99;
            Console.WriteLine(product.Price);
        }
    }
}