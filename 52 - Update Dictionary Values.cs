// Update Value – Store student names and their grades in a dictionary, then update a student’s grade.
using System;
using System.Collections.Generic;

namespace UpdateDictionary{
    class Program{
        static void Main(String[] args){
            Dictionary<string, char> students = new Dictionary<string, char>(){
                {"John", 'A'},
                {"Jane", 'C'},
                {"Travis", 'B'},
                {"James", 'D'}
            };
            
            Console.WriteLine("Values Before Update: ");
            foreach(KeyValuePair<string, char> pair in students){
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            
            students["John"] = 'A';
            students["Jane"] = 'A';
            students["Travis"] = 'A';
            students["James"] = 'A';
            
            Console.WriteLine();
            Console.WriteLine("Values After Update: ");
            foreach(KeyValuePair<string, char> pair in students){
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}