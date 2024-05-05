using GradingSystem.frm_Collection;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GradingSystem
{
    public partial class LoginForm : Form
    {
        // make movable form 
        bool drag = false;
        Point starting_point = new(0, 0);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.OK) { this.Close(); } else { return; }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            starting_point = new Point(e.X, e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - starting_point.X, p.Y - starting_point.Y);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ForgotPW_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm frmForgotPassword = new();
            frmForgotPassword.ShowDialog();
            this.Close();
        }

        private void CaLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm frmForgotPassword = new();
            frmForgotPassword.ShowDialog();
            this.Close();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string title = "Notification";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password is empty", title);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Teachers WHERE username = @username AND password = @password", con))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Login success");
                            }
                            else
                            {
                                MessageBox.Show("Username or password is wrong");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, title);
                }
            }
        }

        private void ForgotPw_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPw frmForgotPw = new ();
            frmForgotPw.ShowDialog();
            this.Close();
        }
    }
}

/* references:
 * https://youtu.be/nh-fleqcds4?si=2erllywErUqHfpi9 ---- cai nay dung de check username & pw trong LoginBtn nhung dung GPT de fix loi "Sequence contains more than one element" 
 * https://stackoverflow.com/questions/72324586/c-sharp-ide0090-new-expression-can-be-simplified-visual-studio-2022

 */