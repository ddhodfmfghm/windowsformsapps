using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class UserManagement : BaseForm
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UsersDB.accdb;";

        private DataGridView dataGridViewUsers;
        private Button btnUpdateRole;
        private Button btnDeleteUser;
        private Button btnRefresh;
        private Button btnClose;
        private Label label1;

        public UserManagement()
        {
            InitializeComponent();
            SetupPermissions();
            LoadUsers();
        }

        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Location = new System.Drawing.Point(12, 360);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateRole.TabIndex = 1;
            this.btnUpdateRole.Text = "Изменить роль";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(140, 360);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Удалить пользователя";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(268, 360);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(376, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Управление пользователями";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пользователями";
            this.Load += new System.EventHandler(this.UserManagement_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void SetViewOnlyMode()
        {
            base.SetViewOnlyMode();
            // Для обычных пользователей скрываем кнопки управления
            btnUpdateRole.Enabled = false;
            btnDeleteUser.Enabled = false;
            btnRefresh.Enabled = false;
        }

        private void LoadUsers()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ID, Username, Role FROM Users ORDER BY Username";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewUsers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке пользователей: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;

            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для изменения роли", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
            string username = selectedRow.Cells["Username"].Value.ToString();
            string currentRole = selectedRow.Cells["Role"].Value.ToString();

            // Диалог выбора роли
            using (RoleSelectionDialog roleDialog = new RoleSelectionDialog(currentRole))
            {
                if (roleDialog.ShowDialog() == DialogResult.OK)
                {
                    string newRole = roleDialog.SelectedRole;
                    UpdateUserRole(username, newRole);
                }
            }
        }

        private void UpdateUserRole(string username, string newRole)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Role = ? WHERE Username = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Role", newRole);
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Роль пользователя {username} изменена на '{newRole}'", "Успех",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers(); // Обновляем список
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении роли: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!CheckAdminAccess()) return;

            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для удаления", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
            string username = selectedRow.Cells["Username"].Value.ToString();

            // Не позволяем удалить самого себя
            if (username == CurrentUser.Username)
            {
                MessageBox.Show("Нельзя удалить свою собственную учетную запись", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить пользователя '{username}'?",
                                                "Подтверждение удаления",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteUser(username);
            }
        }

        private void DeleteUser(string username)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE Username = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Пользователь {username} удален", "Успех",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers(); // Обновляем список
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении пользователя: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void UserManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}