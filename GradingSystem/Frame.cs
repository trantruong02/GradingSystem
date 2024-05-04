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
        private Form currentForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        /*private void LoginBtn_Click(object sender, EventArgs e)
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
        }*/

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

        /*private void HidePw_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                ShowPw.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void ShowPw_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                HidePw.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }*/

        private void ForgotPW_Click_1(object sender, EventArgs e)
        {
            SignUpForm frmForgotPassword = new();
            frmForgotPassword.ShowDialog();
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SignUpForm());
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoginForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                // open only form
                currentForm.Close();
            }
            else
            {
                currentForm = childForm;
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;
                PanelContent.Controls.Add(childForm);
                PanelContent.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
    }
}

/* references:
 * https://youtu.be/nh-fleqcds4?si=2erllywErUqHfpi9 ---- cai nay dung de check username & pw trong LoginBtn nhung dung GPT de fix loi "Sequence contains more than one element" 
 * https://stackoverflow.com/questions/72324586/c-sharp-ide0090-new-expression-can-be-simplified-visual-studio-2022

 */