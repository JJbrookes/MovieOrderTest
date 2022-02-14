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
        public List<string>? genres { get; set; }
        public string? desciption { get; private set; }
        public int length { get; private set; }
        public DateOnly releaseDate { get; private set; }
        public List<string>? directors { get; private set; }
        public List<string>? writors { get; private set; }

        /////////////////////////////////////Constructors////////////////////////////
        public Movie(String Title, DateOnly ReleaseTime)
        {
            this.title = Title;
            this.releaseDate = ReleaseTime;
        }

        ///////////////////////////////////Methods//////////////////////////////////
        public void AddMovieDetails(List<string> Genres, String Desciption, int Length, List<string> Writers, List<string> Directors)
        {
            this.genres = Genres;
            this.length = Length;
            this.desciption = Desciption;
            this.directors = Directors;
            this.writors = Writers;
        }
        public void addGenres()
        {
            bool done = false;
            List<String> genres = new List<string>();
            do
            {
                Console.Write("Add Genre: ");
                string? userInput = Console.ReadLine();
                genres.Add(userInput);
                Console.Write("Do you want to add another genre(Y or N): ");
                if (!((Console.ReadLine().ToUpper()) == "Y"))
                {
                    done = true;
                }

            } while (!done);
            this.genres = genres;

        }

    }
}