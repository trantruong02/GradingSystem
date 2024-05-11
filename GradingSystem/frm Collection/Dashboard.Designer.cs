namespace GradingSystem.frm_Collection
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            MenuPanel = new Panel();
            ContactBtn = new FontAwesome.Sharp.IconButton();
            ScoreBtn = new FontAwesome.Sharp.IconButton();
            ExamsBtn = new FontAwesome.Sharp.IconButton();
            HomeBtn = new FontAwesome.Sharp.IconButton();
            QuestionsBtn = new FontAwesome.Sharp.IconButton();
            LogoutBtn = new FontAwesome.Sharp.IconButton();
            PanelMove = new Panel();
            MainPanel = new Panel();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.White;
            MenuPanel.Controls.Add(ContactBtn);
            MenuPanel.Controls.Add(ScoreBtn);
            MenuPanel.Controls.Add(ExamsBtn);
            MenuPanel.Controls.Add(HomeBtn);
            MenuPanel.Controls.Add(QuestionsBtn);
            MenuPanel.Controls.Add(LogoutBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(220, 759);
            MenuPanel.TabIndex = 1;
            // 
            // ContactBtn
            // 
            ContactBtn.FlatAppearance.BorderSize = 0;
            ContactBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            ContactBtn.IconColor = Color.Black;
            ContactBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ContactBtn.IconSize = 38;
            ContactBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ContactBtn.Location = new Point(0, 419);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Padding = new Padding(10, 0, 20, 0);
            ContactBtn.Size = new Size(220, 60);
            ContactBtn.TabIndex = 8;
            ContactBtn.Text = "    Contact us";
            ContactBtn.TextAlign = ContentAlignment.MiddleLeft;
            ContactBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ContactBtn.UseVisualStyleBackColor = true;
            ContactBtn.Click += ContactBtn_Click;
            // 
            // ScoreBtn
            // 
            ScoreBtn.FlatAppearance.BorderSize = 0;
            ScoreBtn.FlatStyle = FlatStyle.Flat;
            ScoreBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            ScoreBtn.IconColor = Color.Black;
            ScoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ScoreBtn.IconSize = 40;
            ScoreBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.Location = new Point(0, 332);
            ScoreBtn.Name = "ScoreBtn";
            ScoreBtn.Padding = new Padding(10, 0, 20, 0);
            ScoreBtn.Size = new Size(220, 60);
            ScoreBtn.TabIndex = 5;
            ScoreBtn.Text = "    Score";
            ScoreBtn.TextAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ScoreBtn.UseVisualStyleBackColor = true;
            ScoreBtn.Click += ScoreBtn_Click;
            // 
            // ExamsBtn
            // 
            ExamsBtn.AccessibleDescription = "Insert, view or delete questions in exams";
            ExamsBtn.FlatAppearance.BorderSize = 0;
            ExamsBtn.FlatStyle = FlatStyle.Flat;
            ExamsBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            ExamsBtn.IconColor = Color.Black;
            ExamsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExamsBtn.IconSize = 35;
            ExamsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.Location = new Point(0, 245);
            ExamsBtn.Name = "ExamsBtn";
            ExamsBtn.Padding = new Padding(10, 0, 20, 0);
            ExamsBtn.Size = new Size(220, 60);
            ExamsBtn.TabIndex = 3;
            ExamsBtn.Text = "    Exams";
            ExamsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExamsBtn.UseVisualStyleBackColor = true;
            ExamsBtn.Click += ExamsBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            HomeBtn.IconColor = Color.Black;
            HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HomeBtn.IconSize = 38;
            HomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBtn.Location = new Point(0, 71);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Padding = new Padding(10, 0, 20, 0);
            HomeBtn.Size = new Size(220, 60);
            HomeBtn.TabIndex = 2;
            HomeBtn.Text = "    Home";
            HomeBtn.TextAlign = ContentAlignment.MiddleLeft;
            HomeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += QuestionsBtn_Click;
            // 
            // QuestionsBtn
            // 
            QuestionsBtn.FlatAppearance.BorderSize = 0;
            QuestionsBtn.FlatStyle = FlatStyle.Flat;
            QuestionsBtn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            QuestionsBtn.IconColor = Color.Black;
            QuestionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            QuestionsBtn.IconSize = 40;
            QuestionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.Location = new Point(0, 158);
            QuestionsBtn.Name = "QuestionsBtn";
            QuestionsBtn.Padding = new Padding(10, 0, 20, 0);
            QuestionsBtn.Size = new Size(220, 60);
            QuestionsBtn.TabIndex = 2;
            QuestionsBtn.Text = "    Questions";
            QuestionsBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            QuestionsBtn.UseVisualStyleBackColor = true;
            QuestionsBtn.Click += QuestionsBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Dock = DockStyle.Bottom;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            LogoutBtn.IconColor = Color.Black;
            LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoutBtn.IconSize = 35;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(0, 699);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Padding = new Padding(10, 0, 20, 0);
            LogoutBtn.Size = new Size(220, 60);
            LogoutBtn.TabIndex = 9;
            LogoutBtn.Text = "    Logout";
            LogoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // PanelMove
            // 
            PanelMove.Dock = DockStyle.Top;
            PanelMove.Location = new Point(220, 0);
            PanelMove.Name = "PanelMove";
            PanelMove.Size = new Size(1019, 40);
            PanelMove.TabIndex = 2;
            PanelMove.MouseDown += PanelMove_MouseDown;
            PanelMove.MouseMove += PanelMove_MouseMove;
            PanelMove.MouseUp += PanelMove_MouseUp;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(220, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1019, 759);
            MainPanel.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 759);
            Controls.Add(PanelMove);
            Controls.Add(MainPanel);
            Controls.Add(MenuPanel);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton QuestionsBtn;
        private FontAwesome.Sharp.IconButton ScoreBtn;
        private FontAwesome.Sharp.IconButton ExamsBtn;
        private FontAwesome.Sharp.IconButton ContactBtn;
        private Panel PanelMove;
        private Panel MainPanel;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
    }
}