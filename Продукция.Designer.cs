using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp5
{
    partial class Продукция : BaseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупочнаяЦенатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp5.database1DataSet1();
            this.доставкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp5.database1DataSet();
            this.отправителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отправителиTableAdapter = new WindowsFormsApp5.database1DataSetTableAdapters.ОтправителиTableAdapter();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new WindowsFormsApp5.database1DataSetTableAdapters.ДоставкаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.продукцияTableAdapter = new WindowsFormsApp5.database1DataSet1TableAdapters.ПродукцияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отправителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodDataGridViewTextBoxColumn,
            this.названиеПродукцииDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn,
            this.закупочнаяЦенатDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продукцияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idprodDataGridViewTextBoxColumn
            // 
            this.idprodDataGridViewTextBoxColumn.DataPropertyName = "id_prod";
            this.idprodDataGridViewTextBoxColumn.HeaderText = "id_prod";
            this.idprodDataGridViewTextBoxColumn.Name = "idprodDataGridViewTextBoxColumn";
            // 
            // названиеПродукцииDataGridViewTextBoxColumn
            // 
            this.названиеПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Название продукции";
            this.названиеПродукцииDataGridViewTextBoxColumn.HeaderText = "Название продукции";
            this.названиеПродукцииDataGridViewTextBoxColumn.Name = "названиеПродукцииDataGridViewTextBoxColumn";
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            // 
            // закупочнаяЦенатDataGridViewTextBoxColumn
            // 
            this.закупочнаяЦенатDataGridViewTextBoxColumn.DataPropertyName = "Закупочная цена (₽/т)";
            this.закупочнаяЦенатDataGridViewTextBoxColumn.HeaderText = "Закупочная цена (₽/т)";
            this.закупочнаяЦенатDataGridViewTextBoxColumn.Name = "закупочнаяЦенатDataGridViewTextBoxColumn";
            // 
            // продукцияBindingSource
            // 
            this.продукцияBindingSource.DataMember = "Продукция";
            this.продукцияBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // доставкаBindingSource1
            // 
            this.доставкаBindingSource1.DataMember = "Доставка";
            this.доставкаBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отправителиBindingSource
            // 
            this.отправителиBindingSource.DataMember = "Отправители";
            this.отправителиBindingSource.DataSource = this.database1DataSet;
            // 
            // отправителиTableAdapter
            // 
            this.отправителиTableAdapter.ClearBeforeFill = true;
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.database1DataSet;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // продукцияTableAdapter
            // 
            this.продукцияTableAdapter.ClearBeforeFill = true;
            // 
            // Продукция
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.ab67e2ed9e99c0696cf5c2262b561100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Продукция";
            this.Text = "Таблица Продукция";
            this.Load += new System.EventHandler(this.Доставка_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отправителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public database1DataSet database1DataSet;
        public System.Windows.Forms.BindingSource отправителиBindingSource;
        public database1DataSetTableAdapters.ОтправителиTableAdapter отправителиTableAdapter;
        public System.Windows.Forms.BindingSource доставкаBindingSource;
        public database1DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        public System.Windows.Forms.BindingSource доставкаBindingSource1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public database1DataSet1 database1DataSet1;
        public System.Windows.Forms.BindingSource продукцияBindingSource;
        public database1DataSet1TableAdapters.ПродукцияTableAdapter продукцияTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn idprodDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn названиеПродукцииDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn закупочнаяЦенатDataGridViewTextBoxColumn;
    }
}