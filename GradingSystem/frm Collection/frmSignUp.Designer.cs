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
            SignUpBtn = new Button();
            PasswordTxt = new TextBox();
            UsernameTxt = new TextBox();
            lblSIGNIN = new Label();
            IDLabel = new TextBox();
            EmailTxt = new TextBox();
            NameTextbox = new TextBox();
            CpwTextbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.FromArgb(159, 112, 253);
            SignUpBtn.ForeColor = SystemColors.ButtonFace;
            SignUpBtn.Location = new Point(45, 581);
            SignUpBtn.Margin = new Padding(5, 3, 5, 3);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(371, 41);
            SignUpBtn.TabIndex = 15;
            SignUpBtn.Text = "SIGN UP";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignInBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Bookman Old Style", 10.8F);
            PasswordTxt.Location = new Point(45, 360);
            PasswordTxt.Margin = new Padding(5, 3, 5, 3);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.PlaceholderText = "PASSWORD";
            PasswordTxt.Size = new Size(372, 29);
            PasswordTxt.TabIndex = 14;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Font = new Font("Bookman Old Style", 10.8F);
            UsernameTxt.Location = new Point(45, 272);
            UsernameTxt.Margin = new Padding(5, 3, 5, 3);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.PlaceholderText = "USERNAME";
            UsernameTxt.Size = new Size(372, 29);
            UsernameTxt.TabIndex = 13;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.Location = new Point(135, 9);
            lblSIGNIN.Margin = new Padding(8, 0, 8, 0);
            lblSIGNIN.Name = "lblSIGNIN";
            lblSIGNIN.Size = new Size(178, 44);
            lblSIGNIN.TabIndex = 12;
            lblSIGNIN.Text = "SIGN UP";
            // 
            // IDLabel
            // 
            IDLabel.Font = new Font("Bookman Old Style", 10.8F);
            IDLabel.Location = new Point(45, 79);
            IDLabel.Margin = new Padding(5, 3, 5, 3);
            IDLabel.Name = "IDLabel";
            IDLabel.PlaceholderText = "ID";
            IDLabel.Size = new Size(161, 29);
            IDLabel.TabIndex = 20;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Bookman Old Style", 10.8F);
            EmailTxt.Location = new Point(45, 517);
            EmailTxt.Margin = new Padding(5, 3, 5, 3);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PlaceholderText = "EMAIL";
            EmailTxt.Size = new Size(372, 29);
            EmailTxt.TabIndex = 21;
            // 
            // NameTextbox
            // 
            NameTextbox.Font = new Font("Bookman Old Style", 10.8F);
            NameTextbox.Location = new Point(44, 134);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.PlaceholderText = "NAME";
            NameTextbox.Size = new Size(372, 29);
            NameTextbox.TabIndex = 22;
            // 
            // CpwTextbox
            // 
            CpwTextbox.Font = new Font("Bookman Old Style", 10.8F);
            CpwTextbox.Location = new Point(45, 443);
            CpwTextbox.Name = "CpwTextbox";
            CpwTextbox.PlaceholderText = "CONFIRM PASSWORD";
            CpwTextbox.Size = new Size(372, 29);
            CpwTextbox.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(44, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(372, 31);
            dateTimePicker1.TabIndex = 24;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 645);
            Controls.Add(dateTimePicker1);
            Controls.Add(CpwTextbox);
            Controls.Add(NameTextbox);
            Controls.Add(EmailTxt);
            Controls.Add(IDLabel);
            Controls.Add(SignUpBtn);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(lblSIGNIN);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "SignUpForm";
            Text = "frmSignup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SignUpBtn;
        private TextBox PasswordTxt;
        private TextBox UsernameTxt;
        private Label lblSIGNIN;
        private TextBox IDLabel;
        private TextBox EmailTxt;
        private TextBox NameTextbox;
        private TextBox CpwTextbox;
        private DateTimePicker dateTimePicker1;
    }
}