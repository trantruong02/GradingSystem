namespace GradingSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Exit = new Label();
            Panel1 = new Panel();
            LoginBtn = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            ForgotPw = new Label();
            CaLbl = new Label();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 132, 0);
            lblLogin.Location = new Point(123, 63);
            lblLogin.Margin = new Padding(6, 0, 6, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(144, 44);
            lblLogin.TabIndex = 26;
            lblLogin.Text = "LOGIN";
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.ActiveCaptionText;
            Exit.Location = new Point(367, 5);
            Exit.Name = "Exit";
            Exit.Size = new Size(29, 26);
            Exit.TabIndex = 5;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Location = new Point(-1, -1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(405, 36);
            Panel1.TabIndex = 7;
            Panel1.MouseDown += Panel1_MouseDown;
            Panel1.MouseMove += Panel1_MouseMove;
            Panel1.MouseUp += Panel1_MouseUp;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 152, 0);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.FromArgb(255, 152, 0);
            LoginBtn.Location = new Point(131, 306);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(129, 35);
            LoginBtn.TabIndex = 29;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(30, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(331, 29);
            txtPassword.TabIndex = 28;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(331, 29);
            txtUsername.TabIndex = 27;
            // 
            // ForgotPw
            // 
            ForgotPw.AutoSize = true;
            ForgotPw.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgotPw.ForeColor = Color.DarkGray;
            ForgotPw.Location = new Point(213, 251);
            ForgotPw.Name = "ForgotPw";
            ForgotPw.Size = new Size(148, 21);
            ForgotPw.TabIndex = 32;
            ForgotPw.Text = "Forgot Password";
            ForgotPw.Click += ForgotPw_Click;
            // 
            // CaLbl
            // 
            CaLbl.AutoSize = true;
            CaLbl.ForeColor = Color.Gray;
            CaLbl.Location = new Point(123, 386);
            CaLbl.Name = "CaLbl";
            CaLbl.Size = new Size(144, 20);
            CaLbl.TabIndex = 33;
            CaLbl.Text = "Create Account";
            CaLbl.Click += CaLbl_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 419);
            Controls.Add(CaLbl);
            Controls.Add(ForgotPw);
            Controls.Add(txtUsername);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(LoginBtn);
            Controls.Add(Exit);
            Controls.Add(Panel1);
            DoubleBuffered = true;
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Exit;
        private Panel Panel1;
        private Button LoginBtn;
        private TextBox txtPassword;
        private Label lblLogin;
        private TextBox txtUsername;
        private Label ForgotPw;
        private Label CaLbl;
    }
}
