using GradingSystem.frm_Collection;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GradingSystem
{
    public partial class FrmQuestion : Form
    {
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

        private void LoadQuestion()
        {
            SqlConnection connection = new("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True");
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            QuestionDetails create = new();
            string content = create.QuestionContent.Text;
            string optionA = create.OptionATxt.Text;
            string optionB = create.OptionBTxt.Text;
            string optionC = create.OptionCTxt.Text;
            string optionD = create.OptionDTxt.Text;
            float point = float.Parse(create.pointTxt.Text);
            bool isAnyTextboxEmpty = false;

            isAnyTextboxEmpty |= CheckandChange(create.QuestionContent);
            isAnyTextboxEmpty |= CheckandChange(create.OptionATxt);
            isAnyTextboxEmpty |= CheckandChange(create.OptionBTxt);
            isAnyTextboxEmpty |= CheckandChange(create.OptionCTxt);
            isAnyTextboxEmpty |= CheckandChange(create.OptionDTxt);
            isAnyTextboxEmpty |= CheckandChange(create.pointTxt);

            if (isAnyTextboxEmpty) { return; }

            using (SqlConnection con = new("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                string query = " insert into Questions (exam_id, QuestionText, Option1, Option2,Option3, Option4, correct_answer, point) values (@examID, @content, @option1, @option2, @option3, @option4, @answer, @point)";

                using (SqlCommand cmd = new(query, con))
                {
                    cmd.Parameters.AddWithValue("@examID", examID);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@option1", optionA);
                    cmd.Parameters.AddWithValue("@option2", optionB);
                    cmd.Parameters.AddWithValue("@option3", optionC);
                    cmd.Parameters.AddWithValue("@option4", optionD);                    
                    cmd.Parameters.AddWithValue("@point", point);

                    // thuc thi truy van 
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Added");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
            }
        }

        private void LstQuestion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            QuestionDetails details = new();
            details.QuestionContent.Text = LstQuestion.SelectedItems[0].SubItems[2].Text;
            details.OptionATxt.Text = LstQuestion.SelectedItems[0].SubItems[3].Text;
            details.OptionBTxt.Text = LstQuestion.SelectedItems[0].SubItems[4].Text;
            details.OptionCTxt.Text = LstQuestion.SelectedItems[0].SubItems[5].Text;
            details.OptionDTxt.Text = LstQuestion.SelectedItems[0].SubItems[6].Text;
            details.OptionATxt.Text = LstQuestion.SelectedItems[0].SubItems[7].Text;
            details.pointTxt.Text = LstQuestion.SelectedItems[0].SubItems[8].Text;
            details.Show();
            
        }

        private void LstQuestion_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var focusedItem = LstQuestion.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
