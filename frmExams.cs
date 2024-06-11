using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GradingSystem.frm_Collection
{
    public partial class FrmExams : Form
    {
        public FrmExams()
        {
            InitializeComponent();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string examName = textBox1.Text;
            label4.Text = examName;

            //using (SqlConnection connection = new(connectionString))
            //    {
            //        connection.Open();
            //        string query = "insert into Exams (exam_id , course_id, start_time, end_time, teacher_id) values (@exam_id, @course_id, @start_time, @end_time, @teacher_id)";
            //        using (SqlCommand command = new(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@exam_id", exam_id);
            //            command.Parameters.AddWithValue("@course_id", course_id);
            //            command.Parameters.AddWithValue("@start_time", start_time);
            //            command.Parameters.AddWithValue("@end_time", end_time);
            //            command.Parameters.AddWithValue("@teacher_id", teacher_id);

            //            result = command.ExecuteNonQuery();
            //        }
            //    }


            //return result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";//file questions what type?
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }



        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{
        //    numericUpDown1.Maximum = 5;
        //    numericUpDown1.Minimum = 0;
        //}

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 59;
            numericUpDown2.Minimum = 0;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 59;
            numericUpDown2.Minimum = 0;
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //guna2DateTimePicker2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
