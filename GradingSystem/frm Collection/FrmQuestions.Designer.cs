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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LstQuestion = new ListView();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            AddButton = new Guna.UI2.WinForms.Guna2Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            guna2Panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LstQuestion
            // 
            LstQuestion.Location = new Point(12, 176);
            LstQuestion.Name = "LstQuestion";
            LstQuestion.Size = new Size(1001, 526);
            LstQuestion.TabIndex = 6;
            LstQuestion.UseCompatibleStateImageBehavior = false;
            LstQuestion.MouseClick += LstQuestion_MouseClick;
            LstQuestion.MouseDoubleClick += LstQuestion_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 8;
            label1.Text = "Created";
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoRoundedCorners = true;
            guna2Panel1.BorderRadius = 50;
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(12, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(312, 102);
            guna2Panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(13, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 41);
            label2.TabIndex = 8;
            label2.Text = "0";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.BorderColor = Color.Transparent;
            AddButton.BorderRadius = 13;
            AddButton.BorderThickness = 1;
            AddButton.CustomizableEdges = customizableEdges3;
            AddButton.DisabledState.BorderColor = Color.DarkGray;
            AddButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddButton.FillColor = Color.FromArgb(13, 127, 242);
            AddButton.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageAlign = HorizontalAlignment.Left;
            AddButton.ImageOffset = new Point(6, -1);
            AddButton.ImageSize = new Size(15, 15);
            AddButton.Location = new Point(891, 12);
            AddButton.Name = "AddButton";
            AddButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AddButton.Size = new Size(122, 37);
            AddButton.TabIndex = 10;
            AddButton.Text = "Create";
            AddButton.TextAlign = HorizontalAlignment.Right;
            AddButton.TextOffset = new Point(0, -1);
            AddButton.Click += AddButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // FrmQuestion
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 714);
            Controls.Add(AddButton);
            Controls.Add(guna2Panel1);
            Controls.Add(LstQuestion);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmQuestion";
            Text = "Questions";
            Load += FrmQuestion_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView LstQuestion;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}