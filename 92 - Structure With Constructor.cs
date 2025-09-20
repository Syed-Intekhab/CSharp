// Structure with Constructor
using System;
using System.Collections.Generic;

namespace StructureConstructor{
    class Program{
        struct Rectangle{
            public int length;
            public int width;
            
            public int returnArea(){
                return length * width;
            }
            
            public Rectangle(int length, int width){
                this.length = length;
                this.width = width;
            }
        }
        
        static void Main(String[] args){
            Rectangle shape = new Rectangle(4, 8);
            
            Console.WriteLine($"Length of the Rectangle is: {shape.length}");
            Console.WriteLine($"Width of the Rectangle is: {shape.width}");
            Console.WriteLine($"Area of the Rectangle is: {shape.returnArea()}");
        }
    }
}