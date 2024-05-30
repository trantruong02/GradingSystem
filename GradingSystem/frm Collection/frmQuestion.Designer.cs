namespace GradingSystem.frm_Collection
{
    partial class frmQuestion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ListQuestions = new ListView();
            Question = new ColumnHeader();
            A = new ColumnHeader();
            B = new ColumnHeader();
            C = new ColumnHeader();
            D = new ColumnHeader();
            Answer = new ColumnHeader();
            point = new ColumnHeader();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            OptionD = new RadioButton();
            OptionB = new RadioButton();
            OptionC = new RadioButton();
            OptionA = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ListQuestions
            // 
            ListQuestions.Columns.AddRange(new ColumnHeader[] { Question, A, B, C, D, Answer, point });
            ListQuestions.FullRowSelect = true;
            ListQuestions.Location = new Point(12, 110);
            ListQuestions.Name = "ListQuestions";
            ListQuestions.Size = new Size(782, 268);
            ListQuestions.TabIndex = 2;
            ListQuestions.UseCompatibleStateImageBehavior = false;
            ListQuestions.View = View.Details;
            ListQuestions.ColumnWidthChanging += ListQuestions_ColumnWidthChanging;
            // 
            // Question
            // 
            Question.Text = "Question";
            Question.Width = 250;
            // 
            // A
            // 
            A.Text = "A";
            A.Width = 75;
            // 
            // B
            // 
            B.Text = "B";
            B.Width = 75;
            // 
            // C
            // 
            C.Text = "C";
            C.Width = 75;
            // 
            // D
            // 
            D.Text = "D";
            D.Width = 75;
            // 
            // Answer
            // 
            Answer.Text = "answer";
            Answer.Width = 163;
            // 
            // point
            // 
            point.Text = "point";
            point.Width = 65;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(34, 102, 141);
            guna2Button1.BorderRadius = 20;
            guna2Button1.BorderThickness = 1;
            guna2Button1.CustomizableEdges = customizableEdges17;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(693, 745);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(255, 132, 0);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Button1.Size = new Size(101, 40);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "Save";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderColor = Color.FromArgb(196, 12, 12);
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderThickness = 1;
            guna2Button2.CustomizableEdges = customizableEdges19;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(586, 745);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedColor = Color.FromArgb(255, 132, 0);
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Button2.Size = new Size(101, 40);
            guna2Button2.TabIndex = 4;
            guna2Button2.Text = "Delete";
            // 
            // guna2Button3
            // 
            guna2Button3.BorderColor = Color.FromArgb(80, 141, 105);
            guna2Button3.BorderRadius = 20;
            guna2Button3.BorderThickness = 1;
            guna2Button3.CustomizableEdges = customizableEdges21;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.Black;
            guna2Button3.Location = new Point(12, 745);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.PressedColor = Color.FromArgb(255, 132, 0);
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Button3.Size = new Size(101, 40);
            guna2Button3.TabIndex = 4;
            guna2Button3.Text = "Export";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderColor = Color.LightGray;
            guna2GroupBox1.BorderRadius = 20;
            guna2GroupBox1.Controls.Add(OptionD);
            guna2GroupBox1.Controls.Add(label2);
            guna2GroupBox1.Controls.Add(OptionA);
            guna2GroupBox1.Controls.Add(OptionB);
            guna2GroupBox1.Controls.Add(OptionC);
            guna2GroupBox1.CustomBorderColor = Color.Transparent;
            guna2GroupBox1.CustomizableEdges = customizableEdges23;
            guna2GroupBox1.FillColor = Color.Transparent;
            guna2GroupBox1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(800, 110);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2GroupBox1.Size = new Size(376, 675);
            guna2GroupBox1.TabIndex = 6;
            guna2GroupBox1.Text = "Question Details";
            // 
            // OptionD
            // 
            OptionD.AutoSize = true;
            OptionD.Font = new Font("Bookman Old Style", 10.8F);
            OptionD.ForeColor = Color.Black;
            OptionD.Location = new Point(253, 381);
            OptionD.Name = "OptionD";
            OptionD.Size = new Size(50, 24);
            OptionD.TabIndex = 8;
            OptionD.TabStop = true;
            OptionD.Text = "D.";
            OptionD.UseVisualStyleBackColor = true;
            // 
            // OptionB
            // 
            OptionB.AutoSize = true;
            OptionB.Font = new Font("Bookman Old Style", 10.8F);
            OptionB.ForeColor = Color.Black;
            OptionB.Location = new Point(253, 278);
            OptionB.Name = "OptionB";
            OptionB.Size = new Size(49, 24);
            OptionB.TabIndex = 9;
            OptionB.TabStop = true;
            OptionB.Text = "B.";
            OptionB.UseVisualStyleBackColor = true;
            // 
            // OptionC
            // 
            OptionC.AutoSize = true;
            OptionC.Font = new Font("Bookman Old Style", 10.8F);
            OptionC.ForeColor = Color.Black;
            OptionC.Location = new Point(76, 381);
            OptionC.Name = "OptionC";
            OptionC.Size = new Size(49, 24);
            OptionC.TabIndex = 10;
            OptionC.TabStop = true;
            OptionC.Text = "C.";
            OptionC.UseVisualStyleBackColor = true;
            // 
            // OptionA
            // 
            OptionA.AutoSize = true;
            OptionA.Font = new Font("Bookman Old Style", 10.8F);
            OptionA.ForeColor = Color.Black;
            OptionA.Location = new Point(76, 278);
            OptionA.Name = "OptionA";
            OptionA.Size = new Size(48, 24);
            OptionA.TabIndex = 11;
            OptionA.TabStop = true;
            OptionA.Text = "A.";
            OptionA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 10.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(47, 161);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 7;
            label2.Text = "Question";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 36);
            label1.TabIndex = 7;
            label1.Text = "Add Questions";
            // 
            // frmQuestion
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 797);
            Controls.Add(guna2GroupBox1);
            Controls.Add(label1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button1);
            Controls.Add(ListQuestions);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmQuestion";
            Text = "frmQuestion";
            Load += frmQuestion_Load;
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ListQuestions;
        private ColumnHeader Question;
        private ColumnHeader A;
        private ColumnHeader B;
        private ColumnHeader C;
        private ColumnHeader D;
        private ColumnHeader Answer;
        private ColumnHeader point;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private RadioButton OptionD;
        private Label label2;
        private RadioButton OptionA;
        private RadioButton OptionB;
        private RadioButton OptionC;
        private Label label1;
    }
}