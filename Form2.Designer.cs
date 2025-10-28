namespace WindowsFormsApp5
{
    partial class Form2
    {
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.получателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запрос2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запрос3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запрос4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доставкаToolStripMenuItem,
            this.доставкаToolStripMenuItem1,
            this.получателиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // доставкаToolStripMenuItem
            // 
            this.доставкаToolStripMenuItem.Name = "доставкаToolStripMenuItem";
            this.доставкаToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.доставкаToolStripMenuItem.Text = "Предприятия";
            this.доставкаToolStripMenuItem.Click += new System.EventHandler(this.предприятияToolStripMenuItem_Click);
            // 
            // доставкаToolStripMenuItem1
            // 
            this.доставкаToolStripMenuItem1.Name = "доставкаToolStripMenuItem1";
            this.доставкаToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.доставкаToolStripMenuItem1.Text = "Продукция";
            this.доставкаToolStripMenuItem1.Click += new System.EventHandler(this.ПродукцияToolStripMenuItem1_Click);
            // 
            // получателиToolStripMenuItem
            // 
            this.получателиToolStripMenuItem.Name = "получателиToolStripMenuItem";
            this.получателиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.получателиToolStripMenuItem.Text = "Поставки";
            this.получателиToolStripMenuItem.Click += new System.EventHandler(this.ПоставкиToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросToolStripMenuItem,
            this.запрос2ToolStripMenuItem,
            this.запрос3ToolStripMenuItem,
            this.запрос4ToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            this.запросыToolStripMenuItem.Click += new System.EventHandler(this.запросыToolStripMenuItem_Click);
            // 
            // запросToolStripMenuItem
            // 
            this.запросToolStripMenuItem.Name = "запросToolStripMenuItem";
            this.запросToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.запросToolStripMenuItem.Text = "Запрос1";
            // 
            // запрос2ToolStripMenuItem
            // 
            this.запрос2ToolStripMenuItem.Name = "запрос2ToolStripMenuItem";
            this.запрос2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.запрос2ToolStripMenuItem.Text = "Запрос2";

            // 
            // запрос3ToolStripMenuItem
            // 
            this.запрос3ToolStripMenuItem.Name = "запрос3ToolStripMenuItem";
            this.запрос3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.запрос3ToolStripMenuItem.Text = "Запрос3";

            // 
            // запрос4ToolStripMenuItem
            // 
            this.запрос4ToolStripMenuItem.Name = "запрос4ToolStripMenuItem";
            this.запрос4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.запрос4ToolStripMenuItem.Text = "Запрос4";

            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(282, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources._9d990e032cc07503b1b8758687366be7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem получателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запрос2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запрос3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запрос4ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}