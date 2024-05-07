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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;

namespace GradingSystem.frm_Collection
{
    public partial class frmForgotPw : Form
    {
        public frmForgotPw()
        {
            InitializeComponent();
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new();
            loginForm.ShowDialog();
            this.Close();
        }
        private bool IsTextboxEmpty(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string NewPw = NpwTxt.Text;
            string ConfirmPassword = CpwTxt.Text;
            if (IsTextboxEmpty(UsernameTxt) || IsTextboxEmpty(CpwTxt) || IsTextboxEmpty(NpwTxt))
            {
                MessageBox.Show("Please fill out all information in all fields");
                return;
            }

            if (ConfirmPassword != NewPw)
            {
                MessageBox.Show("Your password is not correct");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                string query = "update Teachers set password = @password where username = @username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue ("password", NewPw);

                    // thuc thi truy van 
                    int result = cmd.ExecuteNonQuery();

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
        }
    }
}
