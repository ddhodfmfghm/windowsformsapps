using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.database1DataSet1TableAdapters;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void предприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Предприятия form1 = new Предприятия();
            form1.Show();        
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            m1.Show();
            this.Close();
        }

        private void ПродукцияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Продукция form1 = new Продукция();
            form1.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
