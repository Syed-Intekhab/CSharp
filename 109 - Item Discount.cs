// Create a class ShopItem with item name and price, and a method to apply discount.
using System;
using System.Collections.Generic;

namespace Shop{
    class ShopItem{
        public string itemName;
        public double price;
        
        public void appyDiscount(double percentage){
            if (percentage > 0 && percentage <= 100)
            {
                price -= price * (percentage / 100);
            }
            else
            {
                Console.WriteLine("Invalid discount percentage!");
            }
        }
        
        public ShopItem(string name, double price){
            this.itemName = name;
            this.price = price;
        }
        
        // Method to display item details
        public void Display()
        {
            Console.WriteLine($"Item: {itemName}, Price: {price}");
        }
    }
    
    class Program{
        static void Main(String[] args){
            ShopItem item = new ShopItem("Headphones", 2000);
            
            Console.WriteLine("Before Discount:");
            item.Display();
            
            item.appyDiscount(50);
            
            Console.WriteLine("\nAfter 5% Discount:");
            item.Display();
        }
    }
}