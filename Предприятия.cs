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
    public partial class Предприятия : BaseForm
    {
        public Предприятия()
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

        private void Предприятия_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Предприятия". При необходимости она может быть перемещена или удалена.
            this.предприятияTableAdapter.Fill(this.database1DataSet1.Предприятия);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Поиск доступен всем пользователям
            s1 sf = new s1();
            sf.Owner = this;
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;

            add af = new add();
            af.Owner = this;
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;
            предприятияTableAdapter.Update(database1DataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}