// Create a WorkExperience class with fields: CompanyName, Role, Years. Create two objects and print their details.
using System;
using System.Collections.Generic;

namespace Company{
    class WorkExperience{
        public string name;
        public string CompanyName;
        public string Role;
        public int Years;
    }
    
    class Program{
        static void Main(String[] args){
            WorkExperience employee1 = new WorkExperience();
            WorkExperience employee2 = new WorkExperience();
            
            employee1.name = "John";
            employee2.name = "Jane";
            
            employee1.CompanyName = "Lenovo";
            employee2.CompanyName = "Dell";
            
            employee1.Role = "Manager";
            employee2.Role = "HR";
            
            employee1.Years = 5;
            employee2.Years = 4;
            
            Console.WriteLine($"{employee1.name} {employee1.CompanyName} {employee1.Role} {employee1.Years}");
            Console.WriteLine($"{employee2.name} {employee2.CompanyName} {employee2.Role} {employee2.Years}");
        }
    }
}