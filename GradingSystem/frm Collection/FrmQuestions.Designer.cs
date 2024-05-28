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
            QuestionPageLbl = new Label();
            EditBtn = new Guna.UI2.WinForms.Guna2Button();
            SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            ExportBtn = new Guna.UI2.WinForms.Guna2Button();
            listView1 = new ListView();
            Question = new ColumnHeader();
            Option1 = new ColumnHeader();
            Option2 = new ColumnHeader();
            Option3 = new ColumnHeader();
            Option4 = new ColumnHeader();
            Answer = new ColumnHeader();
            Point = new ColumnHeader();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.BorderRadius = 35;
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel2.FillColor = Color.FromArgb(252, 255, 224);
            guna2CustomGradientPanel2.FillColor2 = Color.FromArgb(117, 164, 127);
            guna2CustomGradientPanel2.FillColor3 = Color.FromArgb(252, 255, 224);
            guna2CustomGradientPanel2.FillColor4 = Color.FromArgb(252, 255, 224);
            guna2CustomGradientPanel2.Location = new Point(342, 12);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel2.Size = new Size(671, 583);
            guna2CustomGradientPanel2.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BorderRadius = 35;
            guna2CustomGradientPanel1.Controls.Add(guna2DataGridView1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(198, 61, 47);
            guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(255, 155, 80);
            guna2CustomGradientPanel1.Location = new Point(12, 12);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(313, 583);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(16, 120);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(300, 188);
            guna2DataGridView1.TabIndex = 0;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // EditBtn
            // 
            EditBtn.BorderColor = Color.FromArgb(34, 102, 141);
            EditBtn.BorderRadius = 20;
            EditBtn.BorderThickness = 1;
            EditBtn.CustomizableEdges = customizableEdges13;
            EditBtn.DisabledState.BorderColor = Color.DarkGray;
            EditBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            EditBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EditBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EditBtn.FillColor = Color.Transparent;
            EditBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.FromArgb(34, 102, 141);
            EditBtn.Location = new Point(12, 696);
            EditBtn.Name = "EditBtn";
            EditBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            EditBtn.Size = new Size(108, 39);
            EditBtn.TabIndex = 1;
            EditBtn.Text = "Edit";
            // 
            // SaveBtn
            // 
            SaveBtn.BorderColor = Color.FromArgb(34, 102, 141);
            SaveBtn.BorderRadius = 20;
            SaveBtn.BorderThickness = 1;
            SaveBtn.CustomizableEdges = customizableEdges15;
            SaveBtn.DisabledState.BorderColor = Color.DarkGray;
            SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveBtn.FillColor = Color.Transparent;
            SaveBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.FromArgb(34, 102, 141);
            SaveBtn.Location = new Point(126, 696);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            SaveBtn.Size = new Size(108, 39);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Save";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.BorderColor = Color.FromArgb(34, 102, 141);
            ExportBtn.BorderRadius = 20;
            ExportBtn.BorderThickness = 1;
            ExportBtn.CustomizableEdges = customizableEdges17;
            ExportBtn.DisabledState.BorderColor = Color.DarkGray;
            ExportBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ExportBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExportBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExportBtn.FillColor = Color.Transparent;
            ExportBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExportBtn.ForeColor = Color.FromArgb(34, 102, 141);
            ExportBtn.Location = new Point(642, 696);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.ShadowDecoration.CustomizableEdges = customizableEdges18;
            ExportBtn.Size = new Size(108, 39);
            ExportBtn.TabIndex = 1;
            ExportBtn.Text = "Export";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Question, Option1, Option2, Option3, Option4, Answer, Point });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(729, 552);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Question
            // 
            Question.Text = "Question";
            Question.Width = 200;
            // 
            // Option1
            // 
            Option1.Text = "A";
            Option1.Width = 90;
            // 
            // Option2
            // 
            Option2.Text = "B";
            Option2.Width = 90;
            // 
            // Option3
            // 
            Option3.Text = "C";
            Option3.Width = 90;
            // 
            // Option4
            // 
            Option4.Text = "D";
            Option4.Width = 90;
            // 
            // Answer
            // 
            Answer.Text = "Answer";
            Answer.Width = 90;
            // 
            // Point
            // 
            Point.Text = "Point";
            // 
            // FrmQuestion
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 607);
            Controls.Add(QuestionPageLbl);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmQuestion";
            Text = "Questions";
            ResumeLayout(false);
        }

        #endregion
        private Label QuestionPageLbl;
    }
}