// Create a class Calculator with methods for addition, subtraction, multiplication, and division.
using System;
using System.Collections.Generic;

namespace CalculatorApp{
    class Calculator{
        public int add(int a, int b){
            return a + b;
        }
        
        public int sub(int a, int b){
            return a - b;
        }
           
        public int mul(int a, int b){
            return a * b;
        }
            
        public double div(int a, int b){
            if(b != 0){
                return a / b;
            }
            
            return -1;       
        }
        
    }
    
    class Program{
        static void Main(String[] args){
            Calculator calc = new Calculator();
            int num1 = 5, num2 = 10;
            
            Console.WriteLine(calc.add(num1, num2));
            Console.WriteLine(calc.sub(num1, num2));
            Console.WriteLine(calc.mul(num1, num2));
            Console.WriteLine(calc.div(num1, num2));
        }
    }
}// Create a class Calculator with methods for addition, subtraction, multiplication, and division.
using System;
using System.Collections.Generic;

namespace CalculatorApp{
    class Calculator{
        public int add(int a, int b){
            return a + b;
        }
        
        public int sub(int a, int b){
            return a - b;
        }
           
        public int mul(int a, int b){
            return a * b;
        }
            
        public double div(int a, int b){
            if(b != 0){
                return a / b;
            }
            
            return -1;       
        }
        
    }
    
    class Program{
        static void Main(String[] args){
            Calculator calc = new Calculator();
            int num1 = 5, num2 = 10;
            
            Console.WriteLine(calc.add(num1, num2));
            Console.WriteLine(calc.sub(num1, num2));
            Console.WriteLine(calc.mul(num1, num2));
            Console.WriteLine(calc.div(num1, num2));
        }
    }
}