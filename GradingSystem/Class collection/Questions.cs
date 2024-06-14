using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GradingSystem.Class_collection
{
    public class Questions
    {
        private string question;
        private string optionA;
        private string optionB;
        private string optionC;
        private string optionD;
        private string answer;
        private string score;
        private string connectionString;
        public Questions(string Connection)
        {
            this.connectionString = Connection;
        }

        public int create_question(string content, string optionA, string optionB, string optionC, string optionD, string Answer, string Point)
        {
            int result = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "insert into Questions values @QuestionText, @Option1, @Option2, @Option3, @Option4, @correct_answer, @point";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@QuestionText", content);
                    command.Parameters.AddWithValue("@Option1", content);
                    command.Parameters.AddWithValue("@Option2", content);
                    command.Parameters.AddWithValue("@Option3", content);
                    command.Parameters.AddWithValue("@Option4", content);
                    command.Parameters.AddWithValue("@correct_answer", content);
                    command.Parameters.AddWithValue("@point", content);

                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}
