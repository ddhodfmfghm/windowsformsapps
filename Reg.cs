using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Reg : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UsersDB.accdb;";

        public Reg()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Регистрация пользователя";
            this.StartPosition = FormStartPosition.CenterScreen;
            lblMessage.ForeColor = Color.Blue;

            // Заполняем комбобокс ролями
            cmbRole.Items.Add("Пользователь");
            cmbRole.Items.Add("Администратор");
            cmbRole.SelectedIndex = 1; // По умолчанию "Пользователь"
        }

        private void ShowMessage(string message, Color color)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = color;
        }

        private void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            // Проверка введенных данных
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowMessage("Введите имя пользователя!", Color.Red);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowMessage("Введите пароль!", Color.Red);
                return;
            }

            if (password.Length < 4)
            {
                ShowMessage("Пароль должен содержать минимум 4 символа!", Color.Red);
                return;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                ShowMessage("Выберите роль!", Color.Red);
                return;
            }

            try
            {
                // Проверяем, существует ли пользователь с таким именем
                if (UserExists(username))
                {
                    ShowMessage("Пользователь с таким именем уже существует!", Color.Red);
                    return;
                }

                // ИСПРАВЛЕННЫЙ ЗАПРОС С ИСПОЛЬЗОВАНИЕМ ПАРАМЕТРОВ
                string insertQuery = "INSERT INTO Users (Username, [Password], Role) VALUES (?, ?, ?)";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                {
                    // Добавляем параметры для безопасного выполнения запроса
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.Parameters.AddWithValue("@Role", role);

                    conn.Open();
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ShowMessage("Регистрация успешна!", Color.Green);
                        ResetForm();
                    }
                    else
                    {
                        ShowMessage("Ошибка при регистрации!", Color.Red);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Ошибка: " + ex.Message, Color.Red);
                MessageBox.Show($"Полная ошибка:\n{ex.ToString()}", "Детали ошибки",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка существования пользователя
        private bool UserExists(string username)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке пользователя: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}