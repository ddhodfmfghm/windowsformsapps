using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class RoleSelectionDialog : Form
    {
        public string SelectedRole { get; private set; }

        private RadioButton radioUser;
        private RadioButton radioAdmin;
        private Button btnOK;
        private Button btnCancel;

        public RoleSelectionDialog(string currentRole)
        {
            InitializeComponent();
            SetCurrentRole(currentRole);
        }

        private void InitializeComponent()
        {
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(20, 20);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(98, 17);
            this.radioUser.TabIndex = 0;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "Пользователь";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(20, 50);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(105, 17);
            this.radioAdmin.TabIndex = 1;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Администратор";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 90);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RoleSelectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 130);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.radioUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoleSelectionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор роли";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetCurrentRole(string currentRole)
        {
            if (currentRole == "Администратор")
            {
                radioAdmin.Checked = true;
            }
            else
            {
                radioUser.Checked = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedRole = radioAdmin.Checked ? "Администратор" : "Пользователь";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RoleSelectionDialog_Load(object sender, EventArgs e)
        {

        }
    }
}