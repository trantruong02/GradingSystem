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
            pictureBox1 = new PictureBox();
            Exit = new Label();
            label1 = new Label();
            Panel1 = new Panel();
            NextBtn = new Button();
            PreviousBtn = new Button();
            PanelContent = new Panel();
            ForgotPw = new Label();
            ShowPw = new Label();
            HidePw = new Label();
            LoginBtn = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelContent.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.FromArgb(17, 29, 51);
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.Control;
            Exit.Location = new Point(616, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(29, 26);
            Exit.TabIndex = 5;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(17, 29, 51);
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(50, 72);
            label1.Name = "label1";
            label1.Size = new Size(514, 36);
            label1.TabIndex = 6;
            label1.Text = "Multiple Choice Grading system";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(16, 29, 48);
            Panel1.Location = new Point(-1, -1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(621, 37);
            Panel1.TabIndex = 7;
            Panel1.MouseDown += Panel1_MouseDown;
            Panel1.MouseMove += Panel1_MouseMove;
            Panel1.MouseUp += Panel1_MouseUp;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.Transparent;
            NextBtn.BackgroundImage = Properties.Resources.next;
            NextBtn.BackgroundImageLayout = ImageLayout.Zoom;
            NextBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.ForeColor = Color.Transparent;
            NextBtn.Location = new Point(615, 604);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(31, 29);
            NextBtn.TabIndex = 13;
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // PreviousBtn
            // 
            PreviousBtn.BackColor = Color.Transparent;
            PreviousBtn.BackgroundImage = Properties.Resources.back__1_;
            PreviousBtn.BackgroundImageLayout = ImageLayout.Zoom;
            PreviousBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            PreviousBtn.FlatAppearance.BorderSize = 0;
            PreviousBtn.FlatStyle = FlatStyle.Flat;
            PreviousBtn.ForeColor = Color.Transparent;
            PreviousBtn.Location = new Point(10, 604);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(28, 29);
            PreviousBtn.TabIndex = 13;
            PreviousBtn.UseVisualStyleBackColor = false;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // PanelContent
            // 
            PanelContent.Controls.Add(ForgotPw);
            PanelContent.Controls.Add(txtUsername);
            PanelContent.Controls.Add(ShowPw);
            PanelContent.Controls.Add(lblLogin);
            PanelContent.Controls.Add(HidePw);
            PanelContent.Controls.Add(txtPassword);
            PanelContent.Controls.Add(LoginBtn);
            PanelContent.Location = new Point(104, 329);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(460, 645);
            PanelContent.TabIndex = 14;
            // 
            // ForgotPw
            // 
            ForgotPw.AutoSize = true;
            ForgotPw.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgotPw.ForeColor = Color.FromArgb(255, 137, 17);
            ForgotPw.Location = new Point(216, 319);
            ForgotPw.Margin = new Padding(4, 0, 4, 0);
            ForgotPw.Name = "ForgotPw";
            ForgotPw.Size = new Size(157, 21);
            ForgotPw.TabIndex = 25;
            ForgotPw.Text = "Forgot Password?";
            // 
            // ShowPw
            // 
            ShowPw.AutoSize = true;
            ShowPw.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPw.Location = new Point(381, 281);
            ShowPw.Margin = new Padding(4, 0, 4, 0);
            ShowPw.Name = "ShowPw";
            ShowPw.Size = new Size(37, 26);
            ShowPw.TabIndex = 24;
            ShowPw.Text = "👁️";
            // 
            // HidePw
            // 
            HidePw.AutoSize = true;
            HidePw.Font = new Font("Bookman Old Style", 13.8F);
            HidePw.ForeColor = SystemColors.ActiveCaptionText;
            HidePw.Location = new Point(381, 281);
            HidePw.Margin = new Padding(4, 0, 4, 0);
            HidePw.Name = "HidePw";
            HidePw.Size = new Size(37, 26);
            HidePw.TabIndex = 23;
            HidePw.Text = "🔒";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(159, 112, 253);
            LoginBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.Control;
            LoginBtn.Location = new Point(65, 425);
            LoginBtn.Margin = new Padding(4, 3, 4, 3);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(308, 41);
            LoginBtn.TabIndex = 22;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(65, 278);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(308, 31);
            txtPassword.TabIndex = 21;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(65, 199);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(308, 31);
            txtUsername.TabIndex = 20;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(146, 0);
            lblLogin.Margin = new Padding(7, 0, 7, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(144, 44);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 986);
            Controls.Add(PanelContent);
            Controls.Add(PreviousBtn);
            Controls.Add(NextBtn);
            Controls.Add(Panel1);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(pictureBox1);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "LoginForm";
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelContent.ResumeLayout(false);
            PanelContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Exit;
        private Label label1;
        private Panel Panel1;
        private Button NextBtn;
        private Button PreviousBtn;
        private Panel PanelContent;
        private Label ForgotPw;
        private TextBox txtUsername;
        private Label ShowPw;
        private Label lblLogin;
        private Label HidePw;
        private TextBox txtPassword;
        private Button LoginBtn;
    }
}
