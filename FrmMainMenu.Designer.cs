namespace GradingSystem.frm_Collection
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            MenuPanel = new Panel();
            LogoutBtn = new FontAwesome.Sharp.IconButton();
            ContactBtn = new FontAwesome.Sharp.IconButton();
            ScoreBtn = new FontAwesome.Sharp.IconButton();
            ExamsBtn = new FontAwesome.Sharp.IconButton();
            DashboardBtn = new FontAwesome.Sharp.IconButton();
            QuestionsBtn = new FontAwesome.Sharp.IconButton();
            MainPanel = new Panel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MenuPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(34, 102, 141);
            MenuPanel.Controls.Add(LogoutBtn);
            MenuPanel.Controls.Add(ContactBtn);
            MenuPanel.Controls.Add(ScoreBtn);
            MenuPanel.Controls.Add(ExamsBtn);
            MenuPanel.Controls.Add(DashboardBtn);
            MenuPanel.Controls.Add(QuestionsBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(214, 650);
            MenuPanel.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Dock = DockStyle.Bottom;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.FromArgb(255, 250, 221);
            LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            LogoutBtn.IconColor = Color.FromArgb(255, 250, 221);
            LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoutBtn.IconSize = 35;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(0, 590);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Padding = new Padding(10, 0, 20, 0);
            LogoutBtn.Rotation = 180D;
            LogoutBtn.Size = new Size(214, 60);
            LogoutBtn.TabIndex = 9;
            LogoutBtn.Text = "  Logout";
            LogoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ContactBtn
            // 
            ContactBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactBtn.FlatAppearance.BorderSize = 0;
            ContactBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ContactBtn.ForeColor = Color.FromArgb(255, 250, 221);
            ContactBtn.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            ContactBtn.IconColor = Color.FromArgb(255, 250, 221);
            ContactBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ContactBtn.IconSize = 38;
            ContactBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ContactBtn.Location = new Point(0, 419);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Padding = new Padding(10, 0, 20, 0);
            ContactBtn.Size = new Size(214, 60);
            ContactBtn.TabIndex = 8;
            ContactBtn.Text = "  Contact us";
            ContactBtn.TextAlign = ContentAlignment.MiddleLeft;
            ContactBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ContactBtn.UseVisualStyleBackColor = true;
            ContactBtn.Click += ContactBtn_Click;
            // 
            // ScoreBtn
            // 
            ScoreBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreBtn.FlatAppearance.BorderSize = 0;
            ScoreBtn.FlatStyle = FlatStyle.Flat;
            ScoreBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ScoreBtn.ForeColor = Color.FromArgb(255, 250, 221);
            ScoreBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            ScoreBtn.IconColor = Color.FromArgb(255, 250, 221);
            ScoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ScoreBtn.IconSize = 40;
            ScoreBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.Location = new Point(0, 332);
            ScoreBtn.Name = "ScoreBtn";
            ScoreBtn.Padding = new Padding(10, 0, 20, 0);
            ScoreBtn.Size = new Size(214, 60);
            ScoreBtn.TabIndex = 5;
            ScoreBtn.Text = "  Score";
            ScoreBtn.TextAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ScoreBtn.UseVisualStyleBackColor = true;
            ScoreBtn.Click += ScoreBtn_Click;
            // 
            // ExamsBtn
            // 
            ExamsBtn.AccessibleDescription = "Insert, view or delete questions in exams";
            ExamsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExamsBtn.FlatAppearance.BorderSize = 0;
            ExamsBtn.FlatStyle = FlatStyle.Flat;
            ExamsBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ExamsBtn.ForeColor = Color.FromArgb(255, 250, 221);
            ExamsBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            ExamsBtn.IconColor = Color.FromArgb(255, 250, 221);
            ExamsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExamsBtn.IconSize = 35;
            ExamsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.Location = new Point(0, 245);
            ExamsBtn.Name = "ExamsBtn";
            ExamsBtn.Padding = new Padding(10, 0, 20, 0);
            ExamsBtn.Size = new Size(214, 60);
            ExamsBtn.TabIndex = 3;
            ExamsBtn.Text = "   Exams";
            ExamsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExamsBtn.UseVisualStyleBackColor = true;
            ExamsBtn.Click += ExamsBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = Color.FromArgb(255, 250, 221);
            DashboardBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            DashboardBtn.IconColor = Color.FromArgb(255, 250, 221);
            DashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DashboardBtn.IconSize = 38;
            DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.Location = new Point(0, 71);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Padding = new Padding(10, 0, 20, 0);
            DashboardBtn.Size = new Size(214, 60);
            DashboardBtn.TabIndex = 2;
            DashboardBtn.Text = "  Dashboard";
            DashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DashboardBtn.UseVisualStyleBackColor = true;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // QuestionsBtn
            // 
            QuestionsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuestionsBtn.FlatAppearance.BorderSize = 0;
            QuestionsBtn.FlatStyle = FlatStyle.Flat;
            QuestionsBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            QuestionsBtn.ForeColor = Color.FromArgb(255, 250, 221);
            QuestionsBtn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            QuestionsBtn.IconColor = Color.FromArgb(255, 250, 221);
            QuestionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            QuestionsBtn.IconSize = 40;
            QuestionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.Location = new Point(0, 158);
            QuestionsBtn.Name = "QuestionsBtn";
            QuestionsBtn.Padding = new Padding(10, 0, 20, 0);
            QuestionsBtn.Size = new Size(214, 60);
            QuestionsBtn.TabIndex = 2;
            QuestionsBtn.Text = "  Questions";
            QuestionsBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            QuestionsBtn.UseVisualStyleBackColor = true;
            QuestionsBtn.Click += QuestionsBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(label16);
            MainPanel.Controls.Add(label15);
            MainPanel.Controls.Add(label14);
            MainPanel.Controls.Add(label13);
            MainPanel.Controls.Add(label12);
            MainPanel.Controls.Add(label11);
            MainPanel.Controls.Add(label10);
            MainPanel.Controls.Add(label9);
            MainPanel.Controls.Add(label8);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(214, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1025, 650);
            MainPanel.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(456, 438);
            label16.Name = "label16";
            label16.Size = new Size(93, 25);
            label16.TabIndex = 15;
            label16.Text = "label16";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(456, 373);
            label15.Name = "label15";
            label15.Size = new Size(93, 25);
            label15.TabIndex = 14;
            label15.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(456, 302);
            label14.Name = "label14";
            label14.Size = new Size(93, 25);
            label14.TabIndex = 13;
            label14.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(456, 233);
            label13.Name = "label13";
            label13.Size = new Size(93, 25);
            label13.TabIndex = 12;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(456, 171);
            label12.Name = "label12";
            label12.Size = new Size(93, 25);
            label12.TabIndex = 11;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(313, 438);
            label11.Name = "label11";
            label11.Size = new Size(93, 25);
            label11.TabIndex = 10;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(313, 373);
            label10.Name = "label10";
            label10.Size = new Size(93, 25);
            label10.TabIndex = 9;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 302);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 233);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(313, 163);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 438);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 373);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 302);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 233);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 165);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 121);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 650);
            Controls.Add(MainPanel);
            Controls.Add(MenuPanel);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            MenuPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton QuestionsBtn;
        private FontAwesome.Sharp.IconButton ScoreBtn;
        private FontAwesome.Sharp.IconButton ExamsBtn;
        private FontAwesome.Sharp.IconButton ContactBtn;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconButton DashboardBtn;
        private Panel MainPanel;
        private Label label1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
       
    }
}