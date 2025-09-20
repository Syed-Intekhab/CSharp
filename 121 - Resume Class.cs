// Create a Resume class with fields: Name, Email, Phone. Create an object and display its details.
using System;
using System.Collections.Generic;

namespace ResumeMaker{
    class Resume{
        public string name;
        public string eMail;
        public string phone;
    }
    
    class Program{
        static void Main(String[] args){
            Resume resume = new Resume();
            
            resume.name = "John";
            resume.eMail = "John@example.com";
            resume.phone = "234234324";
            
            Console.WriteLine("Name: " + resume.name);
            Console.WriteLine("Email: " + resume.eMail);
            Console.WriteLine("Phone: " + resume.phone);
        }
    }
}