namespace FF
{
    partial class RedAdmForm
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
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label код_должностиLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.view_Отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Отдел_кадровTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.View_Отдел_кадровTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.код_должностиTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.сотрудникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.код_сотрудникаLabel2 = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            код_должностиLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.BackColor = System.Drawing.Color.Transparent;
            код_сотрудникаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_сотрудникаLabel.Location = new System.Drawing.Point(22, 2);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(61, 16);
            код_сотрудникаLabel.TabIndex = 2;
            код_сотрудникаLabel.Text = "Выбран:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(64, 66);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(48, 18);
            фИОLabel.TabIndex = 8;
            фИОLabel.Text = "ФИО:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel.Location = new System.Drawing.Point(299, 66);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(70, 18);
            возрастLabel.TabIndex = 9;
            возрастLabel.Text = "Возраст:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            паспортные_данныеLabel.Location = new System.Drawing.Point(298, 26);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(71, 18);
            паспортные_данныеLabel.TabIndex = 11;
            паспортные_данныеLabel.Text = "Паспорт:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel.Location = new System.Drawing.Point(71, 105);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(41, 18);
            полLabel.TabIndex = 12;
            полLabel.Text = "Пол:";
            // 
            // код_должностиLabel
            // 
            код_должностиLabel.AutoSize = true;
            код_должностиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_должностиLabel.Location = new System.Drawing.Point(158, 152);
            код_должностиLabel.Name = "код_должностиLabel";
            код_должностиLabel.Size = new System.Drawing.Size(122, 18);
            код_должностиLabel.TabIndex = 13;
            код_должностиLabel.Text = "Код должности:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.Location = new System.Drawing.Point(64, 26);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(54, 18);
            адресLabel.TabIndex = 14;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(296, 105);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(76, 18);
            телефонLabel.TabIndex = 18;
            телефонLabel.Text = "Телефон:";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 58);
            this.panel2.TabIndex = 7;
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
            // view_Отдел_кадровBindingSource
            // 
            this.view_Отдел_кадровBindingSource.DataMember = "View_Отдел_кадров";
            this.view_Отдел_кадровBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // view_Отдел_кадровTableAdapter
            // 
            this.view_Отдел_кадровTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(803, 641);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "NL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.код_сотрудникаLabel2);
            this.panel1.Controls.Add(телефонLabel);
            this.panel1.Controls.Add(this.телефонTextBox);
            this.panel1.Controls.Add(адресLabel);
            this.panel1.Controls.Add(this.адресTextBox);
            this.panel1.Controls.Add(код_должностиLabel);
            this.panel1.Controls.Add(this.код_должностиTextBox);
            this.panel1.Controls.Add(полLabel);
            this.panel1.Controls.Add(this.полTextBox);
            this.panel1.Controls.Add(паспортные_данныеLabel);
            this.panel1.Controls.Add(this.паспортные_данныеTextBox);
            this.panel1.Controls.Add(возрастLabel);
            this.panel1.Controls.Add(this.возрастTextBox);
            this.panel1.Controls.Add(фИОLabel);
            this.panel1.Controls.Add(this.фИОTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(код_сотрудникаLabel);
            this.panel1.Location = new System.Drawing.Point(182, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 260);
            this.panel1.TabIndex = 18;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Телефон", true));
            this.телефонTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox.Location = new System.Drawing.Point(411, 105);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 24);
            this.телефонTextBox.TabIndex = 19;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адресTextBox.Location = new System.Drawing.Point(161, 26);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 24);
            this.адресTextBox.TabIndex = 15;
            // 
            // код_должностиTextBox
            // 
            this.код_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Код должности", true));
            this.код_должностиTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_должностиTextBox.Location = new System.Drawing.Point(305, 152);
            this.код_должностиTextBox.Name = "код_должностиTextBox";
            this.код_должностиTextBox.Size = new System.Drawing.Size(100, 24);
            this.код_должностиTextBox.TabIndex = 14;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пол", true));
            this.полTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.полTextBox.Location = new System.Drawing.Point(161, 105);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(100, 24);
            this.полTextBox.TabIndex = 13;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(411, 26);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(100, 24);
            this.паспортные_данныеTextBox.TabIndex = 12;
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_Отдел_кадровBindingSource, "Возраст", true));
            this.возрастTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.возрастTextBox.Location = new System.Drawing.Point(411, 66);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(100, 24);
            this.возрастTextBox.TabIndex = 10;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_Отдел_кадровBindingSource, "ФИО", true));
            this.фИОTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox.Location = new System.Drawing.Point(161, 66);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 24);
            this.фИОTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(205, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.сотрудникиDataGridView.Size = new System.Drawing.Size(844, 309);
            this.сотрудникиDataGridView.TabIndex = 18;
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
            // код_сотрудникаLabel2
            // 
            this.код_сотрудникаLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_Отдел_кадровBindingSource, "Код сотрудника", true));
            this.код_сотрудникаLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.код_сотрудникаLabel2.Location = new System.Drawing.Point(89, 3);
            this.код_сотрудникаLabel2.Name = "код_сотрудникаLabel2";
            this.код_сотрудникаLabel2.Size = new System.Drawing.Size(66, 23);
            this.код_сотрудникаLabel2.TabIndex = 20;
            this.код_сотрудникаLabel2.Text = "label1";
            // 
            // RedAdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::FF.Properties.Resources.sky_2009916_1920;
            this.ClientSize = new System.Drawing.Size(845, 666);
            this.Controls.Add(this.сотрудникиDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RedAdmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование данных сотрудника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RedAdmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private turAgEgorovaDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource view_Отдел_кадровBindingSource;
        private turAgEgorovaDataSetTableAdapters.View_Отдел_кадровTableAdapter view_Отдел_кадровTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox код_должностиTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DataGridView сотрудникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label код_сотрудникаLabel2;
    }
}