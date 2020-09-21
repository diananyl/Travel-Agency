namespace FF
{
    partial class BronForm
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
            this.bron_button = new System.Windows.Forms.Button();
            this.BF_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.zZZabroNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zZZabroNTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.ZZZabroNTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.zZZabroNDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zZZabroNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zZZabroNDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bron_button
            // 
            this.bron_button.BackColor = System.Drawing.Color.Transparent;
            this.bron_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bron_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bron_button.Location = new System.Drawing.Point(192, 10);
            this.bron_button.Name = "bron_button";
            this.bron_button.Size = new System.Drawing.Size(114, 32);
            this.bron_button.TabIndex = 4;
            this.bron_button.Text = "Найти";
            this.bron_button.UseVisualStyleBackColor = false;
            this.bron_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BF_comboBox
            // 
            this.BF_comboBox.FormattingEnabled = true;
            this.BF_comboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.BF_comboBox.Location = new System.Drawing.Point(46, 16);
            this.BF_comboBox.Name = "BF_comboBox";
            this.BF_comboBox.Size = new System.Drawing.Size(121, 21);
            this.BF_comboBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BF_comboBox);
            this.panel1.Controls.Add(this.bron_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 49);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(418, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Туристическое агентство \"New Light\"";
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "turAgEgorovaDataSet";
            this.turAgEgorovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zZZabroNBindingSource
            // 
            this.zZZabroNBindingSource.DataMember = "ZZZabroN";
            this.zZZabroNBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // zZZabroNTableAdapter
            // 
            this.zZZabroNTableAdapter.ClearBeforeFill = true;
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
            // zZZabroNDataGridView
            // 
            this.zZZabroNDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zZZabroNDataGridView.AutoGenerateColumns = false;
            this.zZZabroNDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zZZabroNDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.zZZabroNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zZZabroNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.zZZabroNDataGridView.DataSource = this.zZZabroNBindingSource;
            this.zZZabroNDataGridView.Location = new System.Drawing.Point(0, 49);
            this.zZZabroNDataGridView.Name = "zZZabroNDataGridView";
            this.zZZabroNDataGridView.Size = new System.Drawing.Size(844, 381);
            this.zZZabroNDataGridView.TabIndex = 8;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Отметка о бронировании";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Отметка о бронировании";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Отметка об оплате";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Отметка об оплате";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование отеля";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование отеля";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Страна";
            this.dataGridViewTextBoxColumn3.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование вида отдыха";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование вида отдыха";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код сотрудника";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код путевки";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код путевки";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Bron_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(844, 430);
            this.Controls.Add(this.zZZabroNDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bron_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Забронированные и не забронированные путевки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zZZabroNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zZZabroNDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bron_button;
        private System.Windows.Forms.ComboBox BF_comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource zZZabroNBindingSource;
        private turAgEgorovaDataSetTableAdapters.ZZZabroNTableAdapter zZZabroNTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView zZZabroNDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}