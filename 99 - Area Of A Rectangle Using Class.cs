// Create a class Rectangle with fields length and width, and a method to calculate the area.
using System;
using System.Collections.Generic;

namespace CalculateArea{
    class Rectangle{
        public int length;
        public int width;
        
        public int area(){
            return length * width;
        }
    }
    
    class Program{
        static void Main(String[] args){
            Rectangle shape = new Rectangle();
            
            shape.length = 5;
            shape.width = 10;
            
            Console.WriteLine(shape.area());
        }
    }
}