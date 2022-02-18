using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MoviesTest
{
    public class MySqlMethods
    {
        public void DeleteSelected(Movie1 newMovie)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=mydb;User ID=root;Password=root";
            MySqlConnection cnn;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            cnn = new MySqlConnection(connetionString);
            string sql = "DELETE FROM movie WHERE movie_id = \"" + newMovie.id + "\"";
            cnn.Open();
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Movie Deleted");


        }
    }
}
