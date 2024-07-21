using GradingSystem.Class_collection;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using Tulpep.NotificationWindow;
using System.Security.Cryptography;

namespace GradingSystem.frm_Collection
{
    public partial class QuestionDetails : Form
    {
        public QuestionDetails()
        {
            InitializeComponent();
        }

        private FrmQuestion _mainform;

        public QuestionDetails(FrmQuestion mainform)
        {
            InitializeComponent();
            _mainform = mainform;
        }
        private void ResetColor(Guna2TextBox textBox) { textBox.FillColor = Color.White; }

        private void editButton_Click(object sender, EventArgs e)
        {
            saveButton.BringToFront();
            examID.ReadOnly = false;
            pointTxt.ReadOnly = false;
            QuestionContent.ReadOnly = false;
            OptionATxt.ReadOnly = false;
            OptionBTxt.ReadOnly = false;
            OptionCTxt.ReadOnly = false;
            OptionDTxt.ReadOnly = false;
            OptionA.Visible = true;
            OptionB.Visible = true;
            OptionC.Visible = true;
            OptionD.Visible = true;
            ResetColor(OptionATxt);
            ResetColor(OptionBTxt);
            ResetColor(OptionCTxt);
            ResetColor(OptionDTxt);
        }

        private static bool IsTextboxEmpty(Guna2TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        private bool CheckandChange(Guna2TextBox textBox)
        {
            if (IsTextboxEmpty(textBox))
            {
                ChangeBorder(textBox);
                return true;
            }
            return false;
        }

        private static void ChangeBorder(Guna2TextBox textBox)
        {
            textBox.BorderColor = Color.FromArgb(243, 36, 36);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string QID = questionID.Text;
            string EID = examID.Text;
            string point = pointTxt.Text;
            string question = QuestionContent.Text;
            string A = OptionATxt.Text;
            string B = OptionBTxt.Text;
            string C = OptionCTxt.Text;
            string D = OptionDTxt.Text;

            using (SqlConnection conn = new(Config.ConnectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create the SQL command
                    string query = "UPDATE Questions SET QuestionText = @questionText WHERE question_id = @QID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters with the appropriate values
                        cmd.Parameters.AddWithValue("@questionText", question);
                        cmd.Parameters.AddWithValue("@QID", QID);

                        // Execute the command
                        int result = cmd.ExecuteNonQuery();

                        // Check if the update was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Question updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Question not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private string GetSelectedRadioButtonText()
        {
            if (OptionA.Checked)
            {
                return OptionATxt.Text;
            } 
            else if (OptionB.Checked)
            {
                return OptionBTxt.Text;
            }
            else if (OptionC.Checked)
            {
                return OptionCTxt.Text;
            } else
            {
                return OptionDTxt.Text;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string eID = examID.Text;
            string content = QuestionContent.Text;
            string optionA = OptionATxt.Text;
            string optionB = OptionBTxt.Text;
            string optionC = OptionCTxt.Text;
            string optionD = OptionDTxt.Text;
            float point = float.Parse(pointTxt.Text);
            bool isAnyTextboxEmpty = false;

            isAnyTextboxEmpty |= CheckandChange(QuestionContent);
            isAnyTextboxEmpty |= CheckandChange(OptionATxt);
            isAnyTextboxEmpty |= CheckandChange(OptionBTxt);
            isAnyTextboxEmpty |= CheckandChange(OptionCTxt);
            isAnyTextboxEmpty |= CheckandChange(OptionDTxt);
            isAnyTextboxEmpty |= CheckandChange(pointTxt);

            string answer = GetSelectedRadioButtonText();


            if (isAnyTextboxEmpty) { return; }

            using (SqlConnection conn = new(Config.ConnectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create the SQL command
                    string query = "insert into Questions (exam_id, QuestionText, Option1, Option2,Option3, Option4, correct_answer, point) values (@EID, @content, @A, @B, @C, @D, @answer, @point)";
                    using (SqlCommand cmd = new (query, conn))
                    {
                        // Add parameters with the appropriate values
                        cmd.Parameters.AddWithValue("@EID", eID);
                        cmd.Parameters.AddWithValue("@content", content);
                        cmd.Parameters.AddWithValue("@A", optionA);
                        cmd.Parameters.AddWithValue("@B", optionB);
                        cmd.Parameters.AddWithValue("@C", optionC);
                        cmd.Parameters.AddWithValue("@D", optionD);
                        cmd.Parameters.AddWithValue("@answer", answer);
                        cmd.Parameters.AddWithValue("@point", point);


                        // Execute the command
                        int result = cmd.ExecuteNonQuery();

                        // Check if the update was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Question updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Question not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            editButton.BringToFront();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
