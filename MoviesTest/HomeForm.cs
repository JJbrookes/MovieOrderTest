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
    public partial class HomeForm : Form
    {
        
        public HomeForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlMethods n = new MySqlMethods();
            AllMovies AllMovieForm = new AllMovies(this);
            AllMovieForm.Show();
            this.Hide();
            
        }

        private void database_button_Click(object sender, EventArgs e)
        {
            AdminForm f1 = new AdminForm(this);
            this.Hide();
            f1.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void searchMoviesButton_Click(object sender, EventArgs e)
        {
            string title = searchBox.Text;
            if(searchBox.Text == null || searchBox.Text == "")
            {
                MessageBox.Show("Enter a movie title");
            }
            else
            {
                AllMovies allMovies = new AllMovies(this, title);
                this.Hide();
                allMovies.Show();
            }
            
        }
    }
}
