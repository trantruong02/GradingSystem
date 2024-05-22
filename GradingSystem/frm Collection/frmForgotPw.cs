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
using System.Text.RegularExpressions;

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
            /*MessageBox.Show($"This is a password for {email} " +
                $"Your new password is {code}. Do not share to anyone");
            */
            bool success = SendVerifyEmail(email, code);
            
            if (success)
            {
                MessageBox.Show($"A new password has been sent to {email}\n" +
                    $"Please check your email before proceeding.\n" +
                    $"Remember to check both your inbox and spam folder.\n" +
                    $"TEST: The code is {code}");
            }

        }

        private bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool SendVerifyEmail(string email, int code)
        {
            // !! CẢNH BÁO !! Đừng up email và App Password lên Github!
            // Email dùng để gửi password mới cho User
            string senderEmail = "example@email.com";
            // App Password
            /*
             * To get App Password, sign into Google with the email you want to use.
             * Make sure it has 2-factor Authentication (xác thực bảo mật 2 chiều) enabled.
             * Go to "Manage your Google Account" (Quản Lý Tài Khoản Google)
             * Search "App Passwords"
             * Make one, copy and paste it here. These passwords typically has 19 letters, space included.
             */
            string appPassword = "abcd efgh ijkl mnop";
            // DO NOT PUSH APP PASSWORD INTO GITHUB, STORE IT SOMEWHERE ELSE

            if (!ValidateEmail(email))
            {
                MessageBox.Show($"Invalid email format");
                return false;
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(email);
                mail.Subject = "Grading System password recovery";
                mail.Body = $"Hello! You have recently requested to recover your account.\n" +
                    $"Do not share the contents of this email to anyone.\n\n" +
                    $"Here is your new password: {code}";
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderEmail, appPassword);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

                Console.WriteLine("Mail sent");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot send email: " + ex.Message);
                MessageBox.Show($"An error occurred while sending email.");
                return false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
