using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTest
{
    public abstract class User
    {
        public string userName { get; set; }
        public string password { get; set; }

        public User(string UserName, string password)
        {
            this.userName = UserName;
            this.password = password;
        }

        public abstract void CreateUser();

        public abstract void DeleteUser();

        public abstract void EditUser();
    }

}
