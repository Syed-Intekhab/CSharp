// Create a class Triangle with a method to calculate the perimeter.
using System;
using System.Collections.Generic;

namespace Triangle{
    class Triangle{
        double perimeter; 
        
        public Triangle(double a, double b, double c){
            perimeter = a + b + c;
        }
        
        public void displayPerimeter(){
            Console.WriteLine($"Perimeter of Triangle is: {perimeter}");
        }
    }
    
    class Program{
        static void Main(String[] args){
            Triangle shape = new Triangle(3, 3, 3);
            
            shape.displayPerimeter();
        }
    }
}