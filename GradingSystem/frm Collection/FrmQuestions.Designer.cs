namespace GradingSystem
{
    partial class FrmQuestion
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LstQuestion = new ListView();
            AddButton = new Guna.UI2.WinForms.Guna2Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LstQuestion
            // 
            LstQuestion.Location = new Point(12, 152);
            LstQuestion.Name = "LstQuestion";
            LstQuestion.Size = new Size(1001, 550);
            LstQuestion.TabIndex = 6;
            LstQuestion.UseCompatibleStateImageBehavior = false;
            LstQuestion.MouseClick += LstQuestion_MouseClick;
            LstQuestion.MouseDoubleClick += LstQuestion_MouseDoubleClick;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.BorderColor = Color.Transparent;
            AddButton.BorderRadius = 5;
            AddButton.BorderThickness = 1;
            AddButton.CustomizableEdges = customizableEdges1;
            AddButton.DisabledState.BorderColor = Color.DarkGray;
            AddButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddButton.FillColor = Color.FromArgb(13, 127, 242);
            AddButton.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageAlign = HorizontalAlignment.Left;
            AddButton.ImageOffset = new Point(0, -1);
            AddButton.ImageSize = new Size(15, 15);
            AddButton.Location = new Point(907, 12);
            AddButton.Name = "AddButton";
            AddButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddButton.Size = new Size(106, 35);
            AddButton.TabIndex = 10;
            AddButton.Text = "Create";
            AddButton.TextAlign = HorizontalAlignment.Right;
            AddButton.TextOffset = new Point(2, -1);
            AddButton.Click += AddButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(210, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // searchBox
            // 
            searchBox.BorderRadius = 18;
            searchBox.CustomizableEdges = customizableEdges3;
            searchBox.DefaultText = "";
            searchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.DarkGray;
            searchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.IconRight = (Image)resources.GetObject("searchBox.IconRight");
            searchBox.IconRightOffset = new Point(8, -1);
            searchBox.Location = new Point(326, 13);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PasswordChar = '\0';
            searchBox.PlaceholderForeColor = Color.DarkGray;
            searchBox.PlaceholderText = "Search";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            searchBox.Size = new Size(365, 36);
            searchBox.TabIndex = 12;
            searchBox.TextOffset = new Point(3, -1);
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // FrmQuestion
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 714);
            Controls.Add(searchBox);
            Controls.Add(AddButton);
            Controls.Add(LstQuestion);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmQuestion";
            Text = "Questions";
            Load += FrmQuestion_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        public ListView LstQuestion;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
    }
}