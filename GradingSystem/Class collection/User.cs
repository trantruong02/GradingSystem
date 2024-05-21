using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Class_collection
{
    public class User
    {
        protected string connectionString;
        string tableName;

        int Create(
            
            string username,
            string password,
            string email,
            int course_id,
            string role,
            string pfp_pic);
        void Update(
            string username,
            string password,
            string email,
            int course_id,
            string role,
            string pfp_pic);
        void Delete(string id);

        public User(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public User FromRole(string role)
        {
            switch (role)
            {
                case "Teacher":
                    return new Teachers(connectionString);
                case "Student":
                    return new Students(connectionString);
            }
            return null;
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

        }
        //public string GetRoleFromID(string id)
        //{
        //    string? role = "";

        //    using (SqlConnection connection = new(connectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT role FROM Teachers WHERE id = @ID" +
        //                       "UNION " +
        //                       "SELECT role FROM Students WHERE id = @ID";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@ID", id);
        //            SqlDataReader reader = command.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                role = reader["role"].ToString();
        //            }
        //            reader.Close();
        //        }
        //    }

        //    return role ?? "";
        //}

        public int Create(string username, string password, string email, string course_id, string pfp_pic)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.course_id = course_id;
            this.pfp_pic = pfp_pic;

            int result = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO" + tableName + "(ID,  Username, Password, Email, Course_id, Profile_picture)" +
                               "VALUES (@ID, @Username, @Password, @Email, @Course_id, @Profile_picture)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", GenerateID());   
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Course_id", course_id);
                    command.Parameters.AddWithValue("@Profile_picture", pfp_pic);
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

        //private string GenerateID()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT MAX(CAST(SUBSTRING(ID, 3, LEN(ID)) AS INT)) FROM Teachers";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        object result = command.ExecuteScalar();

        //        if (result == DBNull.Value)
        //        {
        //            return "GV101";
        //        }
        //        else
        //        {
        //            int maxID = Convert.ToInt32(result);
        //            return "GV" + (maxID + 1);
        //        }
        //    }
        //}

        public void Update(string id,
            
            string? username = null,
            string? password = null,
            string? email = null,
            string? course_id = null,
            string? pfp_pic = null)
        {
            // MUST have equal length
            bool[] shouldUpdateTheseParams = new bool[7]
            {
                
                username != null, password != null, email != null,
                course_id != null, pfp_pic != null
            };
            string[] paramsToUpdate = new string[7]
            {
                "Username = @Username", "Password = @Password", "Email = @Email",
                "Course_id = @Course_id", "Profile_picture = @Profile_picture"
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
                string query = "UPDATE" + tableName + "SET " + queryBuilder.ToString() + " WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    
                    if (username != null) command.Parameters.AddWithValue("@Username", username);
                    if (password != null) command.Parameters.AddWithValue("@Password", password);
                    if (email != null) command.Parameters.AddWithValue("@Email", email);
                    if (course_id != null) command.Parameters.AddWithValue("@Course_id", course_id);
                    if (pfp_pic != null) command.Parameters.AddWithValue("@Profile_picture", pfp_pic);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM"+ tableName +"WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
