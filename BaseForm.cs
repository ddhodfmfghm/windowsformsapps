using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public class BaseForm : Form
    {
        protected bool IsViewOnlyMode => this.Tag?.ToString() == "viewonly" || !CurrentUser.IsAdmin();

        public BaseForm()
        {
            // Базовая инициализация для всех форм
        }

        protected void SetupPermissions()
        {
            if (IsViewOnlyMode)
            {
                SetViewOnlyMode();
            }
        }

        protected virtual void SetViewOnlyMode()
        {
            // Базовая реализация для установки режима только для просмотра
            this.Text += " (Только просмотр)";

            // Отключаем кнопки добавления, редактирования, удаления
            DisableEditControls(this);
        }

        private void DisableEditControls(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button button)
                {
                    // Определяем кнопки редактирования по тексту или имени
                    if (IsEditButton(button))
                    {
                        button.Enabled = false;
                        button.BackColor = Color.LightGray;
                        if (!button.Text.Contains("(недоступно)"))
                        {
                            button.Text += " (недоступно)";
                        }
                    }
                }

                // Рекурсивно обрабатываем вложенные контролы
                if (ctrl.HasChildren)
                {
                    DisableEditControls(ctrl);
                }
            }
        }

        private bool IsEditButton(Button button)
        {
            string[] editKeywords = { "добав", "редакт", "удал", "save", "edit", "delete", "add", "нов", "измен", "сохран", "update" };
            string buttonText = button.Text.ToLower();
            string buttonName = button.Name.ToLower();

            foreach (string keyword in editKeywords)
            {
                if (buttonText.Contains(keyword) || buttonName.Contains(keyword))
                {
                    return true;
                }
            }
            return false;
        }

        protected void SetControlsReadOnly(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.BackColor = Color.LightGray;
                }
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.Enabled = false;
                    comboBox.BackColor = Color.LightGray;
                }
                else if (ctrl is NumericUpDown numericUpDown)
                {
                    numericUpDown.Enabled = false;
                    numericUpDown.BackColor = Color.LightGray;
                }
                else if (ctrl is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Enabled = false;
                    dateTimePicker.BackColor = Color.LightGray;
                }
                else if (ctrl is DataGridView dataGridView)
                {
                    SetupReadOnlyDataGridView(dataGridView);
                }

                if (ctrl.HasChildren)
                {
                    SetControlsReadOnly(ctrl);
                }
            }
        }

        protected void SetupReadOnlyDataGridView(DataGridView dataGridView)
        {
            if (IsViewOnlyMode)
            {
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        protected void ShowAccessDeniedMessage()
        {
            MessageBox.Show("Доступ запрещен. Только для администраторов.", "Ограничение прав",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Метод для безопасного выполнения действий, требующих прав администратора
        protected bool CheckAdminAccess()
        {
            if (IsViewOnlyMode)
            {
                ShowAccessDeniedMessage();
                return false;
            }
            return true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}