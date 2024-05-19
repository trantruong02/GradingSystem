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
        string id;
        string firstName;
        string lastName; 
        string username;
        string password;
        string email;
        DateTime dateOfBirth;
        string phoneNumber;


        public Teachers(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(string firstName, string lastName, string username, string password, string email, DateTime dateOfBirth, string phoneNumber)
        {
            int result = 0;

            if (SearchUserName(username))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Teachers (ID, FirstName, LastName, Username, Password, Email, DateOfBirth, PhoneNumber) " +
                                   "VALUES (@ID, @FirstName, @LastName, @Username, @Password, @Email, @DateOfBirth, @PhoneNumber)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        this.id = GenerateTeacherID();
                        command.Parameters.AddWithValue("@ID", this.id);
                        this.firstName = firstName;
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        this.lastName = lastName;
                        command.Parameters.AddWithValue("@LastName", lastName);
                        this.username = username;
                        command.Parameters.AddWithValue("@Username", username);
                        this.password = password;
                        command.Parameters.AddWithValue("@Password", password);
                        this.email = email;
                        command.Parameters.AddWithValue("@Email", email);
                        this.dateOfBirth = dateOfBirth;
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        this.phoneNumber = phoneNumber;
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.ExecuteNonQuery();
                        result = command.ExecuteNonQuery();
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
