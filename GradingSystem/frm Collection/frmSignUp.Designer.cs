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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            MovementPanel = new Panel();
            Exit = new Label();
            FirstnameTxt = new TextBox();
            SignUpBtn = new Button();
            lblSIGNIN = new Label();
            BackLbl = new Label();
            LastnameTxt = new TextBox();
            UsernameTxt = new TextBox();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            CpwTxt = new TextBox();
            TeacherRbtn = new RadioButton();
            StudentRbtn = new RadioButton();
            RoleLbl = new Label();
            MovementPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MovementPanel
            // 
            MovementPanel.BackColor = Color.White;
            MovementPanel.Controls.Add(Exit);
            MovementPanel.Location = new Point(-1, 0);
            MovementPanel.Margin = new Padding(4, 3, 4, 3);
            MovementPanel.Name = "MovementPanel";
            MovementPanel.Size = new Size(402, 36);
            MovementPanel.TabIndex = 28;
            MovementPanel.MouseDown += MovementPanel_MouseDown;
            MovementPanel.MouseMove += MovementPanel_MouseMove;
            MovementPanel.MouseUp += MovementPanel_MouseUp;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(367, 5);
            Exit.Margin = new Padding(4, 0, 4, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(29, 26);
            Exit.TabIndex = 26;
            Exit.Text = "X";
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
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.White;
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 152, 67);
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.FromArgb(255, 152, 0);
            SignUpBtn.Location = new Point(113, 486);
            SignUpBtn.Margin = new Padding(5, 3, 5, 3);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(178, 35);
            SignUpBtn.TabIndex = 32;
            SignUpBtn.Text = "SIGN UP";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.ForeColor = Color.FromArgb(255, 132, 0);
            lblSIGNIN.Location = new Point(113, 64);
            lblSIGNIN.Margin = new Padding(8, 0, 8, 0);
            lblSIGNIN.Name = "lblSIGNIN";
            lblSIGNIN.Size = new Size(178, 44);
            lblSIGNIN.TabIndex = 29;
            lblSIGNIN.Text = "SIGN UP";
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.DarkGray;
            BackLbl.Location = new Point(132, 579);
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
            // UsernameTxt
            // 
            UsernameTxt.Font = new Font("Bookman Old Style", 10.8F);
            UsernameTxt.Location = new Point(37, 241);
            UsernameTxt.Margin = new Padding(5, 3, 5, 3);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.PlaceholderText = "Username";
            UsernameTxt.Size = new Size(331, 29);
            UsernameTxt.TabIndex = 30;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Bookman Old Style", 10.8F);
            PasswordTxt.Location = new Point(37, 303);
            PasswordTxt.Margin = new Padding(5, 3, 5, 3);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.PlaceholderText = "Password";
            PasswordTxt.Size = new Size(331, 29);
            PasswordTxt.TabIndex = 31;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Bookman Old Style", 10.8F);
            EmailTxt.Location = new Point(37, 427);
            EmailTxt.Margin = new Padding(5, 3, 5, 3);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PlaceholderText = "Email";
            EmailTxt.Size = new Size(331, 29);
            EmailTxt.TabIndex = 34;
            // 
            // CpwTxt
            // 
            CpwTxt.Font = new Font("Bookman Old Style", 10.8F);
            CpwTxt.Location = new Point(37, 365);
            CpwTxt.Margin = new Padding(4, 3, 4, 3);
            CpwTxt.Name = "CpwTxt";
            CpwTxt.PlaceholderText = "Confirm password";
            CpwTxt.Size = new Size(331, 29);
            CpwTxt.TabIndex = 36;
            // 
            // TeacherRbtn
            // 
            TeacherRbtn.AutoSize = true;
            TeacherRbtn.Font = new Font("Bookman Old Style", 10.8F);
            TeacherRbtn.ForeColor = Color.Gray;
            TeacherRbtn.Location = new Point(124, 195);
            TeacherRbtn.Name = "TeacherRbtn";
            TeacherRbtn.Size = new Size(101, 24);
            TeacherRbtn.TabIndex = 41;
            TeacherRbtn.TabStop = true;
            TeacherRbtn.Text = "Teacher";
            TeacherRbtn.UseVisualStyleBackColor = true;
            // 
            // StudentRbtn
            // 
            StudentRbtn.AutoSize = true;
            StudentRbtn.Font = new Font("Bookman Old Style", 10.8F);
            StudentRbtn.ForeColor = Color.Gray;
            StudentRbtn.Location = new Point(267, 195);
            StudentRbtn.Name = "StudentRbtn";
            StudentRbtn.Size = new Size(101, 24);
            StudentRbtn.TabIndex = 42;
            StudentRbtn.TabStop = true;
            StudentRbtn.Text = "Student";
            StudentRbtn.UseVisualStyleBackColor = true;
            // 
            // RoleLbl
            // 
            RoleLbl.AutoSize = true;
            RoleLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleLbl.ForeColor = Color.Gray;
            RoleLbl.Location = new Point(37, 197);
            RoleLbl.Name = "RoleLbl";
            RoleLbl.Size = new Size(47, 20);
            RoleLbl.TabIndex = 43;
            RoleLbl.Text = "Role";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 614);
            Controls.Add(RoleLbl);
            Controls.Add(StudentRbtn);
            Controls.Add(TeacherRbtn);
            Controls.Add(LastnameTxt);
            Controls.Add(BackLbl);
            Controls.Add(CpwTxt);
            Controls.Add(FirstnameTxt);
            Controls.Add(EmailTxt);
            Controls.Add(SignUpBtn);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(lblSIGNIN);
            Controls.Add(MovementPanel);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSignup";
            MovementPanel.ResumeLayout(false);
            MovementPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel MovementPanel;
        private Label Exit;
        private TextBox FirstnameTxt;
        private TextBox IDLabel;
        private Button SignUpBtn;
        private Label lblSIGNIN;
        private Label BackLbl;
        private TextBox LastnameTxt;
        private TextBox UsernameTxt;
        private TextBox PasswordTxt;
        private TextBox EmailTxt;
        private TextBox CpwTxt;
        private RadioButton TeacherRbtn;
        private RadioButton StudentRbtn;
        private Label RoleLbl;
    }
}