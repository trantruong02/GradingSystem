﻿namespace GradingSystem.frm_Collection
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BackLbl = new Label();
            lblSIGNIN = new Label();
            Panel1 = new Panel();
            Exit = new Label();
            Token = new Guna.UI2.WinForms.Guna2TextBox();
            Sendcode = new Guna.UI2.WinForms.Guna2Button();
            Username = new Guna.UI2.WinForms.Guna2TextBox();
            Reset = new Guna.UI2.WinForms.Guna2Button();
            EmailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.DarkGray;
            BackLbl.Location = new Point(137, 443);
            BackLbl.Margin = new Padding(4, 0, 4, 0);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(140, 20);
            BackLbl.TabIndex = 52;
            BackLbl.Text = "Back to LOGIN";
            BackLbl.Click += BackLbl_Click;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.ForeColor = Color.FromArgb(255, 132, 0);
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
            Panel1.Controls.Add(Exit);
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(4, 3, 4, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(400, 36);
            Panel1.TabIndex = 42;
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
            Exit.TabIndex = 41;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // Token
            // 
            Token.BorderColor = Color.DarkGray;
            Token.BorderRadius = 20;
            Token.CustomizableEdges = customizableEdges11;
            Token.DefaultText = "";
            Token.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Token.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Token.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Token.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Token.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Token.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Token.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Token.Location = new Point(37, 283);
            Token.Margin = new Padding(4);
            Token.Name = "Token";
            Token.PasswordChar = '*';
            Token.PlaceholderForeColor = Color.DimGray;
            Token.PlaceholderText = "New password";
            Token.SelectedText = "";
            Token.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Token.Size = new Size(331, 41);
            Token.TabIndex = 54;
            // 
            // Sendcode
            // 
            Sendcode.BorderColor = Color.FromArgb(255, 152, 0);
            Sendcode.BorderRadius = 20;
            Sendcode.BorderThickness = 1;
            Sendcode.CustomizableEdges = customizableEdges13;
            Sendcode.DisabledState.BorderColor = Color.DarkGray;
            Sendcode.DisabledState.CustomBorderColor = Color.DarkGray;
            Sendcode.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Sendcode.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Sendcode.FillColor = Color.Transparent;
            Sendcode.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sendcode.ForeColor = Color.Black;
            Sendcode.Location = new Point(263, 233);
            Sendcode.Name = "Sendcode";
            Sendcode.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Sendcode.Size = new Size(105, 42);
            Sendcode.TabIndex = 55;
            Sendcode.Text = "Send";
            Sendcode.Click += Sendcode_Click;
            // 
            // Username
            // 
            Username.BorderColor = Color.DarkGray;
            Username.BorderRadius = 20;
            Username.CustomizableEdges = customizableEdges15;
            Username.DefaultText = "";
            Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Username.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Username.Location = new Point(37, 185);
            Username.Margin = new Padding(4);
            Username.Name = "Username";
            Username.PasswordChar = '\0';
            Username.PlaceholderForeColor = Color.DimGray;
            Username.PlaceholderText = "Username";
            Username.SelectedText = "";
            Username.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Username.Size = new Size(331, 41);
            Username.TabIndex = 54;
            // 
            // Reset
            // 
            Reset.BorderColor = Color.FromArgb(255, 152, 0);
            Reset.BorderRadius = 20;
            Reset.BorderThickness = 1;
            Reset.CustomizableEdges = customizableEdges17;
            Reset.DisabledState.BorderColor = Color.DarkGray;
            Reset.DisabledState.CustomBorderColor = Color.DarkGray;
            Reset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Reset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reset.FillColor = Color.Transparent;
            Reset.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reset.ForeColor = Color.FromArgb(255, 152, 0);
            Reset.Location = new Point(151, 371);
            Reset.Name = "Reset";
            Reset.ShadowDecoration.CustomizableEdges = customizableEdges18;
            Reset.Size = new Size(105, 42);
            Reset.TabIndex = 55;
            Reset.Text = "RESET";
            Reset.Click += Reset_Click;
            // 
            // EmailTxt
            // 
            EmailTxt.BorderColor = Color.DarkGray;
            EmailTxt.BorderRadius = 20;
            EmailTxt.CustomizableEdges = customizableEdges19;
            EmailTxt.DefaultText = "";
            EmailTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmailTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmailTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmailTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmailTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTxt.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTxt.Location = new Point(37, 234);
            EmailTxt.Margin = new Padding(4);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PasswordChar = '\0';
            EmailTxt.PlaceholderForeColor = Color.DimGray;
            EmailTxt.PlaceholderText = "Emai";
            EmailTxt.SelectedText = "";
            EmailTxt.ShadowDecoration.CustomizableEdges = customizableEdges20;
            EmailTxt.Size = new Size(219, 41);
            EmailTxt.TabIndex = 54;
            // 
            // frmForgotPw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 481);
            Controls.Add(Reset);
            Controls.Add(Sendcode);
            Controls.Add(EmailTxt);
            Controls.Add(Username);
            Controls.Add(Token);
            Controls.Add(BackLbl);
            Controls.Add(lblSIGNIN);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForgotPw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPw";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NpwTxt;
        private Label BackLbl;
        private TextBox UsernameTxt;
        private TextBox CpwTxt;
        private Label lblSIGNIN;
        private Panel Panel1;
        private Label Exit;
        private Guna.UI2.WinForms.Guna2TextBox Token;
        private Guna.UI2.WinForms.Guna2Button Sendcode;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private Guna.UI2.WinForms.Guna2Button Reset;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxt;
    }
}