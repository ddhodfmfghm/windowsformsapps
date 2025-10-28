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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Предприятия main = this.Owner as Предприятия;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet1.Tables[1].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbPhone.Text;
                nRow[3] = tbMail.Text;
                nRow[4] = textBox1.Text;
                nRow[5] = textBox2.Text;
                nRow[6] = textBox3.Text;
                nRow[7] = textBox4.Text;





                main.database1DataSet1.Tables[1].Rows.Add(nRow);
                main.предприятияTableAdapter.Update(main.database1DataSet1.Предприятия);
                main.database1DataSet1.Tables[1].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbPhone.Text = "";
                tbMail.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }

        }

        private void add_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
