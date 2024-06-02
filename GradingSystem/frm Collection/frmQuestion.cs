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

namespace GradingSystem.frm_Collection
{
    public partial class frmQuestion : Form
    {
        public frmQuestion()
        {
            InitializeComponent();
        }

        private void ListQuestions_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Cancel the event to prevent the column from being resized
            e.Cancel = true;

            // Set the NewWidth to the current width to prevent visual resizing
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
        }

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True";
            return conn;
        }

        public DataSet GetData(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new(cmd);
            DataSet ds = new();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query, string msg)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information");
        }

        public SqlDataReader getForCombo(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            /*string query = "select max(QID) from Questions";
            DataSet ds = GetData(query);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                ID.Text = (id + 1).ToString();
            }
            else
            {
                ID.Text = "1";
            }*/
        }

        private string SelectAnswer()
        {
            if (OptionA.Checked) { return "A"; } else if(OptionB.Checked) { return "B"; } else if (OptionC.Checked) { return "C"; } else {  return "D"; }
        }

        private bool Check_selection(RadioButton rb)
        {
            if (rb.Checked) { return true; } else { return false; }
        }

        SqlConnection con = new(@"Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True");
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QuestionText.Text == "" || Check_selection(OptionA) || 
        }
    }
}
