using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.database1DataSetTableAdapters;

namespace WindowsFormsApp5
{
    public partial class Продукция : BaseForm
    {
        public Продукция()
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

        private void Доставка_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Продукция". При необходимости она может быть перемещена или удалена.
            this.продукцияTableAdapter.Fill(this.database1DataSet1.Продукция);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Поиск доступен всем пользователям
            s2 sf = new s2();
            sf.Owner = this;
            sf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;
            продукцияTableAdapter.Update(database1DataSet1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;

            add2 af = new add2();
            af.Owner = this;
            af.Show();
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
    }
}