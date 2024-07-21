using GradingSystem.Class_collection;
using GradingSystem.frm_Collection;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace GradingSystem
{
    public partial class FrmQuestion : Form
    {
        private int click = 0;
        public FrmQuestion()
        {
            InitializeComponent();
        }


        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            LstQuestion.View = View.Details;
            LstQuestion.GridLines = true;
            LstQuestion.FullRowSelect = true;
            LstQuestion.Columns.Add("ID", 50);
            LstQuestion.Columns.Add("EID", 50);
            LstQuestion.Columns.Add("Content", 321);
            LstQuestion.Columns.Add("A", 100);
            LstQuestion.Columns.Add("B", 100);
            LstQuestion.Columns.Add("C", 100);
            LstQuestion.Columns.Add("D", 100);
            LstQuestion.Columns.Add("Answer", 100);
            LstQuestion.Columns.Add("point", 80);
            LoadQuestion();
        }

        public void LoadQuestion()
        {
            SqlConnection connection = new(Config.ConnectionString);
            connection.Open();
            SqlCommand cmd = new("select * from Questions", connection);
            SqlDataReader da;
            da = cmd.ExecuteReader();
            while (da.Read())
            {
                var item1 = LstQuestion.Items.Add(da[0].ToString());
                item1.SubItems.Add(da[1].ToString());
                item1.SubItems.Add(da[2].ToString());
                item1.SubItems.Add(da[3].ToString());
                item1.SubItems.Add(da[4].ToString());
                item1.SubItems.Add(da[5].ToString());
                item1.SubItems.Add(da[6].ToString());
                item1.SubItems.Add(da[7].ToString());
                item1.SubItems.Add(da[8].ToString());
            }
            connection.Close();
        }

        private static int questionCount()
        {
            int count = 0;
            string query = "SELECT COUNT(question_id) FROM Questions";

            try
            {
                using (SqlConnection connection = new(Config.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new(query, connection))
                    {
                        // Use ExecuteScalar for single value result
                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return count;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            QuestionDetails create = new();
            create.addButton.BringToFront();
            create.label1.Visible = false;
            create.questionID.Visible = false;
            create.examID.ReadOnly = false;
            create.pointTxt.ReadOnly = false;
            create.QuestionContent.ReadOnly = false;
            create.OptionATxt.ReadOnly = false;
            create.OptionBTxt.ReadOnly = false;
            create.OptionCTxt.ReadOnly = false;
            create.OptionDTxt.ReadOnly = false;
            create.OptionA.Visible = true;
            create.OptionB.Visible = true;
            create.OptionC.Visible = true;
            create.OptionD.Visible = true;
            create.Show();
        }

        private void CheckAnswer(Guna2TextBox guna, string answer)
        {
            int result = guna.Text.CompareTo(answer);
            if (result == 0)
            {
                guna.BorderColor = Color.FromName("DarkGray");
                guna.FillColor = Color.FromArgb(177, 175, 255);
            }
        }

        private void LstQuestion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            QuestionDetails details = new();
            details.questionID.Text = LstQuestion.SelectedItems[0].Text;
            details.examID.Text = LstQuestion.SelectedItems[0].SubItems[1].Text;
            details.QuestionContent.Text = LstQuestion.SelectedItems[0].SubItems[2].Text;
            details.OptionATxt.Text = LstQuestion.SelectedItems[0].SubItems[3].Text;
            details.OptionBTxt.Text = LstQuestion.SelectedItems[0].SubItems[4].Text;
            details.OptionCTxt.Text = LstQuestion.SelectedItems[0].SubItems[5].Text;
            details.OptionDTxt.Text = LstQuestion.SelectedItems[0].SubItems[6].Text;
            string answer = LstQuestion.SelectedItems[0].SubItems[7].Text;
            details.pointTxt.Text = LstQuestion.SelectedItems[0].SubItems[8].Text;

            CheckAnswer(details.OptionATxt, answer);
            CheckAnswer(details.OptionBTxt, answer);
            CheckAnswer(details.OptionCTxt, answer);
            CheckAnswer(details.OptionDTxt, answer);
            details.Show();
        }

        private void LstQuestion_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = LstQuestion.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void Delete()
        {
            SqlConnection conn = new(Config.ConnectionString);
            conn.Open();
            string query = "delete Questions where question_id = @id";
            SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(searchBox.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string data = searchBox.Text;

            UpdateListView(data);
        }

        private void UpdateListView(string data)
        {
            // Clear the existing items in the ListView
            LstQuestion.Items.Clear();

            // Query the database
            using (SqlConnection conn = new(Config.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Questions WHERE QuestionText LIKE @searchText";

                using (SqlCommand cmd = new(query, conn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@searchText", "%" + data + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a ListViewItem and add it to the ListView
                            System.Windows.Forms.ListViewItem item = new(reader["question_id"].ToString());
                            item.SubItems.Add(reader["exam_id"].ToString());
                            item.SubItems.Add(reader["QuestionText"].ToString());
                            item.SubItems.Add(reader["Option1"].ToString());
                            item.SubItems.Add(reader["Option2"].ToString());
                            item.SubItems.Add(reader["Option3"].ToString());
                            item.SubItems.Add(reader["Option4"].ToString());
                            item.SubItems.Add(reader["correct_answer"].ToString());
                            item.SubItems.Add(reader["point"].ToString());

                            LstQuestion.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

            click++;
            switch (click)
            {
                case 1:
                    sortData("ASC");
                    break;
                case 2:
                    sortData("DESC");
                    click = 0;
                    break;
                default:
                    break;
            }
        }

        private void sortData(string types)
        {
            LstQuestion.Items.Clear();

            // Query the database
            using (SqlConnection conn = new(Config.ConnectionString))
            {
                conn.Open();
                string query = $"select * from Questions order by (QuestionText) {types}";

                using (SqlCommand cmd = new(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a ListViewItem and add it to the ListView
                            System.Windows.Forms.ListViewItem item = new(reader["question_id"].ToString());
                            item.SubItems.Add(reader["exam_id"].ToString());
                            item.SubItems.Add(reader["QuestionText"].ToString());
                            item.SubItems.Add(reader["Option1"].ToString());
                            item.SubItems.Add(reader["Option2"].ToString());
                            item.SubItems.Add(reader["Option3"].ToString());
                            item.SubItems.Add(reader["Option4"].ToString());
                            item.SubItems.Add(reader["correct_answer"].ToString());
                            item.SubItems.Add(reader["point"].ToString());

                            LstQuestion.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
