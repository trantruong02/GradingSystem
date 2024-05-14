namespace GradingSystem.frm_Collection
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            DateLbl = new Label();
            TimeLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            StuGr = new GroupBox();
            pictureBox1 = new PictureBox();
            NOStu = new Label();
            TotalStudent = new Label();
            QuesGr = new GroupBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            TotalQues = new Label();
            NOQuestions = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            StuGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            QuesGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("LCDMono2", 22.2F);
            DateLbl.ForeColor = Color.FromArgb(254, 122, 54);
            DateLbl.Location = new Point(302, 29);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(204, 32);
            DateLbl.TabIndex = 1;
            DateLbl.Text = "00/00/0000";
            // 
            // TimeLbl
            // 
            TimeLbl.AutoSize = true;
            TimeLbl.Font = new Font("LCDMono2", 22.2F);
            TimeLbl.ForeColor = Color.FromArgb(254, 122, 54);
            TimeLbl.Location = new Point(15, 29);
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new Size(166, 32);
            TimeLbl.TabIndex = 1;
            TimeLbl.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(631, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 216);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 8);
            label3.Name = "label3";
            label3.Size = new Size(36, 28);
            label3.TabIndex = 6;
            label3.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 17);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 6;
            label2.Text = "Profile";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(631, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 340);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 20);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "Upcoming ";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 91);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(245, 239, 230);
            groupBox2.Controls.Add(DateLbl);
            groupBox2.Controls.Add(TimeLbl);
            groupBox2.Location = new Point(12, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(613, 84);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // StuGr
            // 
            StuGr.Controls.Add(pictureBox1);
            StuGr.Controls.Add(NOStu);
            StuGr.Controls.Add(TotalStudent);
            StuGr.Location = new Point(12, 292);
            StuGr.Name = "StuGr";
            StuGr.Size = new Size(309, 87);
            StuGr.TabIndex = 7;
            StuGr.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._7309700;
            pictureBox1.Image = Properties.Resources._7309700;
            pictureBox1.Location = new Point(15, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // NOStu
            // 
            NOStu.AutoSize = true;
            NOStu.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NOStu.ForeColor = SystemColors.GrayText;
            NOStu.Location = new Point(84, 51);
            NOStu.Name = "NOStu";
            NOStu.Size = new Size(40, 26);
            NOStu.TabIndex = 3;
            NOStu.Text = "00";
            // 
            // TotalStudent
            // 
            TotalStudent.AutoSize = true;
            TotalStudent.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalStudent.ForeColor = Color.DarkGray;
            TotalStudent.Location = new Point(84, 24);
            TotalStudent.Name = "TotalStudent";
            TotalStudent.Size = new Size(77, 19);
            TotalStudent.TabIndex = 4;
            TotalStudent.Text = "Students";
            // 
            // QuesGr
            // 
            QuesGr.Controls.Add(iconPictureBox1);
            QuesGr.Controls.Add(TotalQues);
            QuesGr.Controls.Add(NOQuestions);
            QuesGr.Location = new Point(327, 292);
            QuesGr.Name = "QuesGr";
            QuesGr.Size = new Size(298, 87);
            QuesGr.TabIndex = 7;
            QuesGr.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = Color.DimGray;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            iconPictureBox1.IconColor = Color.DimGray;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new Point(17, 24);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Padding = new Padding(3, 3, 0, 0);
            iconPictureBox1.Size = new Size(57, 53);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // TotalQues
            // 
            TotalQues.AutoSize = true;
            TotalQues.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalQues.ForeColor = Color.DarkGray;
            TotalQues.Location = new Point(89, 24);
            TotalQues.Name = "TotalQues";
            TotalQues.Size = new Size(127, 19);
            TotalQues.TabIndex = 8;
            TotalQues.Text = "Total Questions";
            // 
            // NOQuestions
            // 
            NOQuestions.AutoSize = true;
            NOQuestions.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NOQuestions.ForeColor = SystemColors.GrayText;
            NOQuestions.Location = new Point(89, 51);
            NOQuestions.Name = "NOQuestions";
            NOQuestions.Size = new Size(40, 26);
            NOQuestions.TabIndex = 9;
            NOQuestions.Text = "00";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(613, 199);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(513, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "View all";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 8;
            label1.Text = "Rankings";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(613, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(332, 20);
            label5.Name = "label5";
            label5.Size = new Size(36, 28);
            label5.TabIndex = 6;
            label5.Text = "...";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 586);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(QuesGr);
            Controls.Add(StuGr);
            Controls.Add(groupBox3);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDashboard";
            Text = "frmDashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            StuGr.ResumeLayout(false);
            StuGr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            QuesGr.ResumeLayout(false);
            QuesGr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label TimeLbl;
        private Label DateLbl;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox StuGr;
        private PictureBox pictureBox1;
        private Label NOStu;
        private Label TotalStudent;
        private GroupBox QuesGr;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label TotalQues;
        private Label NOQuestions;
        private GroupBox groupBox3;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label5;
    }
}