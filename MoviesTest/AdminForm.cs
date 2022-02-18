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
    public partial class AdminForm : Form
    {
        Form previousForm;
        public AdminForm(Form form)
        {
            InitializeComponent();
            releaseYear.Format = DateTimePickerFormat.Custom;
            this.previousForm = form;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AllMovies AllMovieForm = new AllMovies(this);
            AllMovieForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(0, 1000000);
            Movie1 newMovie = new Movie1(
                id,
                title.Text,
                description.Text,
                ((int)ageRating.Value),
                int.Parse(releaseYear.Value.Year.ToString()),
                ((int)length.Value));
            //string inputtitle = title.text;
            //string inputdesc = description.text;
            //int inputage = ((int)agerating.value);
            //int inputrelease = int.parse(releaseyear.value.year.tostring());
            //int inputlength = ((int)length.value);
            string connetionString = @"Data Source=localhost;Initial Catalog=mydb;User ID=root;Password=root";
            MySqlConnection cnn;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            cnn = new MySqlConnection(connetionString);
            string sql = "INSERT INTO movie (movie_id, title, description, age_rating, release_date , length) values(\""
                + newMovie.id
                + "\", \""
                + newMovie.title
                + "\", \""
                + newMovie.desciption
                + "\","
                + newMovie.age_rating
                + ","
                + newMovie.release_date
                + ","
                + newMovie.length
                + ")";
            cnn.Open();

            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Moive added");


        }

        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            Movie1 newMovie = new Movie1(
                        0,
                        title.Text,
                        description.Text,
                        ((int)ageRating.Value),
                        int.Parse(releaseYear.Value.Year.ToString()),
                        ((int)length.Value));

            MySqlMethods delete = new MySqlMethods();
            delete.DeleteSelected(newMovie);

        }

        //Update with title
        private void button4_Click(object sender, EventArgs e)
        {
            Movie1 newMovie = new Movie1(
                title.Text,
                description.Text,
                ((int)ageRating.Value),
                int.Parse(releaseYear.Value.Year.ToString()),
                ((int)length.Value));

            string connetionString = @"Data Source=localhost;Initial Catalog=mydb;User ID=root;Password=root";
            MySqlConnection cnn;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            cnn = new MySqlConnection(connetionString);
            string sql = "UPDATE movie SET description=\""
                + newMovie.desciption
                + "\", age_rating=\""
                + newMovie.age_rating
                + "\", release_date=\""
                + newMovie.release_date
                + "\", length=\""
                +newMovie.length
                + "\" WHERE title=\""
                + newMovie.title
                + "\"";
            cnn.Open();

            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            cnn.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=mydb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
            cnn.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string title1 = title.Text;
            if (title1 == null || title1 == "")
            {
                MessageBox.Show("Enter a movie title");
            }
            else
            {
                AllMovies allMovies = new AllMovies(this, title1);
                this.Hide();
                allMovies.Show();
            }
        }
    }
}
