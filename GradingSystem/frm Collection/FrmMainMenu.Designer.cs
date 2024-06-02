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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ExamsBtn = new FontAwesome.Sharp.IconButton();
            DashboardBtn = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            MainPanel = new Panel();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(255, 132, 0);
            MenuPanel.Controls.Add(LogoutBtn);
            MenuPanel.Controls.Add(ContactBtn);
            MenuPanel.Controls.Add(ScoreBtn);
            MenuPanel.Controls.Add(iconButton1);
            MenuPanel.Controls.Add(ExamsBtn);
            MenuPanel.Controls.Add(DashboardBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(214, 855);
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
            LogoutBtn.Location = new Point(0, 795);
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
            ContactBtn.Location = new Point(0, 423);
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
            ScoreBtn.Location = new Point(0, 336);
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
            // iconButton1
            // 
            iconButton1.AccessibleDescription = "Insert, view or delete questions in exams";
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(255, 132, 0);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 165);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(214, 60);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "   Questions";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += QuestionsBtn_Click;
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
            ExamsBtn.Location = new Point(0, 249);
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
            DashboardBtn.Location = new Point(0, 75);
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
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(214, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 43);
            panel1.TabIndex = 4;
            panel1.MouseDown += PanelMove_MouseDown;
            panel1.MouseMove += PanelMove_MouseMove;
            panel1.MouseUp += PanelMove_MouseUp;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(214, 43);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1188, 812);
            MainPanel.TabIndex = 5;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 855);
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
            ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}