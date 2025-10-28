namespace WindowsFormsApp5
{
    partial class Form1 : BaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объёмтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.себестоимостьПоставщикатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp5.database1DataSet1();
            this.получателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp5.database1DataSet();
            this.видДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_доставкиTableAdapter = new WindowsFormsApp5.database1DataSetTableAdapters.Вид_доставкиTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new WindowsFormsApp5.database1DataSetTableAdapters.ДоставкаTableAdapter();
            this.получателиTableAdapter = new WindowsFormsApp5.database1DataSetTableAdapters.ПолучателиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.видДоставкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкиTableAdapter = new WindowsFormsApp5.database1DataSet1TableAdapters.ПоставкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДоставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДоставкиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idposDataGridViewTextBoxColumn,
            this.idpredDataGridViewTextBoxColumn,
            this.idprodDataGridViewTextBoxColumn,
            this.датаПоставкиDataGridViewTextBoxColumn,
            this.объёмтDataGridViewTextBoxColumn,
            this.себестоимостьПоставщикатDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поставкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idposDataGridViewTextBoxColumn
            // 
            this.idposDataGridViewTextBoxColumn.DataPropertyName = "id_pos";
            this.idposDataGridViewTextBoxColumn.HeaderText = "id_pos";
            this.idposDataGridViewTextBoxColumn.Name = "idposDataGridViewTextBoxColumn";
            // 
            // idpredDataGridViewTextBoxColumn
            // 
            this.idpredDataGridViewTextBoxColumn.DataPropertyName = "id_pred";
            this.idpredDataGridViewTextBoxColumn.HeaderText = "id_pred";
            this.idpredDataGridViewTextBoxColumn.Name = "idpredDataGridViewTextBoxColumn";
            // 
            // idprodDataGridViewTextBoxColumn
            // 
            this.idprodDataGridViewTextBoxColumn.DataPropertyName = "id_prod";
            this.idprodDataGridViewTextBoxColumn.HeaderText = "id_prod";
            this.idprodDataGridViewTextBoxColumn.Name = "idprodDataGridViewTextBoxColumn";
            // 
            // датаПоставкиDataGridViewTextBoxColumn
            // 
            this.датаПоставкиDataGridViewTextBoxColumn.DataPropertyName = "Дата поставки";
            this.датаПоставкиDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.датаПоставкиDataGridViewTextBoxColumn.Name = "датаПоставкиDataGridViewTextBoxColumn";
            // 
            // объёмтDataGridViewTextBoxColumn
            // 
            this.объёмтDataGridViewTextBoxColumn.DataPropertyName = "Объём (т)";
            this.объёмтDataGridViewTextBoxColumn.HeaderText = "Объём (т)";
            this.объёмтDataGridViewTextBoxColumn.Name = "объёмтDataGridViewTextBoxColumn";
            // 
            // себестоимостьПоставщикатDataGridViewTextBoxColumn
            // 
            this.себестоимостьПоставщикатDataGridViewTextBoxColumn.DataPropertyName = "Себестоимость поставщика (₽/т)";
            this.себестоимостьПоставщикатDataGridViewTextBoxColumn.HeaderText = "Себестоимость поставщика (₽/т)";
            this.себестоимостьПоставщикатDataGridViewTextBoxColumn.Name = "себестоимостьПоставщикатDataGridViewTextBoxColumn";
            // 
            // поставкиBindingSource
            // 
            this.поставкиBindingSource.DataMember = "Поставки";
            this.поставкиBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // получателиBindingSource
            // 
            this.получателиBindingSource.DataMember = "Получатели";
            this.получателиBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // видДоставкиBindingSource
            // 
            this.видДоставкиBindingSource.DataMember = "Вид доставки";
            this.видДоставкиBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // вид_доставкиTableAdapter
            // 
            this.вид_доставкиTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // получателиTableAdapter
            // 
            this.получателиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // видДоставкиBindingSource1
            // 
            this.видДоставкиBindingSource1.DataMember = "Вид доставки";
            this.видДоставкиBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // поставкиTableAdapter
            // 
            this.поставкиTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.ab67e2ed9e99c0696cf5c2262b561100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Таблица Поставки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДоставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДоставкиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource database1DataSetBindingSource;
        public database1DataSet database1DataSet;
        public System.Windows.Forms.BindingSource видДоставкиBindingSource;
        public database1DataSetTableAdapters.Вид_доставкиTableAdapter вид_доставкиTableAdapter;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.BindingSource доставкаBindingSource;
        public database1DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        public System.Windows.Forms.BindingSource получателиBindingSource;
        public database1DataSetTableAdapters.ПолучателиTableAdapter получателиTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.BindingSource видДоставкиBindingSource1;
        public System.Windows.Forms.BindingSource database1DataSet1BindingSource;

        public database1DataSet1 database1DataSet1;
        public System.Windows.Forms.BindingSource поставкиBindingSource;
        public database1DataSet1TableAdapters.ПоставкиTableAdapter поставкиTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn idposDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn idpredDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn idprodDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаПоставкиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn объёмтDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn себестоимостьПоставщикатDataGridViewTextBoxColumn;
    }
}

