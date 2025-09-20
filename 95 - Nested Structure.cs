// Structure with Nested Structure
using System;
using System.Collections.Generic;

namespace NestedStructure{
    class Program{
        struct Address{
            public string street;
            public string city;
            public string zip;
        }
        
        struct Employee{
            public string name;
            public int age;
            public Address address;
        }
        
        static void Main(String[] args){
            Employee employee1 = new Employee();
            
            employee1.name = "John";
            employee1.age = 18;
            employee1.address.street = "123 Street";
            employee1.address.city = "WT";
            employee1.address.zip = "23422";
            
            Console.WriteLine($"Employee Name: {employee1.name}");
            Console.WriteLine($"Employee Age: {employee1.age}");
            Console.WriteLine($"Employee Address: {employee1.address.street} {employee1.address.city} {employee1.address.zip}");
        }
    }
}// Structure with Nested Structure
using System;
using System.Collections.Generic;

namespace NestedStructure{
    class Program{
        struct Address{
            public string street;
            public string city;
            public string zip;
        }
        
        struct Employee{
            public string name;
            public int age;
            public Address address;
        }
        
        static void Main(String[] args){
            Employee employee1 = new Employee();
            
            employee1.name = "John";
            employee1.age = 18;
            employee1.address.street = "123 Street";
            employee1.address.city = "WT";
            employee1.address.zip = "23422";
            
            Console.WriteLine($"Employee Name: {employee1.name}");
            Console.WriteLine($"Employee Age: {employee1.age}");
            Console.WriteLine($"Employee Address: {employee1.address.street} {employee1.address.city} {employee1.address.zip}");
        }
    }
}