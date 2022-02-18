namespace MoviesTest;
public class program
{
    public static void Main(string[] args)
    {
        Application.Run(new HomeForm());
        Console.WriteLine("Welcome to MovieMagic");
        Console.WriteLine("We offer movie searching and purchesing");
        List<Movie> movies = new List<Movie>();
        movies = PopulateMovies(movies);
        bool done = false;
        do
        {

            int choice;

            Console.WriteLine("Would you like to search for a Film(1)");
            Console.WriteLine("Would you like to explore genres(2)");
            Console.WriteLine("Would you like to view all Movies(3)");
            Console.WriteLine("Admin Only: Add movie(4)");
            Console.WriteLine("Exit(0)");
            choice = IntInputVaildation(": ");
            switch (choice)
            {
                case 1:
                    //SearchFilms();
                    break;
                case 2:
                    //ExploreGenres();
                    break;
                case 3:
                    foreach (Movie movie in movies)
                    {
                        Console.WriteLine(movie.title);
                        Console.WriteLine(movie.desciption);
                        Console.WriteLine(movie.releaseDate.ToShortDateString());
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    Movie newMovie = new Movie();
                    movies.Add(newMovie);
                    foreach(Movie movie in movies)
                    {
                        Console.WriteLine(movie);
                        Console.WriteLine();   
                    }
                    break;
                case 0:
                    done = true;
                    break;
                default:
                    break;
            }
            Console.WriteLine("");
        }while (!done);

       
    }


    private static List<Movie> PopulateMovies(List<Movie> movies)
    {
        List<string>? genres = new List<string>();
        DateOnly date1 = new DateOnly(2011, 12, 25);
        DateOnly date2 = new DateOnly(2012, 12, 25);
        DateOnly date3 = new DateOnly(1899, 12, 25);
        DateOnly date4 = new DateOnly(2064, 12, 25);
        
        Movie movie1 = new Movie("Texas Chainsaw Picnic", date1);
        movie1.AddMovieDetails(genres,"Avid picnic go-er",2,genres,genres);
        movies.Add(movie1);
        Movie movie2 = new Movie("Sleepless In Birmingham", date2);
        movie2.AddMovieDetails(genres, "The Love stroy of a pigeon and a local drunk", 2, genres, genres);
        movies.Add(movie2);
        Movie movie3 = new Movie("Texas Chainsaw Picnic", date3);
        movie3.AddMovieDetails(genres, "Avid picnic go-er", 2, genres, genres);
        movies.Add(movie3);
        Movie movie4 = new Movie("Texas Chainsaw Picnic", date4);
        movie4.AddMovieDetails(genres, "Avid picnic go-er", 2, genres, genres);
        movies.Add(movie4);

        //  
        // Movie movie = new Movie("",);
        return movies;      
    }
    private static int IntInputVaildation(String message)
    {
        int result = 0;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Not a valid number");
            Console.Write(message);
        }
        return result;
    }
}
