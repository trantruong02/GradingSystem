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
            panel1 = new Panel();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(255, 132, 0);
            MenuPanel.Controls.Add(LogoutBtn);
            MenuPanel.Controls.Add(ContactBtn);
            MenuPanel.Controls.Add(ScoreBtn);
            MenuPanel.Controls.Add(ExamsBtn);
            MenuPanel.Controls.Add(DashboardBtn);
            MenuPanel.Controls.Add(QuestionsBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(214, 790);
            MenuPanel.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(255, 132, 0);
            LogoutBtn.Dock = DockStyle.Bottom;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.Black;
            LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            LogoutBtn.IconColor = Color.Black;
            LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoutBtn.IconSize = 35;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(0, 730);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Padding = new Padding(10, 0, 20, 0);
            LogoutBtn.Rotation = 180D;
            LogoutBtn.Size = new Size(214, 60);
            LogoutBtn.TabIndex = 15;
            LogoutBtn.Text = "  Logout";
            LogoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ContactBtn
            // 
            ContactBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactBtn.BackColor = Color.FromArgb(255, 132, 0);
            ContactBtn.FlatAppearance.BorderSize = 0;
            ContactBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ContactBtn.ForeColor = Color.Black;
            ContactBtn.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            ContactBtn.IconColor = Color.Black;
            ContactBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ContactBtn.IconSize = 38;
            ContactBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ContactBtn.Location = new Point(0, 384);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Padding = new Padding(10, 0, 20, 0);
            ContactBtn.Size = new Size(214, 60);
            ContactBtn.TabIndex = 14;
            ContactBtn.Text = "  Contact us";
            ContactBtn.TextAlign = ContentAlignment.MiddleLeft;
            ContactBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ContactBtn.UseVisualStyleBackColor = false;
            ContactBtn.Click += ContactBtn_Click;
            // 
            // ScoreBtn
            // 
            ScoreBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreBtn.BackColor = Color.FromArgb(255, 132, 0);
            ScoreBtn.FlatAppearance.BorderSize = 0;
            ScoreBtn.FlatStyle = FlatStyle.Flat;
            ScoreBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ScoreBtn.ForeColor = Color.Black;
            ScoreBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            ScoreBtn.IconColor = Color.Black;
            ScoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ScoreBtn.IconSize = 40;
            ScoreBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.Location = new Point(0, 297);
            ScoreBtn.Name = "ScoreBtn";
            ScoreBtn.Padding = new Padding(10, 0, 20, 0);
            ScoreBtn.Size = new Size(214, 60);
            ScoreBtn.TabIndex = 13;
            ScoreBtn.Text = "  Score";
            ScoreBtn.TextAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ScoreBtn.UseVisualStyleBackColor = false;
            ScoreBtn.Click += ScoreBtn_Click;
            // 
            // ExamsBtn
            // 
            ExamsBtn.AccessibleDescription = "Insert, view or delete questions in exams";
            ExamsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExamsBtn.BackColor = Color.FromArgb(255, 132, 0);
            ExamsBtn.FlatAppearance.BorderSize = 0;
            ExamsBtn.FlatStyle = FlatStyle.Flat;
            ExamsBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ExamsBtn.ForeColor = Color.Black;
            ExamsBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            ExamsBtn.IconColor = Color.Black;
            ExamsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExamsBtn.IconSize = 35;
            ExamsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.Location = new Point(0, 210);
            ExamsBtn.Name = "ExamsBtn";
            ExamsBtn.Padding = new Padding(10, 0, 20, 0);
            ExamsBtn.Size = new Size(214, 60);
            ExamsBtn.TabIndex = 12;
            ExamsBtn.Text = "   Exams";
            ExamsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExamsBtn.UseVisualStyleBackColor = false;
            ExamsBtn.Click += ExamsBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DashboardBtn.BackColor = Color.FromArgb(255, 132, 0);
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = Color.Black;
            DashboardBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            DashboardBtn.IconColor = Color.Black;
            DashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DashboardBtn.IconSize = 38;
            DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.Location = new Point(0, 36);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Padding = new Padding(10, 0, 20, 0);
            DashboardBtn.Size = new Size(214, 60);
            DashboardBtn.TabIndex = 10;
            DashboardBtn.Text = "  Dashboard";
            DashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // QuestionsBtn
            // 
            QuestionsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuestionsBtn.BackColor = Color.FromArgb(255, 132, 0);
            QuestionsBtn.FlatAppearance.BorderSize = 0;
            QuestionsBtn.FlatStyle = FlatStyle.Flat;
            QuestionsBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            QuestionsBtn.ForeColor = Color.Black;
            QuestionsBtn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            QuestionsBtn.IconColor = Color.Black;
            QuestionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            QuestionsBtn.IconSize = 40;
            QuestionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.Location = new Point(0, 123);
            QuestionsBtn.Name = "QuestionsBtn";
            QuestionsBtn.Padding = new Padding(10, 0, 20, 0);
            QuestionsBtn.Size = new Size(214, 60);
            QuestionsBtn.TabIndex = 11;
            QuestionsBtn.Text = "  Questions";
            QuestionsBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            QuestionsBtn.UseVisualStyleBackColor = false;
            QuestionsBtn.Click += QuestionsBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(214, 43);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1166, 747);
            MainPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(214, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 43);
            panel1.TabIndex = 4;
            panel1.MouseDown += PanelMove_MouseDown;
            panel1.MouseMove += PanelMove_MouseMove;
            panel1.MouseUp += PanelMove_MouseUp;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 790);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Controls.Add(MenuPanel);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            MenuPanel.ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel MenuPanel;
        private Panel MainPanel;
        private Label label1;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconButton ContactBtn;
        private FontAwesome.Sharp.IconButton ScoreBtn;
        private FontAwesome.Sharp.IconButton ExamsBtn;
        private FontAwesome.Sharp.IconButton DashboardBtn;
        private Panel MainPanel;
    }
}