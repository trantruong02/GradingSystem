using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Core;
using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;

namespace GradingSystem.frm_Collection
{
    public partial class frmMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        bool drag = false;
        Point starting_point = new(0, 0);
        string connectionString = "Data Source=JENLAP\\MSSQLSERVERNO;Initial Catalog=GradingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        GroupBox groupBox1 = new GroupBox();


        public frmMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new();
            leftBorderBtn.Size = new(7, 60);
            MenuPanel.Controls.Add(leftBorderBtn);

            //this.MainPanel.Controls.Clear();
            frmDashboard Home = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            Home.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(Home);
            //Home.Show();
            getTests();
        }

        // 255, 204, 112
        // mau nen: 255, 250, 221
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(90, 178, 255);
            public static Color color2 = Color.FromArgb(132, 55, 173); // tim sang 
            public static Color color3 = Color.FromArgb(202, 244, 255);
            public static Color color4 = Color.FromArgb(205, 232, 229);
            public static Color color5 = Color.FromArgb(122, 178, 178);
            public static Color color6 = Color.FromArgb(77, 134, 156);
        }

        private void ActiveButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                // button
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // left border button
                leftBorderBtn.BackColor = Color.Black;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(34, 102, 141);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            this.MainPanel.Controls.Clear();
            frmDashboard frmDashboard = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmDashboard);
            //frmDashboard.Show();
            
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit this window?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.OK) { this.Close(); } else { return; }
        }

        private void QuestionsBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);

            this.MainPanel.Controls.Clear();
            FrmQuestion frmQues = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmQues.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmQues);
            frmQues.Show();

        }

        private void ExamsBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);

            this.MainPanel.Controls.Clear();
            FrmExams frmExams = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmExams.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmExams);
            frmExams.Show();
        }

        private void ScoreBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            this.MainPanel.Controls.Clear();
            FrmExams frmExams = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmExams.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmExams);
            frmExams.Show();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            this.MainPanel.Controls.Clear();
            FrmExams frmExams = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmExams.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmExams);
            frmExams.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        // make taskbar 
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            starting_point = new Point(e.X, e.Y);
        }

        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - starting_point.X, p.Y - starting_point.Y);
            }
        }

        private void PanelMove_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void getTests()
        {
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand query = new SqlCommand("SELECT TOP 3 * from Exams", connection);
                using (SqlDataReader oReader = query.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        foreach (Label ctrl in groupBox1.Controls.OfType<Label>())
                        {
                            label2.Text = oReader["start_time"].ToString();
                            ctrl.Text = ctrl.Text + oReader["start_time"].ToString();
                        }

                     }

                    connection.Close();
                }
            }
            
        }
    }
}
