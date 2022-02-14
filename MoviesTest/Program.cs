namespace MoviesTest;
public class program
{
    public static void Main(string[] args)
    {

        List<Movie> movies = PopulateMovies();
        int choice;
        Console.WriteLine("Welcome to MovieMagic");
        Console.WriteLine("We offer movie searching and purchesing");
        Console.WriteLine("Would you like to search for a Film(1)");
        Console.WriteLine("Would you like to explore genres(2)");
        Console.WriteLine("Would you like to view all Movies(3)");
        Console.WriteLine("Admin Only: Add movie(4)");
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
                foreach(Movie movie in movies)
                {
                    Console.WriteLine(movie.title);
                    Console.WriteLine(movie.desciption);
                    Console.WriteLine(movie.releaseDate.ToShortDateString());
                    Console.WriteLine();
                }
                break;
            case 4:
                AddMovie(movies);
                break;
            default:
                break;
        }

       
    }
    private static List<Movie> AddMovie(List<Movie> movies)
    {
        Console.WriteLine("------ADD MOVIES------");
        Console.WriteLine("Enter title: ");
        String title = Console.ReadLine();
        Console.WriteLine("Enter date of release: ");
      //  DateOnly dateOfRelease = GetDate();

        Movie newMovie = new Movie(title, new DateOnly());

//        List<String> genres = createGenre();
        Console.WriteLine(": ");
        Console.WriteLine("Enter title: ");

        List<string>? catogories = new List<string>();
        DateOnly date1 = new DateOnly(2011, 12, 25);
        DateOnly date2 = new DateOnly(2012, 12, 25);
        DateOnly date3 = new DateOnly(1899, 12, 25);
        DateOnly date4 = new DateOnly(2064, 12, 25);

        Movie movie1 = new Movie("Texas Chainsaw Picnic", date1);
        movie1.AddMovieDetails(catogories, "Avid picnic go-er", 2, catogories, catogories);
        movies.Add(movie1);
        Movie movie2 = new Movie("Sleepless In Birmingham", date2);
        movie2.AddMovieDetails(catogories, "The Love stroy of a pigeon and a local drunk", 2, catogories, catogories);
        movies.Add(movie2);
        Movie movie3 = new Movie("Texas Chainsaw Picnic", date3);
        movie3.AddMovieDetails(catogories, "Avid picnic go-er", 2, catogories, catogories);
        movies.Add(movie3);
        Movie movie4 = new Movie("Texas Chainsaw Picnic", date4);
        movie4.AddMovieDetails(catogories, "Avid picnic go-er", 2, catogories, catogories);
        movies.Add(movie4);

        //  
        // Movie movie = new Movie("",);
        return movies;


    }

    private static List<Movie> PopulateMovies()
    {
        List<Movie> movies = new List<Movie>();  
        List<string>? catogories = new List<string>();
        DateOnly date1 = new DateOnly(2011, 12, 25);
        DateOnly date2 = new DateOnly(2012, 12, 25);
        DateOnly date3 = new DateOnly(1899, 12, 25);
        DateOnly date4 = new DateOnly(2064, 12, 25);
        
        Movie movie1 = new Movie("Texas Chainsaw Picnic", date1);
        movie1.AddMovieDetails(catogories,"Avid picnic go-er",2,catogories,catogories);
        movies.Add(movie1);
        Movie movie2 = new Movie("Sleepless In Birmingham", date2);
        movie2.AddMovieDetails(catogories, "The Love stroy of a pigeon and a local drunk", 2, catogories, catogories);
        movies.Add(movie2);
        Movie movie3 = new Movie("Texas Chainsaw Picnic", date3);
        movie3.AddMovieDetails(catogories, "Avid picnic go-er", 2, catogories, catogories);
        movies.Add(movie3);
        Movie movie4 = new Movie("Texas Chainsaw Picnic", date4);
        movie4.AddMovieDetails(catogories, "Avid picnic go-er", 2, catogories, catogories);
        movies.Add(movie4);

        //  
        // Movie movie = new Movie("",);
        return movies;
        

    }
    public List<string> createGenre(Movie movie)
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
        return genres;
    }

    //public DateOnly GetDate()
    //{
    //    DateOnly dateOfRelease;
    //    Console.WriteLine("Enter date of release(00/00/0000): ");
    //    if(DateOnly.TryParse(Console.ReadLine(), out dateOfRelease)){
    //        Console.WriteLine("");
    //    }
    //    return new DateTime();
    //}
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
