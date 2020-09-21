namespace FF
{
    partial class DelAdmForm
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
            this.view_Отдел_кадровDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_Отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.del_button = new System.Windows.Forms.Button();
            this.код_сотрудникаLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.view_Отдел_кадровTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.View_Отдел_кадровTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.СотрудникиTableAdapter();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_сотрудникаLabel.Location = new System.Drawing.Point(58, 48);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(61, 16);
            код_сотрудникаLabel.TabIndex = 3;
            код_сотрудникаLabel.Text = "Выбран:";
            // 
            // view_Отдел_кадровDataGridView
            // 
            this.view_Отдел_кадровDataGridView.AutoGenerateColumns = false;
            this.view_Отдел_кадровDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_Отдел_кадровDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.view_Отдел_кадровDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.view_Отдел_кадровDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Отдел_кадровDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view_Отдел_кадровDataGridView.DataSource = this.view_Отдел_кадровBindingSource;
            this.view_Отдел_кадровDataGridView.Location = new System.Drawing.Point(4, 51);
            this.view_Отдел_кадровDataGridView.Name = "view_Отдел_кадровDataGridView";
            this.view_Отдел_кадровDataGridView.Size = new System.Drawing.Size(657, 238);
            this.view_Отдел_кадровDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование должности";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование должности";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Оклад";
            this.dataGridViewTextBoxColumn5.HeaderText = "Оклад";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Обязанности";
            this.dataGridViewTextBoxColumn7.HeaderText = "Обязанности";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // view_Отдел_кадровBindingSource
            // 
            this.view_Отдел_кадровBindingSource.DataMember = "View_Отдел_кадров";
            this.view_Отдел_кадровBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "turAgEgorovaDataSet";
            this.turAgEgorovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.Transparent;
            this.del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_button.Location = new System.Drawing.Point(39, 72);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(165, 52);
            this.del_button.TabIndex = 3;
            this.del_button.Text = "Удалить данные сотрудника";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // код_сотрудникаLabel1
            // 
            this.код_сотрудникаLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_Отдел_кадровBindingSource, "Код сотрудника", true));
            this.код_сотрудникаLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_сотрудникаLabel1.Location = new System.Drawing.Point(131, 46);
            this.код_сотрудникаLabel1.Name = "код_сотрудникаLabel1";
            this.код_сотрудникаLabel1.Size = new System.Drawing.Size(55, 23);
            this.код_сотрудникаLabel1.TabIndex = 4;
            this.код_сотрудникаLabel1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.del_button);
            this.panel1.Controls.Add(код_сотрудникаLabel);
            this.panel1.Controls.Add(this.код_сотрудникаLabel1);
            this.panel1.Location = new System.Drawing.Point(675, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 238);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите сотрудника на форме";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 50);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(285, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Туристическое агентство \"New Light\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "NL";
            // 
            // view_Отдел_кадровTableAdapter
            // 
            this.view_Отдел_кадровTableAdapter.ClearBeforeFill = true;
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
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(39, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Новый сотрудник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Переход на форму добавления";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "нового сотрудника";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DelAdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::FF.Properties.Resources.sky_2009916_1280;
            this.ClientSize = new System.Drawing.Size(915, 326);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view_Отдел_кадровDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DelAdmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление данных сотрудника";
            this.Load += new System.EventHandler(this.DelAdmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource view_Отдел_кадровBindingSource;
        private turAgEgorovaDataSetTableAdapters.View_Отдел_кадровTableAdapter view_Отдел_кадровTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_Отдел_кадровDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private turAgEgorovaDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Label код_сотрудникаLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}