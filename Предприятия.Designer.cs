namespace WindowsFormsApp5
{
    partial class Предприятия : BaseForm
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
            this.idpredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСельхозПредприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видСобственностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоРаботниковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.основнойВидПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.овоениеТехнологийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прибыльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp5.database1DataSet1();
            this.видДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp5.database1DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.вид_доставкиTableAdapter = new WindowsFormsApp5.database1DataSetTableAdapters.Вид_доставкиTableAdapter();
            this.предприятияTableAdapter = new WindowsFormsApp5.database1DataSet1TableAdapters.ПредприятияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДоставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpredDataGridViewTextBoxColumn,
            this.наименованиеСельхозПредприятияDataGridViewTextBoxColumn,
            this.датаРегистрацииDataGridViewTextBoxColumn,
            this.видСобственностиDataGridViewTextBoxColumn,
            this.числоРаботниковDataGridViewTextBoxColumn,
            this.основнойВидПродукцииDataGridViewTextBoxColumn,
            this.овоениеТехнологийDataGridViewTextBoxColumn,
            this.прибыльDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.предприятияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idpredDataGridViewTextBoxColumn
            // 
            this.idpredDataGridViewTextBoxColumn.DataPropertyName = "id_pred";
            this.idpredDataGridViewTextBoxColumn.HeaderText = "id_pred";
            this.idpredDataGridViewTextBoxColumn.Name = "idpredDataGridViewTextBoxColumn";
            // 
            // наименованиеСельхозПредприятияDataGridViewTextBoxColumn
            // 
            this.наименованиеСельхозПредприятияDataGridViewTextBoxColumn.DataPropertyName = "Наименование сельхоз предприятия";
            this.наименованиеСельхозПредприятияDataGridViewTextBoxColumn.HeaderText = "Наименование сельхоз предприятия";
            this.наименованиеСельхозПредприятияDataGridViewTextBoxColumn.Name = "наименованиеСельхозПредприятияDataGridViewTextBoxColumn";
            // 
            // датаРегистрацииDataGridViewTextBoxColumn
            // 
            this.датаРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.Name = "датаРегистрацииDataGridViewTextBoxColumn";
            // 
            // видСобственностиDataGridViewTextBoxColumn
            // 
            this.видСобственностиDataGridViewTextBoxColumn.DataPropertyName = "Вид собственности";
            this.видСобственностиDataGridViewTextBoxColumn.HeaderText = "Вид собственности";
            this.видСобственностиDataGridViewTextBoxColumn.Name = "видСобственностиDataGridViewTextBoxColumn";
            // 
            // числоРаботниковDataGridViewTextBoxColumn
            // 
            this.числоРаботниковDataGridViewTextBoxColumn.DataPropertyName = "Число работников";
            this.числоРаботниковDataGridViewTextBoxColumn.HeaderText = "Число работников";
            this.числоРаботниковDataGridViewTextBoxColumn.Name = "числоРаботниковDataGridViewTextBoxColumn";
            // 
            // основнойВидПродукцииDataGridViewTextBoxColumn
            // 
            this.основнойВидПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Основной вид продукции";
            this.основнойВидПродукцииDataGridViewTextBoxColumn.HeaderText = "Основной вид продукции";
            this.основнойВидПродукцииDataGridViewTextBoxColumn.Name = "основнойВидПродукцииDataGridViewTextBoxColumn";
            // 
            // овоениеТехнологийDataGridViewTextBoxColumn
            // 
            this.овоениеТехнологийDataGridViewTextBoxColumn.DataPropertyName = "Овоение технологий";
            this.овоениеТехнологийDataGridViewTextBoxColumn.HeaderText = "Овоение технологий";
            this.овоениеТехнологийDataGridViewTextBoxColumn.Name = "овоениеТехнологийDataGridViewTextBoxColumn";
            // 
            // прибыльDataGridViewTextBoxColumn
            // 
            this.прибыльDataGridViewTextBoxColumn.DataPropertyName = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.HeaderText = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.Name = "прибыльDataGridViewTextBoxColumn";
            // 
            // предприятияBindingSource
            // 
            this.предприятияBindingSource.DataMember = "Предприятия";
            this.предприятияBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // видДоставкиBindingSource
            // 
            this.видДоставкиBindingSource.DataMember = "Вид доставки";
            this.видДоставкиBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(685, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // вид_доставкиTableAdapter
            // 
            this.вид_доставкиTableAdapter.ClearBeforeFill = true;
            // 
            // предприятияTableAdapter
            // 
            this.предприятияTableAdapter.ClearBeforeFill = true;
            // 
            // Предприятия
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources._9d990e032cc07503b1b8758687366be7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Предприятия";
            this.Text = "Табилца Предприятия";
            this.Load += new System.EventHandler(this.Предприятия_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДоставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public database1DataSet database1DataSet;
        public System.Windows.Forms.BindingSource видДоставкиBindingSource;
        public database1DataSetTableAdapters.Вид_доставкиTableAdapter вид_доставкиTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public database1DataSet1 database1DataSet1;
        public System.Windows.Forms.BindingSource предприятияBindingSource;
        public database1DataSet1TableAdapters.ПредприятияTableAdapter предприятияTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn idpredDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСельхозПредприятияDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаРегистрацииDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn видСобственностиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn числоРаботниковDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn основнойВидПродукцииDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn овоениеТехнологийDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn прибыльDataGridViewTextBoxColumn;
    }
}