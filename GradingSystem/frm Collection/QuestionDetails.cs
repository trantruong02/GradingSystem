using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem.frm_Collection
{
    public partial class QuestionDetails : Form
    {
        public QuestionDetails()
        {
            InitializeComponent();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            saveButton.BringToFront();
            QuestionContent.Modified = true;
            OptionATxt.Modified = true;
            OptionBTxt.Modified = true;
            OptionCTxt.Modified = true;
            OptionDTxt.Modified = true;
            pointTxt.Modified = true;

            SqlConnection connection = new("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True");
            connection.Open();
            SqlCommand cmd = new("update Questions set QuestionText = @QuestionContent, Option1 = @optionA, Option2 = @optionB, Option3 = @optionC, Option4 = @optionD, correct_answer = @answer, point = @point", connection);

            connection.Close();
        }
    }
}
