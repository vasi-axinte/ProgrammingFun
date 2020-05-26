using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Single_Responsability_Principle
{
    /// <summary>
    /// User class performs ONLY user related tasks/responsabilites
    /// </summary>
    public class User
    {
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public void LoginUser()
        {
            Console.WriteLine("{0} has logged in!", Username);
        }

        public void Register()
        {
            Console.WriteLine("{0} has been added to our database", Username);
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}