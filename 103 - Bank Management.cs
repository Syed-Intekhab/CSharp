// Create a class BankAccount with deposit and withdraw methods.
using System;
using System.Collections.Generic;

namespace Bank{
    class BackAccount{
        int balance = 0;
        
        public void deposite(int money){
            balance += money;
            Console.WriteLine($"{money}rs Deposite Succesfully!");
        }
        
        public void withdraw(int money){
            balance -= money;
            Console.WriteLine($"Withdrew {money}rs");
        }
        
        public void displayBalance(){
            Console.WriteLine($"Available balance: {balance}");
        }
    }
    
    class Program{
        static void Main(String[] args){
            BackAccount account = new BackAccount();
            
            account.deposite(50);
            Console.WriteLine();
            account.withdraw(10);
            Console.WriteLine();
            account.displayBalance();
        }
    }
}