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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            SetupUserInterface();
            DisplayUserInfo();
        }

        private void SetupUserInterface()
        {
            // Устанавливаем заголовок формы с указанием роли пользователя
            this.Text = $"Панель пользователя - {CurrentUser.Username} ({CurrentUser.Role})";

            // Если пользователь не администратор, скрываем/блокируем элементы управления
            if (!CurrentUser.IsAdmin())
            {
                SetupUserPermissions();
            }
        }

        private void SetupUserPermissions()
        {
            // Для обычных пользователей меняем текст меню
            таблицыToolStripMenuItem.Text = "Просмотр таблиц";

            // Скрываем меню управления пользователями для обычных пользователей
            управлениеПользователямиToolStripMenuItem.Visible = false;

            AddViewOnlyIndicators();
        }

        private void AddViewOnlyIndicators()
        {
            // Добавляем подпись о режиме только для просмотра
            Label viewOnlyLabel = new Label();
            viewOnlyLabel.Text = "";
            viewOnlyLabel.ForeColor = Color.Blue;
            viewOnlyLabel.Font = new Font("Arial", 8, FontStyle.Italic);
            viewOnlyLabel.AutoSize = true;
            viewOnlyLabel.Location = new Point(300, 5);

            // Добавляем на форму
            this.Controls.Add(viewOnlyLabel);
            viewOnlyLabel.BringToFront();
        }

        private void DisplayUserInfo()
        {
            // Добавляем информацию о пользователе на форму
            Label userInfoLabel = new Label();
            userInfoLabel.Text = $"Пользователь: {CurrentUser.Username} | Роль: {CurrentUser.Role}";
            userInfoLabel.AutoSize = true;
            userInfoLabel.Location = new Point(10, 30);
            userInfoLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            userInfoLabel.ForeColor = CurrentUser.IsAdmin() ? Color.DarkGreen : Color.Blue;

            this.Controls.Add(userInfoLabel);
            userInfoLabel.BringToFront();
        }

        private void предприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ПродукцияToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void доставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму предприятий
            Предприятия form1 = new Предприятия();
            SetFormViewMode(form1);
            form1.Show();
        }

        private void доставкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Открываем форму продукции
            Продукция form1 = new Продукция();
            SetFormViewMode(form1);
            form1.Show();
        }

        private void получателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму поставок
            Form1 form1 = new Form1();
            SetFormViewMode(form1);
            form1.Show();
        }

        private void SetFormViewMode(Form form)
        {
            // Устанавливаем режим только для просмотра для обычных пользователей
            if (!CurrentUser.IsAdmin())
            {
                form.Tag = "viewonly";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

       

        // Добавляем метод user_Load, на который ссылается Designer
        private void user_Load(object sender, EventArgs e)
        {
            // Этот метод может быть пустым или содержать дополнительную инициализацию
        }

        // ДОБАВЬТЕ ЭТОТ НОВЫЙ МЕТОД ↓
        private void управлениеПользователямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, является ли текущий пользователь администратором
            if (!CurrentUser.IsAdmin())
            {
                MessageBox.Show("Доступ запрещен. Только администраторы могут управлять пользователями.",
                              "Ограничение прав", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();
        }
    }
}