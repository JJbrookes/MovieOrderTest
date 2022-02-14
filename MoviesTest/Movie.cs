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
        public List<string>? catogories { get; private set; }
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
        public void AddMovieDetails(List<string> Catogories, String Desciption, int Length, List<string> Writers, List<string> Directors)
        {
            this.catogories = Catogories;
            this.length = Length;
            this.desciption = Desciption;
            this.directors = Directors;
            this.writors = Writers;
        }

    }
}