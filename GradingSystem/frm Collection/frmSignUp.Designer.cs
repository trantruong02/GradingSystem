namespace GradingSystem.frm_Collection
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel1 = new Panel();
            Exit = new Label();
            dateTimePicker1 = new DateTimePicker();
            CpwTxt = new TextBox();
            FirstnameTxt = new TextBox();
            EmailTxt = new TextBox();
            SignUpBtn = new Button();
            PasswordTxt = new TextBox();
            UsernameTxt = new TextBox();
            lblSIGNIN = new Label();
            BirthdayLbl = new Label();
            BackLbl = new Label();
            LastnameTxt = new TextBox();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Location = new Point(-1, -1);
            Panel1.Margin = new Padding(4, 3, 4, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(362, 36);
            Panel1.TabIndex = 28;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(368, 9);
            Exit.Margin = new Padding(4, 0, 4, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(29, 26);
            Exit.TabIndex = 26;
            Exit.Text = "X";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Bookman Old Style", 10.8F);
            dateTimePicker1.Location = new Point(37, 225);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(331, 29);
            dateTimePicker1.TabIndex = 37;
            // 
            // CpwTxt
            // 
            CpwTxt.Font = new Font("Bookman Old Style", 10.8F);
            CpwTxt.Location = new Point(37, 435);
            CpwTxt.Margin = new Padding(4, 3, 4, 3);
            CpwTxt.Name = "CpwTxt";
            CpwTxt.PlaceholderText = "Confirm password";
            CpwTxt.Size = new Size(331, 29);
            CpwTxt.TabIndex = 36;
            // 
            // FirstnameTxt
            // 
            FirstnameTxt.Font = new Font("Bookman Old Style", 10.8F);
            FirstnameTxt.Location = new Point(37, 139);
            FirstnameTxt.Margin = new Padding(4, 3, 4, 3);
            FirstnameTxt.Name = "FirstnameTxt";
            FirstnameTxt.PlaceholderText = "First name";
            FirstnameTxt.Size = new Size(136, 29);
            FirstnameTxt.TabIndex = 35;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Bookman Old Style", 10.8F);
            EmailTxt.Location = new Point(37, 510);
            EmailTxt.Margin = new Padding(5, 3, 5, 3);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PlaceholderText = "Email";
            EmailTxt.Size = new Size(331, 29);
            EmailTxt.TabIndex = 34;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.White;
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(37, 46, 255);
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.FromArgb(37, 46, 255);
            SignUpBtn.Location = new Point(132, 573);
            SignUpBtn.Margin = new Padding(5, 3, 5, 3);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(135, 35);
            SignUpBtn.TabIndex = 32;
            SignUpBtn.Text = "SIGN UP";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Bookman Old Style", 10.8F);
            PasswordTxt.Location = new Point(37, 363);
            PasswordTxt.Margin = new Padding(5, 3, 5, 3);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.PlaceholderText = "Password";
            PasswordTxt.Size = new Size(331, 29);
            PasswordTxt.TabIndex = 31;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Font = new Font("Bookman Old Style", 10.8F);
            UsernameTxt.Location = new Point(37, 292);
            UsernameTxt.Margin = new Padding(5, 3, 5, 3);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.PlaceholderText = "Username";
            UsernameTxt.Size = new Size(331, 29);
            UsernameTxt.TabIndex = 30;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.ForeColor = Color.FromArgb(37, 46, 255);
            lblSIGNIN.Location = new Point(113, 64);
            lblSIGNIN.Margin = new Padding(8, 0, 8, 0);
            lblSIGNIN.Name = "lblSIGNIN";
            lblSIGNIN.Size = new Size(178, 44);
            lblSIGNIN.TabIndex = 29;
            lblSIGNIN.Text = "SIGN UP";
            // 
            // BirthdayLbl
            // 
            BirthdayLbl.AutoSize = true;
            BirthdayLbl.Font = new Font("Bookman Old Style", 10.8F);
            BirthdayLbl.ForeColor = SystemColors.ControlDarkDark;
            BirthdayLbl.Location = new Point(37, 202);
            BirthdayLbl.Margin = new Padding(4, 0, 4, 0);
            BirthdayLbl.Name = "BirthdayLbl";
            BirthdayLbl.Size = new Size(85, 20);
            BirthdayLbl.TabIndex = 38;
            BirthdayLbl.Text = "Birthday";
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.DarkGray;
            BackLbl.Location = new Point(132, 666);
            BackLbl.Margin = new Padding(4, 0, 4, 0);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(140, 20);
            BackLbl.TabIndex = 39;
            BackLbl.Text = "Back to LOGIN";
            BackLbl.Click += BackLbl_Click;
            // 
            // LastnameTxt
            // 
            LastnameTxt.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastnameTxt.Location = new Point(181, 141);
            LastnameTxt.Margin = new Padding(4, 3, 4, 3);
            LastnameTxt.Name = "LastnameTxt";
            LastnameTxt.PlaceholderText = "Last name";
            LastnameTxt.Size = new Size(187, 27);
            LastnameTxt.TabIndex = 40;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 695);
            Controls.Add(LastnameTxt);
            Controls.Add(BackLbl);
            Controls.Add(BirthdayLbl);
            Controls.Add(dateTimePicker1);
            Controls.Add(CpwTxt);
            Controls.Add(FirstnameTxt);
            Controls.Add(EmailTxt);
            Controls.Add(SignUpBtn);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(lblSIGNIN);
            Controls.Add(Panel1);
            Controls.Add(Exit);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "SignUpForm";
            Text = "frmSignup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Panel1;
        private Label Exit;
        private DateTimePicker dateTimePicker1;
        private TextBox CpwTxt;
        private TextBox FirstnameTxt;
        private TextBox EmailTxt;
        private TextBox IDLabel;
        private Button SignUpBtn;
        private TextBox PasswordTxt;
        private TextBox UsernameTxt;
        private Label lblSIGNIN;
        private Label BirthdayLbl;
        private Label BackLbl;
        private TextBox LastnameTxt;
    }
}