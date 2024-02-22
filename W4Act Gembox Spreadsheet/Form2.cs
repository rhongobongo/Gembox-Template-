using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4Act_Gembox_Spreadsheet
{
    
    public partial class DataInfoForm : Form
    {
        MainForm mainForm1;
        public DataInfoForm(MainForm mainForm)
        {
            InitializeComponent();
            mainForm1 = mainForm;
        }

        private void btnInputDone_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = input1.Text;
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = input2.Text;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = input3.Text;
                row.Cells.Add(cell3);

                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                cell4.Value = input4.Text;
                row.Cells.Add(cell4);

                DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
                cell5.Value = input5.Text;
                row.Cells.Add(cell5);

                mainForm1.AddRows(row);
                this.Close();
            }
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void input3_TextChanged(object sender, EventArgs e)
        {

        }

        private void input4_TextChanged(object sender, EventArgs e)
        {

        }

        private void input5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
