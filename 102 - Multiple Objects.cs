// Create a class Book with properties Title and Author. Create multiple objects and display details.
using System;
using System.Collections.Generic;

namespace Library{
    class Book{
        public string title;
        public string author;
        
        public void displayDetails(){
            Console.WriteLine($"Title: {title}\nAuthor: {author}");
        }
    }
    
    class Program{
        static void Main(String[] args){
            Book book1 = new Book();
            Book book2 = new Book();
            
            book1.title = "Atomic Habits";
            book1.author = "James Clear";
            
            book2.title = "Romeo & Juliet";
            book2.author = "William Shakspear";
            
            book1.displayDetails();
            Console.WriteLine();
            book2.displayDetails();
        }
    }
}