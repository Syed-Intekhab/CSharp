// Function that displays employee info with named parameters in different orders.
using System;
using System.Collections.Generic;

namespace EmployeeDetails{
    class Program{
        static void Main(String[] args){
            printDetails(age: 18, EID: 101, name: "John");
            
            Console.WriteLine();
            
            printDetails(age: 18, EID: 101, name: "John", salary: 25000);
        }
        
        static void printDetails(string name, int age, int EID, int salary = 20000){
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee Id: {EID}");
            Console.WriteLine($"Salary: {salary}");
        }
    }
}