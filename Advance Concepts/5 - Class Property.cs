// Property
using System;
using System.Collections.Generic;
using System.IO;

namespace Property{
    class Rectangle{
        private double width;
        private double length;
        
        public double Area{
            get { return width * length; }
        }
        
        public Rectangle(double width, double length){
            this.width = width;
            this.length = length;
        }
    }
    
    class Program{
        static void Main(String[] args){
            Rectangle rectangle = new Rectangle(5, 8);
            
            Console.WriteLine(rectangle.Area);
        }
    }
}