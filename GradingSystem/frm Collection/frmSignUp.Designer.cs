namespace GradingSystem.frm_Collection
{
    partial class FrmSignup
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignup));
            panel3 = new Panel();
            Exit = new Label();
            lblSIGNIN = new Label();
            panel1 = new Panel();
            StudentRbtn = new RadioButton();
            TeacherRbtn = new RadioButton();
            RoleLbl = new Label();
            BackLbl = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(Exit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 40);
            panel3.TabIndex = 48;
            panel3.MouseDown += MovementPanel_MouseDown;
            panel3.MouseMove += MovementPanel_MouseMove;
            panel3.MouseUp += MovementPanel_MouseUp;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.ActiveCaptionText;
            Exit.Location = new Point(362, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(29, 26);
            Exit.TabIndex = 49;
            Exit.Text = "X";
            Exit.Click += SignUpBtn_Click;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.Anchor = AnchorStyles.None;
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.ForeColor = Color.FromArgb(255, 132, 0);
            lblSIGNIN.Location = new Point(108, 54);
            lblSIGNIN.Margin = new Padding(8, 0, 8, 0);
            lblSIGNIN.Name = "lblSIGNIN";
            lblSIGNIN.Size = new Size(178, 44);
            lblSIGNIN.TabIndex = 49;
            lblSIGNIN.Text = "SIGN UP";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(StudentRbtn);
            panel1.Controls.Add(TeacherRbtn);
            panel1.Controls.Add(RoleLbl);
            panel1.Location = new Point(32, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 38);
            panel1.TabIndex = 56;
            // 
            // StudentRbtn
            // 
            StudentRbtn.AutoSize = true;
            StudentRbtn.Font = new Font("Bookman Old Style", 10.8F);
            StudentRbtn.ForeColor = Color.Gray;
            StudentRbtn.Location = new Point(227, 7);
            StudentRbtn.Name = "StudentRbtn";
            StudentRbtn.Size = new Size(99, 24);
            StudentRbtn.TabIndex = 42;
            StudentRbtn.TabStop = true;
            StudentRbtn.Text = "student";
            StudentRbtn.UseVisualStyleBackColor = true;
            // 
            // TeacherRbtn
            // 
            TeacherRbtn.AutoSize = true;
            TeacherRbtn.Font = new Font("Bookman Old Style", 10.8F);
            TeacherRbtn.ForeColor = Color.Gray;
            TeacherRbtn.Location = new Point(90, 7);
            TeacherRbtn.Name = "TeacherRbtn";
            TeacherRbtn.Size = new Size(96, 24);
            TeacherRbtn.TabIndex = 41;
            TeacherRbtn.TabStop = true;
            TeacherRbtn.Text = "teacher";
            TeacherRbtn.UseVisualStyleBackColor = true;
            // 
            // RoleLbl
            // 
            RoleLbl.AutoSize = true;
            RoleLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleLbl.ForeColor = Color.Gray;
            RoleLbl.Location = new Point(3, 9);
            RoleLbl.Name = "RoleLbl";
            RoleLbl.Size = new Size(47, 20);
            RoleLbl.TabIndex = 43;
            RoleLbl.Text = "Role";
            // 
            // BackLbl
            // 
            BackLbl.Anchor = AnchorStyles.None;
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.DarkGray;
            BackLbl.Location = new Point(127, 536);
            BackLbl.Margin = new Padding(4, 0, 4, 0);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(140, 20);
            BackLbl.TabIndex = 50;
            BackLbl.Text = "Back to LOGIN";
            BackLbl.Click += BackLbl_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.LightGray;
            guna2TextBox1.BorderRadius = 20;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Bookman Old Style", 10.8F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(32, 191);
            guna2TextBox1.Margin = new Padding(4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.DarkGray;
            guna2TextBox1.PlaceholderText = "Username";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(331, 41);
            guna2TextBox1.TabIndex = 57;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.BorderColor = Color.LightGray;
            guna2TextBox2.BorderRadius = 20;
            guna2TextBox2.CustomizableEdges = customizableEdges3;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Bookman Old Style", 10.8F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(32, 245);
            guna2TextBox2.Margin = new Padding(4);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderForeColor = Color.DarkGray;
            guna2TextBox2.PlaceholderText = "Password";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(331, 41);
            guna2TextBox2.TabIndex = 57;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.BorderColor = Color.LightGray;
            guna2TextBox3.BorderRadius = 20;
            guna2TextBox3.CustomizableEdges = customizableEdges5;
            guna2TextBox3.DefaultText = "";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Bookman Old Style", 10.8F);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Location = new Point(32, 302);
            guna2TextBox3.Margin = new Padding(4);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PasswordChar = '\0';
            guna2TextBox3.PlaceholderForeColor = Color.DarkGray;
            guna2TextBox3.PlaceholderText = "Confirm Password";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox3.Size = new Size(331, 41);
            guna2TextBox3.TabIndex = 57;
            // 
            // guna2TextBox4
            // 
            guna2TextBox4.BorderColor = Color.LightGray;
            guna2TextBox4.BorderRadius = 20;
            guna2TextBox4.CustomizableEdges = customizableEdges7;
            guna2TextBox4.DefaultText = "";
            guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Font = new Font("Bookman Old Style", 10.8F);
            guna2TextBox4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Location = new Point(32, 360);
            guna2TextBox4.Margin = new Padding(4);
            guna2TextBox4.Name = "guna2TextBox4";
            guna2TextBox4.PasswordChar = '\0';
            guna2TextBox4.PlaceholderForeColor = Color.DarkGray;
            guna2TextBox4.PlaceholderText = "Email";
            guna2TextBox4.SelectedText = "";
            guna2TextBox4.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox4.Size = new Size(331, 41);
            guna2TextBox4.TabIndex = 57;
            guna2TextBox4.TextChanged += guna2TextBox4_TextChanged;
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.BorderColor = Color.FromArgb(255, 132, 0);
            guna2GradientButton1.BorderRadius = 25;
            guna2GradientButton1.BorderThickness = 1;
            guna2GradientButton1.CustomBorderColor = Color.FromArgb(255, 132, 0);
            guna2GradientButton1.CustomizableEdges = customizableEdges9;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.White;
            guna2GradientButton1.FillColor2 = Color.White;
            guna2GradientButton1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientButton1.ForeColor = Color.FromArgb(255, 132, 0);
            guna2GradientButton1.Location = new Point(108, 422);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GradientButton1.Size = new Size(159, 43);
            guna2GradientButton1.TabIndex = 58;
            guna2GradientButton1.Text = "Sign Up";
            // 
            // FrmSignup
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 565);
            Controls.Add(guna2GradientButton1);
            Controls.Add(guna2TextBox4);
            Controls.Add(guna2TextBox3);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(BackLbl);
            Controls.Add(lblSIGNIN);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSignup";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label Exit;
        private Guna.UI2.WinForms.Guna2Button SignUpBtn;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxt;
        private Guna.UI2.WinForms.Guna2TextBox CpwTxt;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxt;
        private Label lblSIGNIN;
        private Panel panel1;
        private RadioButton StudentRbtn;
        private RadioButton TeacherRbtn;
        private Label RoleLbl;
        private Label BackLbl;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}