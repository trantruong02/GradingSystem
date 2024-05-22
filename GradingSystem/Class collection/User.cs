using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;


namespace GradingSystem.Class_collection
{
    public class User
    {
        protected string connectionString;

        public User(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IUser? FromRole(string role)
        {
            switch (role)
            {
                case "teacher":
                    return new Teacher(connectionString);
                case "student":
                    return new Student(connectionString);
            }
            return null;
        }

        public string GetRoleFromUsername(string username)
        {
            string? role = "";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                string query = "select role from Users where username = @username";
                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        role = reader["role"].ToString();
                    }
                    reader.Close();
                }
            }

            return role ?? "";
        }

        /*public int Create(string username, string password, string email)
        {
            int result = 0;

            if (SearchUserName(username))
            {
                using (SqlConnection connection = new (connectionString))
                {
                    connection.Open();
                    string query = "insert into Users (username, password, email, role) values (@username, @password, @email, @role)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        this.username = username;
                        command.Parameters.AddWithValue("@username", username);
                        this.password = password;
                        command.Parameters.AddWithValue("@password", password);
                        this.email = email;
                        command.Parameters.AddWithValue("@email", email);

                        result = command.ExecuteNonQuery();

                        if (result == 1)
                        {
                            MessageBox.Show("Sign up success");
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed");
                        }
                    }
                }
            }


            return result;
        }

        public bool SearchUserName(string username)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query = "SELECT Teachers WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        Console.WriteLine("username already exist, choose another one");
                        return false;

                    }



                }
                return true;

            }

            return false;

        }

        public void Update(string id, string firstName, string lastName, string username, string password, string email, DateTime dateOfBirth, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Teachers SET FirstName = @FirstName, LastName = @LastName, Username = @Username, Password = @Password, " +
                               "Email = @Email, DateOfBirth = @DateOfBirth, PhoneNumber = @PhoneNumber WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Teachers WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
        }*/
    }
}
