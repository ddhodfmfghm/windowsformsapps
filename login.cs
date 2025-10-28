using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class login : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UsersDB.accdb;";

        public login()
        {
            InitializeComponent();
            SetupLoginForm();
        }

        private void SetupLoginForm()
        {
            label4.ForeColor = Color.Red;
            label4.Text = "";
            button3.Text = "Регистрация";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                label4.Text = "Заполните все поля!";
                return;
            }

            // Проверка в базе данных
            UserInfo userInfo = CheckUserCredentials(username, password);

            if (userInfo != null)
            {
                // Сохраняем информацию о текущем пользователе
                CurrentUser.Username = userInfo.Username;
                CurrentUser.Role = userInfo.Role;

                // Всегда открываем форму пользователя, но с разными правами
                user userForm = new user();
                userForm.Show();
                this.Close();
            }
            else
            {
                label4.Text = "Неправильный логин или пароль";
            }
        }

        // Проверка учетных данных в базе данных с возвратом информации о пользователе
        private UserInfo CheckUserCredentials(string username, string password)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Username, Role FROM Users WHERE Username = ? AND Password = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserInfo
                                {
                                    Username = reader["Username"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке пользователя: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reg regForm = new Reg();
            regForm.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }

    // Класс для хранения информации о пользователе
    public class UserInfo
    {
        public string Username { get; set; }
        public string Role { get; set; }
    }

    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static bool IsAdmin()
        {
            return Role == "Администратор";
        }
    }
}