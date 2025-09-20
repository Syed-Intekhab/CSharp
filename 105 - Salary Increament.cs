// Create a class Employee with a salary field and a method to increase salary by a percentage.
using System;
using System.Collections.Generic;

namespace Company{
    class Employee{
        private double salary;
        
        public Employee(double initialSalary){
            salary += initialSalary;
        }
        
        public void increamentSalary(double percentage){
            if(percentage < 0){
                Console.WriteLine("Percentage cannot be negative.");
                return;
            }
            
            double increment = (salary * percentage) / 100;
            salary += increment;
        }
        
        public void displaySalary(){
            Console.WriteLine("Current Salary: " + salary);
        }
    }
    
    class Program{
        static void Main(String[] args){
            Employee emp = new Employee(500);
            
            emp.displaySalary();
            
            emp.increamentSalary(10);
            emp.displaySalary();
            
            emp.increamentSalary(5);
            emp.displaySalary();
        }
    }
}