using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTest
{
    public abstract class Movie
    {

        //////////////////////////////////////Attributes//////////////////////////////
        public string? title { get; set; }
        public List<string>? catogories { get; set; }
        public string? desciption { get; set; }
        public TimeOnly length { get; set; }
        public DateTime releaseDate { get; set; }
        public List<string>? directors { get; set; }
        public List<string>? writors { get; set; }

        /////////////////////////////////////Constructors////////////////////////////
        public Movie(String Title, DateTime ReleaseTime, List<string> Catorgories)
        {
            this.title = Title;
            this.catogories = Catorgories;
            this.releaseDate = ReleaseTime;
        }

        ///////////////////////////////////Methods//////////////////////////////////
        public void AddMovieDetails(String Title, List<string> Catogories, String Desciption, TimeOnly Length, DateTime ReleaseDate, List<string> Writers, List<string> Directors)
        {
            this.length = Length;
            this.desciption = Desciption;
            this.releaseDate = ReleaseDate;
            this.directors = Directors;
            this.writors = Writers;
        }

    }
}