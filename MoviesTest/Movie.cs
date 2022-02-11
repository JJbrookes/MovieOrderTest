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
        public string? title { get; set; }
        public List<string>? catogories { get; set; }
        public string? desciption { get; set; }
        public int length { get; set; }
        public DateTime releaseDate { get; set; }
        public List<string>? directors { get; set; }
        public List<string>? writors { get; set; }

        /////////////////////////////////////Constructors////////////////////////////
        public Movie(String Title, DateTime ReleaseTime)
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