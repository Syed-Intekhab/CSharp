// Create a class Temperature with a method to convert Celsius to Fahrenheit.
using System;
using System.Collections.Generic;

namespace TemperatureConverter{
    class Converter{
        public static double F2C(double f){
            return (f - 32) * 5 / 9;
        }
        
        public static double C2F(double c){
            return (c * 9 / 5) + 32;
        }
    }
    
    class Program{
        static void Main(String[] args){
            Console.WriteLine(Converter.F2C(32));
            Console.WriteLine(Converter.C2F(1));
        }
    }
}