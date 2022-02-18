using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTest
{
    public class Customer: User
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        List<Order>? orders { get; set; }
        public Customer(string username, string password):  base(username, password)
        {

        }
        public Customer(string username, string password, string FirstName) : this(username, password)
        {

        }

        public override void CreateUser()
        {
            throw new NotImplementedException();
        }
        public override void EditUser(String? userName=null, String? password=null)
        {   if(userName != null)
            {
                this.userName = userName;
            }
            if (password == null)
            {
                this.password = password;
            }
            
        }
        public override void DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}
