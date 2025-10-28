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
    public partial class add2 : Form
    {
        public add2()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Продукция main = this.Owner as Продукция;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet1.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbPhone.Text;
                nRow[3] = tbMail.Text;


                main.database1DataSet1.Tables[2].Rows.Add(nRow);
                main.продукцияTableAdapter.Update(main.database1DataSet1.Продукция);
                main.database1DataSet1.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbPhone.Text = "";
                tbMail.Text = "";

            }
        }

        private void tbPhoto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
