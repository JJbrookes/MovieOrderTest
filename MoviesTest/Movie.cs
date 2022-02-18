using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTest
{
    public class Movie
    {

        //////////////////////////////////////Attributes//////////////////////////////
        public string? title { get; private set; }
        public List<string>? genres { get; private set; }
        public string? desciption { get; private set; }
        public int length { get; private set; }
        public DateOnly releaseDate { get; private set; }
        public List<string>? directors { get; private set; }
        public List<string>? writers { get; private set; }

        /////////////////////////////////////Constructors////////////////////////////
        public Movie(String Title, DateOnly ReleaseTime)
        {
            this.title = Title;
            this.releaseDate = ReleaseTime;
        }

        public Movie()
        {
            Console.WriteLine("------ADD MOVIES------");
            Console.Write("Enter title: ");
            String title = Console.ReadLine();
            this.title = title;
            GetDate();

            Console.WriteLine(title + " added to system \n\n");

            AddGenres();
            AddDirectors();
            AddWriters();
            AddLength();

        }
        ///////////////////////////////////Methods//////////////////////////////////
        public void AddMovieDetails(List<string> Genres, String Desciption, int Length, List<string> Writers, List<string> Directors)
        {
            this.genres = Genres;
            this.length = Length;
            this.desciption = Desciption;
            this.directors = Directors;
            this.writers = Writers;
        }

        public void GetDate()
        {
            DateOnly dateofrelease;
            Console.Write("enter date of release(00/00/0000): ");
            if (DateOnly.TryParse(Console.ReadLine(), out dateofrelease))
            {
                releaseDate = dateofrelease;

            }else
            {
                GetDate();
            }
            
        }

        public void AddGenres()
            {
            bool done = false;
            List<String> genres = new List<string>();
            do
            {
                Console.Write("Add Genre: ");
                string? userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.Write("Please enter a genre: ");
                    continue;
                }
                genres.Add(userInput);
                Console.Write("Do you want to add another genre(Y or N): ");
                if (!((Console.ReadLine().ToUpper()) == "Y"))
                {
                    done = true;
                }

            } while (!done);
            this.genres = genres;

        }

        public void AddDirectors()
        {
            bool done = false;
            List<String> directors = new List<string>();
            do
            {
                Console.Write("Add Director: ");
                string? userInput = Console.ReadLine();
                if(string.IsNullOrEmpty(userInput)) 
                {
                    Console.Write("Please enter a name: ");
                    continue;
                }
                directors.Add(userInput);
                Console.Write("Do you want to add another Director(Y or N): ");

                if (!(Console.ReadLine().ToUpper() == "Y"))
                {
                    done = true;

                }

            } while (!done);
            this.directors = directors;

        }
        public void AddWriters()
        {
            bool done = false;
            List<String> writers = new List<string>();
            do
            {
                Console.Write("Add Director: ");
                string? userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.Write("Please enter a name: ");
                    continue;
                }
                writers.Add(userInput);
                Console.Write("Do you want to add another Director(Y or N): ");
                if (!(Console.ReadLine().ToUpper() == "Y"))
                {
                    done = true;
                }

            } while (!done);
            this.writers = writers;

        }
        public void AddLength()
        {
            int length = 0; 
            Console.Write("Enter length in minutes: ");
            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Not a valid number");
                Console.Write("Enter length in minutes: ");
            }
            this.length = length;
        }
    }
}