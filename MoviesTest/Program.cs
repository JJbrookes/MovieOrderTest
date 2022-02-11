namespace MoviesTest;
public class program
{
    public static void Main(string[] args)
    {

        AddMovies();
        int choice;
        Console.WriteLine("Welcome to MovieMagic");
        Console.WriteLine("We offer movie searching and purchesing");
        Console.WriteLine("Would you like to search for a Film(1)");
        Console.WriteLine("Would you like to explore genres(2)");
        Console.WriteLine("Would you like to view all Movies(3)");
        choice = IntInputVaildation(": ");
        switch (choice)
        {
            case 1:
                //SearchFilms();
                break;
            case 2:
                //ExploreGenres();
                break;
            default:
                break;
        }

       
    }


    private static List<Movie> AddMovies()
    {
        List<string>? catogories = new List<string>();
        DateTime date1 = new DateTime(2011, 12, 25);
        DateTime date2 = new DateTime(2012, 12, 25);
        DateTime date3 = new DateTime(1899, 12, 25);
        DateTime date4 = new DateTime(2064, 12, 25);
        
        Movie movie1 = new Movie("Texas Chainsaw Picnic", date1);
        movie1.AddMovieDetails(catogories,"Avid picnic go-er",2,catogories,catogories);
        Movie movie2 = new Movie("Texas Chainsaw Picnic", date2);
        movie2.AddMovieDetails(catogories);
        Movie movie3 = new Movie("Texas Chainsaw Picnic", date3);
        movie3.AddMovieDetails(catogories);
        Movie movie4 = new Movie("Texas Chainsaw Picnic", date4);
        movie4.AddMovieDetails(catogories);

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
            string userInput = Console.ReadLine();
            genres.Add(userInput);
            Console.Write("Do you want to add another genre(Y or N): ");
            if (!((Console.ReadLine().ToUpper()) == "Y"))
            {
                done = true;
            }

        } while (!done);
        return genres;
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
