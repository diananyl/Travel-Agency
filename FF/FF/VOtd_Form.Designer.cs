namespace FF
{
    partial class VOtd_Form
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
            this.vot_button = new System.Windows.Forms.Button();
            this.VO_comboBox = new System.Windows.Forms.ComboBox();
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.pr_Vid_OtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_Vid_OtTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.Pr_Vid_OtTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.pr_Vid_OtDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_Vid_OtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_Vid_OtDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vot_button
            // 
            this.vot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vot_button.Location = new System.Drawing.Point(185, 10);
            this.vot_button.Margin = new System.Windows.Forms.Padding(2);
            this.vot_button.Name = "vot_button";
            this.vot_button.Size = new System.Drawing.Size(184, 36);
            this.vot_button.TabIndex = 5;
            this.vot_button.Text = "Выбрать вид отдыха";
            this.vot_button.UseVisualStyleBackColor = true;
            this.vot_button.Click += new System.EventHandler(this.Vot_button_Click);
            // 
            // VO_comboBox
            // 
            this.VO_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VO_comboBox.FormattingEnabled = true;
            this.VO_comboBox.Items.AddRange(new object[] {
            "Пляжный",
            "Свадебный",
            "Горнолыжный",
            "Морские круизы",
            "Экскурсионный тур",
            "Новогодние туры",
            "Оздоровительные курорты"});
            this.VO_comboBox.Location = new System.Drawing.Point(12, 15);
            this.VO_comboBox.Name = "VO_comboBox";
            this.VO_comboBox.Size = new System.Drawing.Size(158, 26);
            this.VO_comboBox.TabIndex = 6;
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "turAgEgorovaDataSet";
            this.turAgEgorovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pr_Vid_OtBindingSource
            // 
            this.pr_Vid_OtBindingSource.DataMember = "Pr_Vid_Ot";
            this.pr_Vid_OtBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // pr_Vid_OtTableAdapter
            // 
            this.pr_Vid_OtTableAdapter.ClearBeforeFill = true;
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
            // pr_Vid_OtDataGridView
            // 
            this.pr_Vid_OtDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pr_Vid_OtDataGridView.AutoGenerateColumns = false;
            this.pr_Vid_OtDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pr_Vid_OtDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.pr_Vid_OtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pr_Vid_OtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pr_Vid_OtDataGridView.DataSource = this.pr_Vid_OtBindingSource;
            this.pr_Vid_OtDataGridView.Location = new System.Drawing.Point(0, 64);
            this.pr_Vid_OtDataGridView.Name = "pr_Vid_OtDataGridView";
            this.pr_Vid_OtDataGridView.Size = new System.Drawing.Size(924, 254);
            this.pr_Vid_OtDataGridView.TabIndex = 8;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.VO_comboBox);
            this.panel1.Controls.Add(this.vot_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 58);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(569, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Туристическое агентство \"New Light\"";
            // 
            // VOtd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(924, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pr_Vid_OtDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VOtd_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтр по видам отдыха";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_Vid_OtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_Vid_OtDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button vot_button;
        private System.Windows.Forms.ComboBox VO_comboBox;
        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource pr_Vid_OtBindingSource;
        private turAgEgorovaDataSetTableAdapters.Pr_Vid_OtTableAdapter pr_Vid_OtTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pr_Vid_OtDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}