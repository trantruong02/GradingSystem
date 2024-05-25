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

        private string GetEntryFromUsername(string entry, string username)
        {
            string? entryData = "";
            entry = entry.ToLower();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                string query = "select " + entry + " from Users where username = @username";
                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        entryData = reader[entry].ToString();
                    }
                    reader.Close();
                }
            }

            return entryData ?? "";
        }

        public string GetIdFromUsername(string username)
        {
            return GetEntryFromUsername("user_id", username);
        }

        public string GetRoleFromUsername(string username)
        {
            return GetEntryFromUsername("role", username);
        }

        public string GetEmailFromUsername(string username)
        {
            return GetEntryFromUsername("email", username);
        }

        public bool Update(string userId, string? username = null, string? password = null, string? email = null)
        {
            // MUST have equal length
            bool[] shouldUpdateTheseParams = new bool[3]
            {
                username != null, password != null, email != null
            };
            string[] paramsToUpdate = new string[3]
            {
                "username = @username", "password = @password", "email = @email"
            };

            StringBuilder queryBuilder = new StringBuilder();
            string separator = "";
            for (int i = 0; i < shouldUpdateTheseParams.Length; i++)
            {
                bool shouldUpdate = shouldUpdateTheseParams[i];
                if (shouldUpdate)
                {
                    queryBuilder.Append(separator);
                    queryBuilder.Append(paramsToUpdate[i]);
                    separator = ", ";
                }
            }

            if (queryBuilder.Length > 0)
            {
                int result = 0;
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    string query = "update Users set " + queryBuilder.ToString() + " where user_id = @ID";
                    using (SqlCommand command = new(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", userId);
                        if (username != null) command.Parameters.AddWithValue("@username", username);
                        if (password != null) command.Parameters.AddWithValue("@password", password);
                        if (email != null) command.Parameters.AddWithValue("@email", email);
                        result = command.ExecuteNonQuery();
                    }
                }

                if (result == 1) return true;
            } else
            {
                Console.WriteLine("A User.Update() method was called with no parameters. Nothing was updated.");
            }
            return false;
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
