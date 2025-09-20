// Add a method DisplayResume() in the Resume class to print all data.
using System;
using System.Collections.Generic;

namespace ResumeMaker{
    class Resume{
        public string name;
        public string eMail;
        public string phone;
        
        public void displayDetails(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + eMail);
            Console.WriteLine("Phone: " + phone);
        }
    }
    
    class Program{
        static void Main(String[] args){
            Resume resume = new Resume();
            
            resume.name = "John";
            resume.eMail = "John@example.com";
            resume.phone = "234234324";
            
            resume.displayDetails();
        }
    }
}