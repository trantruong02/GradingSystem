using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Microsoft.Data.SqlClient;


namespace GradingSystem.Class_collection
{
    public class Teachers
    {
        private string connectionString;

        public Teachers(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(string firstName, string lastName, string username, string password, string email, DateTime dateOfBirth, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Teachers (ID, FirstName, LastName, Username, Password, Email, DateOfBirth, PhoneNumber) " +
                               "VALUES (@ID, @FirstName, @LastName, @Username, @Password, @Email, @DateOfBirth, @PhoneNumber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", GenerateTeacherID());
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
        }

        private string GenerateTeacherID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(CAST(SUBSTRING(ID, 3, LEN(ID)) AS INT)) FROM Teachers";
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                if (result == DBNull.Value)
                {
                    return "GV101";
                }
                else
                {
                    int maxID = Convert.ToInt32(result);
                    return "GV" + (maxID + 1);
                }
            }
        }
    }
}
