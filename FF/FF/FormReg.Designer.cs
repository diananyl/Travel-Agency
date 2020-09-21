namespace FF
{
    partial class FormReg
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
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label логинLabel;
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.авторизацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авторизацияTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.АвторизацияTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.textBox_Pas = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизацияBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold);
            парольLabel.Location = new System.Drawing.Point(18, 36);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(88, 45);
            парольLabel.TabIndex = 11;
            парольLabel.Text = "Пароль:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold);
            фИОLabel.Location = new System.Drawing.Point(18, 75);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(67, 45);
            фИОLabel.TabIndex = 12;
            фИОLabel.Text = "ФИО:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold);
            логинLabel.Location = new System.Drawing.Point(18, -3);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(78, 45);
            логинLabel.TabIndex = 10;
            логинLabel.Text = "Логин:";
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "TurAgEgorovaDataSet";
            this.turAgEgorovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // авторизацияBindingSource
            // 
            this.авторизацияBindingSource.DataMember = "Авторизация";
            this.авторизацияBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // авторизацияTableAdapter
            // 
            this.авторизацияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторизацияTableAdapter = this.авторизацияTableAdapter;
            this.tableAdapterManager.Виды_отдыхаTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтелиTableAdapter = null;
            this.tableAdapterManager.ПутевкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(102, 12);
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(100, 20);
            this.textBox_Log.TabIndex = 13;
            // 
            // textBox_Pas
            // 
            this.textBox_Pas.Location = new System.Drawing.Point(102, 51);
            this.textBox_Pas.Name = "textBox_Pas";
            this.textBox_Pas.PasswordChar = '*';
            this.textBox_Pas.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pas.TabIndex = 14;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(102, 89);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(100, 20);
            this.textBox_FIO.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(105, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_FIO);
            this.panel1.Controls.Add(логинLabel);
            this.panel1.Controls.Add(this.textBox_Pas);
            this.panel1.Controls.Add(this.textBox_Log);
            this.panel1.Controls.Add(фИОLabel);
            this.panel1.Controls.Add(парольLabel);
            this.panel1.Location = new System.Drawing.Point(105, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 123);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(49, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Туристическое агентство \"New Light\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "NL";
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::FF.Properties.Resources.baltic_sea_4136488_640;
            this.ClientSize = new System.Drawing.Size(608, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизацияBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource авторизацияBindingSource;
        private turAgEgorovaDataSetTableAdapters.АвторизацияTableAdapter авторизацияTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.TextBox textBox_Pas;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}