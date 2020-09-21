namespace FF
{
    partial class ProsSForm
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
            this.view_Отдел_кадровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Отдел_кадровTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.View_Отдел_кадровTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.view_Отдел_кадровDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "turAgEgorovaDataSet";
            this.turAgEgorovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // view_Отдел_кадровDataGridView
            // 
            this.view_Отдел_кадровDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_Отдел_кадровDataGridView.AutoGenerateColumns = false;
            this.view_Отдел_кадровDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_Отдел_кадровDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            this.view_Отдел_кадровDataGridView.Location = new System.Drawing.Point(0, 55);
            this.view_Отдел_кадровDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.view_Отдел_кадровDataGridView.Name = "view_Отдел_кадровDataGridView";
            this.view_Отдел_кадровDataGridView.RowHeadersWidth = 51;
            this.view_Отдел_кадровDataGridView.RowTemplate.Height = 24;
            this.view_Отдел_кадровDataGridView.Size = new System.Drawing.Size(907, 273);
            this.view_Отдел_кадровDataGridView.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 50);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(505, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Туристическое агентство \"New Light\"";
            // 
            // ProsSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(907, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view_Отдел_кадровDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProsSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProsSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Отдел_кадровDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}