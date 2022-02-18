using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTest.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            string userName = "James";
            string password = "password";
            string expected = "James";
            Customer customer = new Customer(userName , password);
            Assert.AreEqual(expected, customer.userName, "Username is not expected");

        }


        [TestMethod()]
        public void EditUserTest()
        {
            string userName = "James";
            string newUserName = "Bob";
            string password = "password";
            string expected = "Bob";
            Customer customer = new Customer(userName, password);
            customer.EditUser(newUserName);
            Assert.AreEqual(expected, customer.userName,"Edit name not expected");
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            Assert.Fail();
        }
    }
}