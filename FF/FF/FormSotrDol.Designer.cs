namespace FF
{
    partial class FormSotrDol
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
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.procedure_po_DolgnostyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedure_po_DolgnostyTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.Procedure_po_DolgnostyTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.procedure_po_DolgnostyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_poisk = new System.Windows.Forms.Button();
            this.procedurepoDolgnostyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedurepoDolgnostyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.procedurepoDolgnostyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.turAgEgorovaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedurepoDolgnostyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.procedurepoDolgnostyBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_dol = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure_po_DolgnostyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure_po_DolgnostyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "turAgEgorovaDataSet";
            this.turAgEgorovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procedure_po_DolgnostyBindingSource
            // 
            this.procedure_po_DolgnostyBindingSource.DataMember = "Procedure_po_Dolgnosty";
            this.procedure_po_DolgnostyBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // procedure_po_DolgnostyTableAdapter
            // 
            this.procedure_po_DolgnostyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторизацияTableAdapter = null;
            this.tableAdapterManager.Виды_отдыхаTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтелиTableAdapter = null;
            this.tableAdapterManager.ПутевкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // procedure_po_DolgnostyDataGridView
            // 
            this.procedure_po_DolgnostyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procedure_po_DolgnostyDataGridView.AutoGenerateColumns = false;
            this.procedure_po_DolgnostyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.procedure_po_DolgnostyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.procedure_po_DolgnostyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.procedure_po_DolgnostyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procedure_po_DolgnostyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.procedure_po_DolgnostyDataGridView.DataSource = this.procedure_po_DolgnostyBindingSource;
            this.procedure_po_DolgnostyDataGridView.Location = new System.Drawing.Point(0, 48);
            this.procedure_po_DolgnostyDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.procedure_po_DolgnostyDataGridView.Name = "procedure_po_DolgnostyDataGridView";
            this.procedure_po_DolgnostyDataGridView.RowHeadersWidth = 51;
            this.procedure_po_DolgnostyDataGridView.RowTemplate.Height = 24;
            this.procedure_po_DolgnostyDataGridView.Size = new System.Drawing.Size(925, 565);
            this.procedure_po_DolgnostyDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Возраст";
            this.dataGridViewTextBoxColumn3.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование должности";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование должности";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Оклад";
            this.dataGridViewTextBoxColumn5.HeaderText = "Оклад";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Обязанности";
            this.dataGridViewTextBoxColumn7.HeaderText = "Обязанности";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button_poisk
            // 
            this.button_poisk.BackColor = System.Drawing.Color.Transparent;
            this.button_poisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_poisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_poisk.Location = new System.Drawing.Point(160, 6);
            this.button_poisk.Margin = new System.Windows.Forms.Padding(2);
            this.button_poisk.Name = "button_poisk";
            this.button_poisk.Size = new System.Drawing.Size(149, 33);
            this.button_poisk.TabIndex = 3;
            this.button_poisk.Text = "Найти  сотрудника";
            this.button_poisk.UseVisualStyleBackColor = false;
            this.button_poisk.Click += new System.EventHandler(this.Button_poisk_Click);
            // 
            // procedurepoDolgnostyBindingSource
            // 
            this.procedurepoDolgnostyBindingSource.DataMember = "Procedure_po_Dolgnosty";
            this.procedurepoDolgnostyBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // procedurepoDolgnostyBindingSource1
            // 
            this.procedurepoDolgnostyBindingSource1.DataMember = "Procedure_po_Dolgnosty";
            this.procedurepoDolgnostyBindingSource1.DataSource = this.turAgEgorovaDataSet;
            // 
            // procedurepoDolgnostyBindingSource2
            // 
            this.procedurepoDolgnostyBindingSource2.DataMember = "Procedure_po_Dolgnosty";
            this.procedurepoDolgnostyBindingSource2.DataSource = this.turAgEgorovaDataSet;
            // 
            // turAgEgorovaDataSetBindingSource
            // 
            this.turAgEgorovaDataSetBindingSource.DataSource = this.turAgEgorovaDataSet;
            this.turAgEgorovaDataSetBindingSource.Position = 0;
            // 
            // procedurepoDolgnostyBindingSource3
            // 
            this.procedurepoDolgnostyBindingSource3.DataMember = "Procedure_po_Dolgnosty";
            this.procedurepoDolgnostyBindingSource3.DataSource = this.turAgEgorovaDataSet;
            // 
            // procedurepoDolgnostyBindingSource4
            // 
            this.procedurepoDolgnostyBindingSource4.DataMember = "Procedure_po_Dolgnosty";
            this.procedurepoDolgnostyBindingSource4.DataSource = this.turAgEgorovaDataSetBindingSource;
            // 
            // comboBox_dol
            // 
            this.comboBox_dol.FormattingEnabled = true;
            this.comboBox_dol.Items.AddRange(new object[] {
            "Директор",
            "Менеджер (помощник)",
            "Главный менеджер",
            "Бухгалтер",
            "Уборщица"});
            this.comboBox_dol.Location = new System.Drawing.Point(12, 12);
            this.comboBox_dol.Name = "comboBox_dol";
            this.comboBox_dol.Size = new System.Drawing.Size(128, 21);
            this.comboBox_dol.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_dol);
            this.panel1.Controls.Add(this.button_poisk);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 43);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(423, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Туристическое агентство \"New Light\"";
            // 
            // FormSotrDol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(925, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.procedure_po_DolgnostyDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSotrDol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр сотрудников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure_po_DolgnostyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure_po_DolgnostyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedurepoDolgnostyBindingSource4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource procedure_po_DolgnostyBindingSource;
        private turAgEgorovaDataSetTableAdapters.Procedure_po_DolgnostyTableAdapter procedure_po_DolgnostyTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView procedure_po_DolgnostyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button_poisk;
        private System.Windows.Forms.BindingSource procedurepoDolgnostyBindingSource1;
        private System.Windows.Forms.BindingSource procedurepoDolgnostyBindingSource;
        private System.Windows.Forms.BindingSource procedurepoDolgnostyBindingSource2;
        private System.Windows.Forms.BindingSource procedurepoDolgnostyBindingSource3;
        private System.Windows.Forms.BindingSource turAgEgorovaDataSetBindingSource;
        private System.Windows.Forms.BindingSource procedurepoDolgnostyBindingSource4;
        private System.Windows.Forms.ComboBox comboBox_dol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}