namespace GradingSystem.frm_Collection
{
    partial class frmForgotPw
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
            NpwTxt = new TextBox();
            BackLbl = new Label();
            UsernameTxt = new TextBox();
            CpwTxt = new TextBox();
            SignUpBtn = new Button();
            lblSIGNIN = new Label();
            Panel1 = new Panel();
            Exit = new Label();
            SuspendLayout();
            // 
            // NpwTxt
            // 
            NpwTxt.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NpwTxt.Location = new Point(37, 258);
            NpwTxt.Margin = new Padding(4, 3, 4, 3);
            NpwTxt.Name = "NpwTxt";
            NpwTxt.PlaceholderText = "New password";
            NpwTxt.Size = new Size(331, 27);
            NpwTxt.TabIndex = 53;
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.DarkGray;
            BackLbl.Location = new Point(132, 469);
            BackLbl.Margin = new Padding(4, 0, 4, 0);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(140, 20);
            BackLbl.TabIndex = 52;
            BackLbl.Text = "Back to LOGIN";
            BackLbl.Click += BackLbl_Click;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Font = new Font("Bookman Old Style", 10.8F);
            UsernameTxt.Location = new Point(37, 197);
            UsernameTxt.Margin = new Padding(4, 3, 4, 3);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.PlaceholderText = "Username";
            UsernameTxt.Size = new Size(331, 29);
            UsernameTxt.TabIndex = 48;
            // 
            // CpwTxt
            // 
            CpwTxt.Font = new Font("Bookman Old Style", 10.8F);
            CpwTxt.Location = new Point(37, 322);
            CpwTxt.Margin = new Padding(5, 3, 5, 3);
            CpwTxt.Name = "CpwTxt";
            CpwTxt.PlaceholderText = "Confirm your password";
            CpwTxt.Size = new Size(331, 29);
            CpwTxt.TabIndex = 47;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.White;
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(37, 46, 255);
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.FromArgb(37, 46, 255);
            SignUpBtn.Location = new Point(132, 393);
            SignUpBtn.Margin = new Padding(5, 3, 5, 3);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(140, 35);
            SignUpBtn.TabIndex = 46;
            SignUpBtn.Text = "RESET";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.ForeColor = Color.FromArgb(37, 46, 255);
            lblSIGNIN.Location = new Point(37, 67);
            lblSIGNIN.Margin = new Padding(8, 0, 8, 0);
            lblSIGNIN.Name = "lblSIGNIN";
            lblSIGNIN.Size = new Size(241, 88);
            lblSIGNIN.TabIndex = 43;
            lblSIGNIN.Text = "FORGOT\r\nPASSWORD";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(4, 3, 4, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(369, 36);
            Panel1.TabIndex = 42;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(367, 9);
            Exit.Margin = new Padding(4, 0, 4, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(29, 26);
            Exit.TabIndex = 41;
            Exit.Text = "X";
            // 
            // frmForgotPw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 504);
            Controls.Add(NpwTxt);
            Controls.Add(BackLbl);
            Controls.Add(UsernameTxt);
            Controls.Add(CpwTxt);
            Controls.Add(SignUpBtn);
            Controls.Add(lblSIGNIN);
            Controls.Add(Panel1);
            Controls.Add(Exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForgotPw";
            Text = "ForgotPw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NpwTxt;
        private Label BackLbl;
        private TextBox UsernameTxt;
        private TextBox CpwTxt;
        private Button SignUpBtn;
        private Label lblSIGNIN;
        private Panel Panel1;
        private Label Exit;
    }
}