using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet1.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1 ;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = tbName.Text;
                nRow[4] = tbPhone.Text;
                nRow[5] = tbMail.Text;

                main.database1DataSet1.Tables[0].Rows.Add(nRow);
                main.поставкиTableAdapter.Update(main.database1DataSet1.Поставки);
                main.database1DataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                tbName.Text = "";
                tbPhone.Text = "";
                tbMail.Text = "";
                
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
