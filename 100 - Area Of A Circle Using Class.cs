// Create a class Circle with a method to calculate and return the area using radius.
using System;
using System.Collections.Generic;

namespace CalculateArea{
    class Circle{
        const double PI = 3.14;
        
        public double area(double r){
            return PI * r * r;
        }
    }
    
    class Program{
        static void Main(String[] args){
            Circle shape = new Circle();
            
            Console.WriteLine($"Area of the circle is: {shape.area(5)}");
        }
    }
}