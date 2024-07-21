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
        private string connectionString;

        public string examID {  get; set; }
        public string Content { get; set; }
        public string optionA { get; set; }
        public string optionB { get; set; }
        public string optionC { get; set; }
        public string optionD { get; set; }
        public string answer { get; set; }
        public string point { get; set; }

        public Questions(string Connection)
        {
            this.connectionString = Connection;
        }

        public Questions(string connectionString, string examID, string content, string optionA, string optionB, string optionC, string optionD, string answer, string point) : this(connectionString)
        {
            this.examID = examID;
            Content = content;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.answer = answer;
            this.point = point;
        }

        public int create_question(string examID, string content, string optionA, string optionB, string optionC, string optionD, string Answer, string Point)
        {
            int result = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "insert into Questions (exam_id, QuestionText, Option1, Option2, Option3, Option4, correct_answer, point) values @examID, @QuestionText, @Option1, @Option2, @Option3, @Option4, @correct_answer, @point";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@examID", examID);
                    command.Parameters.AddWithValue("@QuestionText", content);
                    command.Parameters.AddWithValue("@Option1", optionA);
                    command.Parameters.AddWithValue("@Option2", optionB);
                    command.Parameters.AddWithValue("@Option3", optionC);
                    command.Parameters.AddWithValue("@Option4", optionD);
                    command.Parameters.AddWithValue("@correct_answer", Answer);
                    command.Parameters.AddWithValue("@point", content);

                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}
