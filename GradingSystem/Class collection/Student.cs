using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Class_collection
{
    public class Student : IUser
    {
        private string connectionString;

        public Student(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(string username, string password, string email, string role)
        {
            int result = 0;
            using (SqlConnection connection = new (connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Student (ID, FirstName, LastName, Username, Password, Email, DateOfBirth, PhoneNumber) " +
                               "VALUES (@ID, @FirstName, @LastName, @Username, @Password, @Email, @DateOfBirth, @PhoneNumber)";
                using (SqlCommand command = new (query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }

        public void Update(string? username = null, string? password = null, string? email = null)
        {
            // MUST have equal length
            bool[] shouldUpdateTheseParams = new bool[3]
            {
                username != null, password != null, email != null
            };
            string[] paramsToUpdate = new string[3]
            {
                "username = @Username", "Password = @Password", "Email = @Email"
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Students SET " + queryBuilder.ToString() + " WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (username != null) command.Parameters.AddWithValue("@Username", username);
                    if (password != null) command.Parameters.AddWithValue("@Password", password);
                    if (email != null) command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Students WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
