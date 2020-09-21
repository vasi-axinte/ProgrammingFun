using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class UsersRepository
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserDB;Integrated Security=True";

        public void Register(AccountModel user)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string insertUser = "INSERT INTO Users(Email,FirstName,LastName,Password)VALUES(@Email, @FirstName, @LastName, @Password)";
            var insertCommand = new SqlCommand(insertUser, connection);

            connection.Open();
            insertCommand.Parameters.AddWithValue("@Email", user.Email);
            insertCommand.Parameters.AddWithValue("@FirstName", user.FirstName);
            insertCommand.Parameters.AddWithValue("@LastName", user.LastName);
            insertCommand.Parameters.AddWithValue("@Password", user.Password);
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public bool Login(UserLoginCredentials user)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string loginUser = "SELECT * FROM Users WHERE (Email=@Email)AND(Password=@Password)";
            var loginUserCommand = new SqlCommand(loginUser, connection);

            connection.Open();
            loginUserCommand.Parameters.AddWithValue("@Email", user.Email);
            loginUserCommand.Parameters.AddWithValue("@Password", user.Password);
            SqlDataReader readUsers = loginUserCommand.ExecuteReader();
            if (readUsers.Read()) return true;
            else
            {
                return false;
            }
            connection.Close();
        }


    }
}