// Create a class Movie with title, genre, and rating, and a method to display details.
using System;
using System.Collections.Generic;

namespace Theater{
    class Movie{
        string movieTitle;
        string movieGenre;
        int movieRating;
        
        public Movie(string title, string genre, int rating){
            movieTitle = title;
            movieGenre = genre;
            movieRating = rating;
        }
        
        public void displayDetails(){
            Console.WriteLine($"Title: {movieTitle}\nGenre: {movieGenre}\nRating: {movieRating}");
        }
    }
    
    class Program{
        static void Main(String[] args){
            Movie movie = new Movie("Aladdin", "Fantasy", 6);
            
            movie.displayDetails();
        }
    }
}