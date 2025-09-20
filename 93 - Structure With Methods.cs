// Structure with Methods
using System;
using System.Collections.Generic;

namespace StructureWithMethods{
    class Program{
        const double PI = 3.14;
        
        struct Circle{
            public double radius;
            
            public double circumference(){
                return 2 * PI * radius;
            }
            
            public double area(){
                return PI * radius * radius;
            }
            
            public Circle(double r){
                radius = r;
            }
        }
        
        
        static void Main(String[] args){
            Circle shape = new Circle(5);
            
            Console.WriteLine($"Circumference of the circle is: {shape.circumference()}");
            Console.WriteLine($"area of the circle is: {shape.area()}");
        }
    }
}