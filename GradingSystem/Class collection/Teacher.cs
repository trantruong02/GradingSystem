using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Class_collection
{
    public class Teacher : IUser
    {
        private string connectionString;

        public Teacher(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(string username, string password, string email, string role)
        {
            int result = 0;
            using (SqlConnection connection = new (connectionString))
            {
                connection.Open();
                string query = "insert into Users (username, password, emaail, role) where username = @username and password = @password and email = @email and role = @role";
                using (SqlCommand command = new (query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@role", role);
                    
                    // thuc thi truy van 
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

            using (SqlConnection connection = new (connectionString))
            {
                connection.Open();
                string query = "update Users set " + queryBuilder.ToString() + " where ID = @ID";
                using (SqlCommand command = new (query, connection))
                {
                    if (username != null) command.Parameters.AddWithValue("@username", username);
                    if (password != null) command.Parameters.AddWithValue("@password", password);
                    if (email != null) command.Parameters.AddWithValue("@email", email);
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
        }
    }
}
