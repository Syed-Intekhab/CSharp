// Read Only Property
using System;
using System.Collections.Generic;
using System.IO;

namespace Property{
    class Book{
        private string title;
        private string author;
        
        public Book(string title){
            this.title = title;
        }
        
        public string Author{ get; set; }
        public string Title{
            get{ return title; }
        }
    }
    
    class Program{
        static void Main(String[] args){
            Book book = new Book("Atomic Habits");
            book.Author = "James Clear";
            // book.Title = "Hello"; // Read-Only
            
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
        }
    }
}