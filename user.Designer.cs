namespace WindowsFormsApp5
{
    partial class user
    {
        private System.Windows.Forms.ToolStripMenuItem управлениеПользователямиToolStripMenuItem;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.получателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.управлениеПользователямиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доставкаToolStripMenuItem,
            this.доставкаToolStripMenuItem1,
            this.получателиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // доставкаToolStripMenuItem
            // 
            this.доставкаToolStripMenuItem.Name = "доставкаToolStripMenuItem";
            this.доставкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.доставкаToolStripMenuItem.Text = "Предприятия";
            this.доставкаToolStripMenuItem.Click += new System.EventHandler(this.доставкаToolStripMenuItem_Click);
            // 
            // доставкаToolStripMenuItem1
            // 
            this.доставкаToolStripMenuItem1.Name = "доставкаToolStripMenuItem1";
            this.доставкаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.доставкаToolStripMenuItem1.Text = "Продукция";
            this.доставкаToolStripMenuItem1.Click += new System.EventHandler(this.доставкаToolStripMenuItem1_Click);
            // 
            // получателиToolStripMenuItem
            // 
            this.получателиToolStripMenuItem.Name = "получателиToolStripMenuItem";
            this.получателиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.получателиToolStripMenuItem.Text = "Поставки";
            this.получателиToolStripMenuItem.Click += new System.EventHandler(this.получателиToolStripMenuItem_Click);
            // 
            // управлениеПользователямиToolStripMenuItem
            // 
            this.управлениеПользователямиToolStripMenuItem.Name = "управлениеПользователямиToolStripMenuItem";
            this.управлениеПользователямиToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.управлениеПользователямиToolStripMenuItem.Text = "Управление пользователями";
            this.управлениеПользователямиToolStripMenuItem.Click += new System.EventHandler(this.управлениеПользователямиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(368, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.ab67e2ed9e99c0696cf5c2262b561100;
            this.ClientSize = new System.Drawing.Size(455, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem получателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}