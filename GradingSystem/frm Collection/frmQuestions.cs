using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class FrmQuestion : Form
    {
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            RetrieveData();
        }

        private void RetrieveData()
        {
            var connection = new SqlConnection("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True"); // connection string!
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = new ();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select QuestionText, Option1, Option2, Option3, Option4, correct_answer, point from Questions";
            cmd.Connection = connection;
            SqlDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                // khai bao list view
                ListViewItem list = new (reader.GetString(0));
                list.SubItems.Add(reader.GetString(1));
                list.SubItems.Add(reader.GetString(2));
                list.SubItems.Add(reader.GetString(3));
                list.SubItems.Add(reader.GetString(4));
                list.SubItems.Add(reader.GetString(5));
                list.SubItems.Add(reader.GetDouble(6).ToString());

                listView1.Items.Add(list);
            }
            reader.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
