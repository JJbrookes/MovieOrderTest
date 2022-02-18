using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MoviesTest
{
    public partial class AllMovies : Form
    {
        List<Movie1> movieList = new List<Movie1>();
        Form previousPage;
        string? title = "";

        public AllMovies(Form previousPage)
        {
            GetAllMoviesFromDB(previousPage); //Populates movielist
            this.previousPage = previousPage;

            InitializeComponent();
            
        }

        public AllMovies(Form previousPage, string title)
        {
            GetAllMoviesFromDB(previousPage); //Populates listview
            this.previousPage = previousPage;
            this.title = title;
            InitializeComponent();
        }
        public AllMovies(Form previousPage, int id)
        {
            GetAllMoviesFromDB(previousPage); //Populates listview
            this.previousPage = previousPage;
            this.title = id;
            InitializeComponent();
        }

        private void AllMovies_Load(object sender, EventArgs e)
        {
            if(previousPage.GetType().ToString() == "MoviesTest.HomeForm")
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                buyButton.Enabled = true;
            }

            if (title != "")
            {
                List<Movie1> searchResult = new List<Movie1>();
                foreach (Movie1 item in movieList)
                {
                    if(item.title.ToLower().Contains(title.ToLower()))
                    {
                        searchResult.Add(item);
                        string[] arr = new string[6];
                        string id = item.id.ToString(); arr[0] = id;
                        string title = item.title.ToString(); arr[1] = title;
                        string descripition = item.desciption.ToString(); arr[2] = descripition;
                        string age_rating = item.age_rating.ToString(); arr[3] = age_rating;
                        string release_date = item.release_date.ToString(); arr[4] = release_date;
                        string length = item.length.ToString(); arr[5] = length;

                        ListViewItem listItem = new ListViewItem(arr);
                        allMoviesListView.Items.Add(listItem);
                    }
                }
            }
            else
            {
                foreach (Movie1 item in movieList)
                {
                    string[] arr = new string[6];
                    string id = item.id.ToString(); arr[0] = id;
                    string title = item.title.ToString(); arr[1] = title;
                    string descripition = item.desciption.ToString(); arr[2] = descripition;
                    string age_rating = item.age_rating.ToString(); arr[3] = age_rating;
                    string release_date = item.release_date.ToString(); arr[4] = release_date;
                    string length = item.length.ToString(); arr[5] = length;


                    //Convert to string 
                    ListViewItem listItem = new ListViewItem(arr);
                    allMoviesListView.Items.Add(listItem);
                }
            }
            allMoviesListView.FullRowSelect = true;
            allMoviesListView.Update();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previousPage.Show();
            this.Close();
        }

        public void GetAllMoviesFromDB(Form previousPage)
        {

            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=mydb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataReader dataReader;
            string sql, output = "";
            sql = "Select movie_id, title, description, age_rating, release_date ,length from movie";
            command = new MySqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            List<Movie1> asd = new List<Movie1>();

            while (dataReader.Read())
            {
                Movie1 movie = new Movie1(
                    (int)(dataReader.GetValue(0)),
                    dataReader.GetValue(1).ToString(),
                    dataReader.GetValue(2).ToString(),
                    (int)(dataReader.GetValue(3)),
                    (int)(dataReader.GetValue(4)),
                    (int)(dataReader.GetValue(5)));
                //output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + "\n";
                movieList.Add(movie);
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

           //Delete selected item
        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem SelectedMovie = allMoviesListView.SelectedItems[0];
            ListViewItem.ListViewSubItemCollection values = SelectedMovie.SubItems;
            int i = 0;
            
            Movie1 movieToBeDeleted = new Movie1();

            movieToBeDeleted.id =int.Parse(values[0].Text);
            movieToBeDeleted.title = values[1].Text;
            movieToBeDeleted.desciption = values[2].Text;
            movieToBeDeleted.age_rating = int.Parse(values[3].Text);
            movieToBeDeleted.release_date = int.Parse(values[4].Text);
            movieToBeDeleted.length = int.Parse(values[5].Text);

            MySqlMethods delete = new MySqlMethods();
            delete.DeleteSelected(movieToBeDeleted);
            allMoviesListView.Items.Remove(SelectedMovie);
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
