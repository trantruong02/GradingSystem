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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GradingSystem.frm_Collection
{
    public partial class frmForgotPw : Form
    {
        public frmForgotPw()
        {
            InitializeComponent();
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin loginForm = new();
            loginForm.ShowDialog();
            this.Close();
        }
        private static bool IsTextboxEmpty(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }

                using (SqlCommand cmd = new (query, con))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue ("password", NewPw);

                    // thuc thi truy van 
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Sign up success");
                    }
                    else
                    {
                        MessageBox.Show("Sign up failed");
                    }
                }
            }
        }
    }
}
