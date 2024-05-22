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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;
using System.Net;

namespace GradingSystem.frm_Collection
{
    public partial class frmForgotPw : Form
    {
        string randomcode;
        public static string to;
        public frmForgotPw()
        {
            InitializeComponent();
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin loginForm = new();
            loginForm.ShowDialog();
            this.Close();
        }

        private static bool IsTextboxEmpty(Guna2TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        private int GeneratePassword()
        {
            Random rnd = new();
            int random_password = rnd.Next(999999);
            return random_password;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }

        private void Sendcode_Click(object sender, EventArgs e)
        {
            int code = GeneratePassword();
            string email = EmailTxt.Text;
            MessageBox.Show($"This is a password for {email} " +
                $"Your new password is {code}. Do not share to anyone");

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
