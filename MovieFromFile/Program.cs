using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MovieFromFile
{
    class Program
    {
        class Movie
        {
            string title;
            string rating;
            string year;


            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

            //getters

            public string Title
            {
                get { return title; }
            }

            public string Rating
            {
                get { return rating; }

            }
            public string Year
            {
                get { return year; }
            }


        }
        static void Main(string[] args)
        {
            List<string> movielistFromFile = getMoviesFromFiles().ToList();
            List<Movie> listOfMovies = new List<Movie>();

            foreach(string movieRecord in movielistFromFile)
            {
                string[] tempArray = movieRecord.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);

                listOfMovies.Add(newMovie);
            }
        
            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine($"Title: {movie.Title} - Rating: {movie.Rating} - Year: {movie.Year}");
            }
                  
        }



        public static string[] getMoviesFromFiles()
        {

            string filePath = @"C:\Users\opilane\Samples\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);


            return dataFromFile;
        }
    
        public static void ShowDataFromArray(string[] someArray)
        {
            foreach(string line in someArray)
            {
                Console.WriteLine(line);
            }
        }
    
    }
}

