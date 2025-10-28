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
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
            SetupPermissions();
        }

        protected override void SetViewOnlyMode()
        {
            base.SetViewOnlyMode();
            SetControlsReadOnly(this);
            SetupReadOnlyDataGridView(dataGridView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet11.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.database1DataSet1.Поставки);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;
            поставкиTableAdapter.Update(database1DataSet1);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!CheckAdminAccess())
            {
                e.Cancel = true;
                return;
            }

            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;

            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Поиск доступен всем пользователям
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}