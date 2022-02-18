using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTest
{
    public class Movie1
    {

        //////////////////////////////////////Attributes//////////////////////////////
        public int id { get; set; }
        public string? title { get;  set; }

        //public List<string>? genres { get; private set; }
        public string? desciption { get;  set; }
        public int age_rating { get;  set; }
        public int release_date { get;  set; }
        public int length { get;  set; }


        //  public DateOnly releaseDate { get; private set; }
        //public List<string>? directors { get; private set; }
        //public List<string>? writers { get; private set; }

        /////////////////////////////////////Constructors////////////////////////////
        public Movie1(int id, String Title, string desciption, int age_rating, int release_date, int length)
        {
            this.id = id;
            this.title = Title;
            this.desciption = desciption;
            this.age_rating = age_rating;
            this.release_date = release_date;
            this.length = length;
        }
        public Movie1( String Title, string desciption, int age_rating, int release_date, int length)
        {
            Random rnd = new Random();
            int id = rnd.Next(0, 1000000);

            this.id = id;
            this.title = Title;
            this.desciption = desciption;
            this.age_rating = age_rating;
            this.release_date = release_date;
            this.length = length;
        }
        public Movie1()
        {
            Random rnd = new Random();
            int id = rnd.Next(0, 1000000);
            this.id = id;
        }
    }
}