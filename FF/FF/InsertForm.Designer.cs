namespace FF
{
    partial class InsertForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label телефонLabel1;
            System.Windows.Forms.Label паспортные_данныеLabel1;
            System.Windows.Forms.Label код_должностиLabel1;
            System.Windows.Forms.Label адресLabel1;
            System.Windows.Forms.Label полLabel1;
            System.Windows.Forms.Label возрастLabel1;
            System.Windows.Forms.Label фИОLabel1;
            this.button1 = new System.Windows.Forms.Button();
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.телефонTextBox1 = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox1 = new System.Windows.Forms.TextBox();
            this.код_должностиTextBox1 = new System.Windows.Forms.TextBox();
            this.адресTextBox1 = new System.Windows.Forms.TextBox();
            this.полTextBox1 = new System.Windows.Forms.TextBox();
            this.возрастTextBox1 = new System.Windows.Forms.TextBox();
            this.фИОTextBox1 = new System.Windows.Forms.TextBox();
            this.view_Отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Отдел_кадровTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.View_Отдел_кадровTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            телефонLabel1 = new System.Windows.Forms.Label();
            паспортные_данныеLabel1 = new System.Windows.Forms.Label();
            код_должностиLabel1 = new System.Windows.Forms.Label();
            адресLabel1 = new System.Windows.Forms.Label();
            полLabel1 = new System.Windows.Forms.Label();
            возрастLabel1 = new System.Windows.Forms.Label();
            фИОLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(45, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 16);
            label1.TabIndex = 20;
            label1.Text = "Введите данные";
            // 
            // телефонLabel1
            // 
            телефонLabel1.AutoSize = true;
            телефонLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel1.Location = new System.Drawing.Point(217, 32);
            телефонLabel1.Name = "телефонLabel1";
            телефонLabel1.Size = new System.Drawing.Size(63, 15);
            телефонLabel1.TabIndex = 19;
            телефонLabel1.Text = "Телефон:";
            // 
            // паспортные_данныеLabel1
            // 
            паспортные_данныеLabel1.AutoSize = true;
            паспортные_данныеLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            паспортные_данныеLabel1.Location = new System.Drawing.Point(87, 155);
            паспортные_данныеLabel1.Name = "паспортные_данныеLabel1";
            паспортные_данныеLabel1.Size = new System.Drawing.Size(130, 15);
            паспортные_данныеLabel1.TabIndex = 20;
            паспортные_данныеLabel1.Text = "Паспортные данные:";
            // 
            // код_должностиLabel1
            // 
            код_должностиLabel1.AutoSize = true;
            код_должностиLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_должностиLabel1.Location = new System.Drawing.Point(182, 122);
            код_должностиLabel1.Name = "код_должностиLabel1";
            код_должностиLabel1.Size = new System.Drawing.Size(99, 15);
            код_должностиLabel1.TabIndex = 21;
            код_должностиLabel1.Text = "Код должности:";
            // 
            // адресLabel1
            // 
            адресLabel1.AutoSize = true;
            адресLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel1.Location = new System.Drawing.Point(14, 122);
            адресLabel1.Name = "адресLabel1";
            адресLabel1.Size = new System.Drawing.Size(44, 15);
            адресLabel1.TabIndex = 7;
            адресLabel1.Text = "Адрес:";
            // 
            // полLabel1
            // 
            полLabel1.AutoSize = true;
            полLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel1.Location = new System.Drawing.Point(248, 76);
            полLabel1.Name = "полLabel1";
            полLabel1.Size = new System.Drawing.Size(33, 15);
            полLabel1.TabIndex = 5;
            полLabel1.Text = "Пол:";
            // 
            // возрастLabel1
            // 
            возрастLabel1.AutoSize = true;
            возрастLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel1.Location = new System.Drawing.Point(3, 76);
            возрастLabel1.Name = "возрастLabel1";
            возрастLabel1.Size = new System.Drawing.Size(58, 15);
            возрастLabel1.TabIndex = 3;
            возрастLabel1.Text = "Возраст:";
            // 
            // фИОLabel1
            // 
            фИОLabel1.AutoSize = true;
            фИОLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel1.Location = new System.Drawing.Point(17, 33);
            фИОLabel1.Name = "фИОLabel1";
            фИОLabel1.Size = new System.Drawing.Size(39, 15);
            фИОLabel1.TabIndex = 1;
            фИОLabel1.Text = "ФИО:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(110, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "turAgEgorovaDataSet";
            this.turAgEgorovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторизацияTableAdapter = null;
            this.tableAdapterManager.Виды_отдыхаTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтелиTableAdapter = null;
            this.tableAdapterManager.ПутевкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // сотрудникиDataGridView
            // 
            this.сотрудникиDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.сотрудникиDataGridView.AutoGenerateColumns = false;
            this.сотрудникиDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.сотрудникиDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.сотрудникиDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.сотрудникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сотрудникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.сотрудникиDataGridView.DataSource = this.сотрудникиBindingSource;
            this.сотрудникиDataGridView.Location = new System.Drawing.Point(0, 64);
            this.сотрудникиDataGridView.Name = "сотрудникиDataGridView";
            this.сотрудникиDataGridView.Size = new System.Drawing.Size(933, 239);
            this.сотрудникиDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Возраст";
            this.dataGridViewTextBoxColumn3.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn5.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Паспортные данные";
            this.dataGridViewTextBoxColumn7.HeaderText = "Паспортные данные";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код должности";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код должности";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(телефонLabel1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(паспортные_данныеLabel1);
            this.panel3.Controls.Add(this.телефонTextBox1);
            this.panel3.Controls.Add(this.паспортные_данныеTextBox1);
            this.panel3.Controls.Add(код_должностиLabel1);
            this.panel3.Controls.Add(адресLabel1);
            this.panel3.Controls.Add(this.код_должностиTextBox1);
            this.panel3.Controls.Add(this.адресTextBox1);
            this.panel3.Controls.Add(полLabel1);
            this.panel3.Controls.Add(this.полTextBox1);
            this.panel3.Controls.Add(возрастLabel1);
            this.panel3.Controls.Add(this.возрастTextBox1);
            this.panel3.Controls.Add(фИОLabel1);
            this.panel3.Controls.Add(this.фИОTextBox1);
            this.panel3.Location = new System.Drawing.Point(37, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 246);
            this.panel3.TabIndex = 20;
            // 
            // телефонTextBox1
            // 
            this.телефонTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Телефон", true));
            this.телефонTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox1.Location = new System.Drawing.Point(284, 29);
            this.телефонTextBox1.Name = "телефонTextBox1";
            this.телефонTextBox1.Size = new System.Drawing.Size(100, 21);
            this.телефонTextBox1.TabIndex = 20;
            // 
            // паспортные_данныеTextBox1
            // 
            this.паспортные_данныеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.паспортные_данныеTextBox1.Location = new System.Drawing.Point(226, 151);
            this.паспортные_данныеTextBox1.Name = "паспортные_данныеTextBox1";
            this.паспортные_данныеTextBox1.Size = new System.Drawing.Size(100, 21);
            this.паспортные_данныеTextBox1.TabIndex = 21;
            // 
            // код_должностиTextBox1
            // 
            this.код_должностиTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Код должности", true));
            this.код_должностиTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_должностиTextBox1.Location = new System.Drawing.Point(284, 119);
            this.код_должностиTextBox1.Name = "код_должностиTextBox1";
            this.код_должностиTextBox1.Size = new System.Drawing.Size(100, 21);
            this.код_должностиTextBox1.TabIndex = 22;
            // 
            // адресTextBox1
            // 
            this.адресTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Адрес", true));
            this.адресTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адресTextBox1.Location = new System.Drawing.Point(61, 119);
            this.адресTextBox1.Name = "адресTextBox1";
            this.адресTextBox1.Size = new System.Drawing.Size(100, 21);
            this.адресTextBox1.TabIndex = 8;
            // 
            // полTextBox1
            // 
            this.полTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пол", true));
            this.полTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.полTextBox1.Location = new System.Drawing.Point(284, 73);
            this.полTextBox1.Name = "полTextBox1";
            this.полTextBox1.Size = new System.Drawing.Size(100, 21);
            this.полTextBox1.TabIndex = 6;
            // 
            // возрастTextBox1
            // 
            this.возрастTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Возраст", true));
            this.возрастTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.возрастTextBox1.Location = new System.Drawing.Point(61, 73);
            this.возрастTextBox1.Name = "возрастTextBox1";
            this.возрастTextBox1.Size = new System.Drawing.Size(100, 21);
            this.возрастTextBox1.TabIndex = 4;
            // 
            // фИОTextBox1
            // 
            this.фИОTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox1.Location = new System.Drawing.Point(60, 30);
            this.фИОTextBox1.Name = "фИОTextBox1";
            this.фИОTextBox1.Size = new System.Drawing.Size(100, 21);
            this.фИОTextBox1.TabIndex = 2;
            // 
            // view_Отдел_кадровBindingSource
            // 
            this.view_Отдел_кадровBindingSource.DataMember = "View_Отдел_кадров";
            this.view_Отдел_кадровBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // view_Отдел_кадровTableAdapter
            // 
            this.view_Отдел_кадровTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 58);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(437, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Туристическое агентство \"New Light\"";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(892, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "NL";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FF.Properties.Resources.sky_2009916_1920;
            this.ClientSize = new System.Drawing.Size(933, 613);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.сотрудникиDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить сотрудника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private turAgEgorovaDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView сотрудникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox телефонTextBox1;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox1;
        private System.Windows.Forms.TextBox код_должностиTextBox1;
        private System.Windows.Forms.TextBox адресTextBox1;
        private System.Windows.Forms.TextBox полTextBox1;
        private System.Windows.Forms.TextBox возрастTextBox1;
        private System.Windows.Forms.TextBox фИОTextBox1;
        private System.Windows.Forms.BindingSource view_Отдел_кадровBindingSource;
        private turAgEgorovaDataSetTableAdapters.View_Отдел_кадровTableAdapter view_Отдел_кадровTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}