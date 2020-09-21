using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class UserLoginCredentials
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public UserLoginCredentials(string email, string passowrd)
        {
            this.Email = email;
            this.Password = Password;
        }
    }
}