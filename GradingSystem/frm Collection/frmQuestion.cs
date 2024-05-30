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

        private void frmQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
