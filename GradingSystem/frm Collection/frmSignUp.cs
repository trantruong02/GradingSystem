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
            string message = "Do you want to close this window?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.OK) { this.Close(); } else { return; }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login success");
        }

        private void NextBtn_Click(object obj, EventArgs e)
        {
            this.Hide();
            SignUpForm signInForm = new();
            signInForm.ShowDialog();
            this.Close();
        }

        private void PreviousBtn_Click(Object obj, EventArgs e)
        {
            this.Hide();
            SignUpForm signInForm = new();
            signInForm.ShowDialog();
            this.Close();
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

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string Firstname = FirstnameTxt.Text.Trim();
            string Lastname = LastnameTxt.Text.Trim();
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;
            string confirm_password = CpwTxt.Text;
            string email = EmailTxt.Text;


        }
    }
}
