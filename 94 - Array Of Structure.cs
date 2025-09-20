// Structure Array
using System;
using System.Collections.Generic;

namespace StructureArray{
    class Program{
        struct Book{
            public string title;
            public string author;
            public int price;
        }
        
        static void Main(String[] args){
            Book[] books = new Book[3]{
                    new Book { title = "Romeo and Juliet", author = "William Shakespeare", price = 5000 },
                    new Book { title = "Macbeth", author = "William Shakespeare", price = 4000},
                    new Book { title = "The Merchant of Venice", author = "William Shakespeare", price = 3000}
            };
            
            // books[0].title = "Romeo and Juliet";
            // books[0].author = "William Shakespeare";
            // books[0].price = 5000;
            
            // books[1].title = "Macbeth";
            // books[1].author = "William Shakespeare";
            // books[1].price = 4000;
            
            // books[2].title = "The Merchant of Venice";
            // books[2].author = "William Shakespeare";
            // books[2].price = 3000;
            
            foreach(Book book in books){
                Console.WriteLine(book.title);
                Console.WriteLine(book.author);
                Console.WriteLine(book.price);
                Console.WriteLine();
            }
        }
    }
}