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
    public partial class SignUpForm : Form
    {
        // make movable form 
        bool drag = false;
        Point starting_point = new(0, 0);

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login success");
        }

        private void MovementPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            starting_point = new Point(e.X, e.Y);
        }

        private void MovementPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - starting_point.X, p.Y - starting_point.Y);
            }
        }

        private void MovementPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
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

        private string GenerateTeacherID()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True"))
            {
                connection.Open();
                string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(ID, 3, LEN(ID)) AS INT)), 0) FROM Teachers";
                SqlCommand command = new SqlCommand(query, connection);
                int maxID = (int)command.ExecuteScalar();
                return "GV" + (maxID + 1).ToString();
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string TeacherID = GenerateTeacherID();
            string Firstname = FirstnameTxt.Text.Trim();
            string Lastname = LastnameTxt.Text.Trim();
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;
            string confirm_password = CpwTxt.Text;
            string email = EmailTxt.Text;
            string title = "Notification";

            if (IsTextboxEmpty(FirstnameTxt) || IsTextboxEmpty(LastnameTxt) || IsTextboxEmpty(UsernameTxt) || IsTextboxEmpty(PasswordTxt) || IsTextboxEmpty(CpwTxt) || IsTextboxEmpty(EmailTxt))
            {
                MessageBox.Show("Please fill out all information in all fields", title);
                return;
            }

            if (confirm_password != password)
            {
                MessageBox.Show("Your password is not correct", title);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                string query = " insert into Teachers (ID, FirstName, LastName, username, password, email)" + "values (@ID, @Firstname, @Lastname, @username, @password, @email)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", TeacherID);
                    cmd.Parameters.AddWithValue("@Firstname", Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", Lastname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    // thuc thi truy van 
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Sign up    success");
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
