namespace FF
{
    partial class Avtor
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
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label рольLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pas_textBox = new System.Windows.Forms.TextBox();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.button_Vhod = new System.Windows.Forms.Button();
            this.button_Reg = new System.Windows.Forms.Button();
            this.turAgEgorovaDataSet = new FF.turAgEgorovaDataSet();
            this.авторизацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авторизацияTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.АвторизацияTableAdapter();
            this.tableAdapterManager = new FF.turAgEgorovaDataSetTableAdapters.TableAdapterManager();
            this.procedure_VhodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedure_VhodTableAdapter = new FF.turAgEgorovaDataSetTableAdapters.Procedure_VhodTableAdapter();
            this.кодLabel1 = new System.Windows.Forms.Label();
            this.фИОLabel1 = new System.Windows.Forms.Label();
            this.рольLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            кодLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure_VhodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            логинLabel.Location = new System.Drawing.Point(21, 16);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(78, 45);
            логинLabel.TabIndex = 0;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            парольLabel.Location = new System.Drawing.Point(20, 63);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(88, 45);
            парольLabel.TabIndex = 2;
            парольLabel.Text = "Пароль:";
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(83, 100);
            кодLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 9;
            кодLabel.Text = "Код:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(81, 131);
            фИОLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 10;
            фИОLabel.Text = "ФИО:";
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Location = new System.Drawing.Point(83, 162);
            рольLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(35, 13);
            рольLabel.TabIndex = 11;
            рольLabel.Text = "Роль:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Pas_textBox);
            this.panel1.Controls.Add(this.Log_textBox);
            this.panel1.Controls.Add(this.button_Vhod);
            this.panel1.Controls.Add(парольLabel);
            this.panel1.Controls.Add(логинLabel);
            this.panel1.Location = new System.Drawing.Point(42, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 175);
            this.panel1.TabIndex = 0;
            // 
            // Pas_textBox
            // 
            this.Pas_textBox.Location = new System.Drawing.Point(104, 78);
            this.Pas_textBox.Name = "Pas_textBox";
            this.Pas_textBox.PasswordChar = '*';
            this.Pas_textBox.Size = new System.Drawing.Size(141, 20);
            this.Pas_textBox.TabIndex = 2;
            // 
            // Log_textBox
            // 
            this.Log_textBox.Location = new System.Drawing.Point(104, 31);
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(141, 20);
            this.Log_textBox.TabIndex = 1;
            // 
            // button_Vhod
            // 
            this.button_Vhod.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_Vhod.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Vhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Vhod.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_Vhod.Location = new System.Drawing.Point(34, 117);
            this.button_Vhod.Name = "button_Vhod";
            this.button_Vhod.Size = new System.Drawing.Size(211, 44);
            this.button_Vhod.TabIndex = 3;
            this.button_Vhod.Text = "Вход";
            this.button_Vhod.UseVisualStyleBackColor = true;
            this.button_Vhod.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Reg
            // 
            this.button_Reg.AutoSize = true;
            this.button_Reg.BackColor = System.Drawing.Color.Transparent;
            this.button_Reg.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reg.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_Reg.Location = new System.Drawing.Point(77, 252);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(212, 47);
            this.button_Reg.TabIndex = 4;
            this.button_Reg.Text = "Регистрация";
            this.button_Reg.UseVisualStyleBackColor = false;
            this.button_Reg.Click += new System.EventHandler(this.button2_Click);
            // 
            // turAgEgorovaDataSet
            // 
            this.turAgEgorovaDataSet.DataSetName = "turAgEgorovaDataSet";
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
            // procedure_VhodBindingSource
            // 
            this.procedure_VhodBindingSource.DataMember = "Procedure_Vhod";
            this.procedure_VhodBindingSource.DataSource = this.turAgEgorovaDataSet;
            // 
            // procedure_VhodTableAdapter
            // 
            this.procedure_VhodTableAdapter.ClearBeforeFill = true;
            // 
            // кодLabel1
            // 
            this.кодLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedure_VhodBindingSource, "Код", true));
            this.кодLabel1.Location = new System.Drawing.Point(121, 100);
            this.кодLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.кодLabel1.Name = "кодLabel1";
            this.кодLabel1.Size = new System.Drawing.Size(75, 19);
            this.кодLabel1.TabIndex = 10;
            this.кодLabel1.Text = "label2";
            // 
            // фИОLabel1
            // 
            this.фИОLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedure_VhodBindingSource, "ФИО", true));
            this.фИОLabel1.Location = new System.Drawing.Point(121, 131);
            this.фИОLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.фИОLabel1.Name = "фИОLabel1";
            this.фИОLabel1.Size = new System.Drawing.Size(75, 19);
            this.фИОLabel1.TabIndex = 11;
            this.фИОLabel1.Text = "label2";
            // 
            // рольLabel1
            // 
            this.рольLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedure_VhodBindingSource, "Роль", true));
            this.рольLabel1.Location = new System.Drawing.Point(121, 162);
            this.рольLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.рольLabel1.Name = "рольLabel1";
            this.рольLabel1.Size = new System.Drawing.Size(75, 19);
            this.рольLabel1.TabIndex = 12;
            this.рольLabel1.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Туристическое агентство \"New Light\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "NL";
            // 
            // Avtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::FF.Properties.Resources.clouds_1846124_640;
            this.ClientSize = new System.Drawing.Size(608, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(рольLabel);
            this.Controls.Add(this.рольLabel1);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОLabel1);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.кодLabel1);
            this.Controls.Add(this.button_Reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Avtor";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turAgEgorovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedure_VhodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Vhod;
        private System.Windows.Forms.Button button_Reg;
        private System.Windows.Forms.TextBox Pas_textBox;
        private System.Windows.Forms.TextBox Log_textBox;
        private turAgEgorovaDataSet turAgEgorovaDataSet;
        private System.Windows.Forms.BindingSource авторизацияBindingSource;
        private turAgEgorovaDataSetTableAdapters.АвторизацияTableAdapter авторизацияTableAdapter;
        private turAgEgorovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource procedure_VhodBindingSource;
        private turAgEgorovaDataSetTableAdapters.Procedure_VhodTableAdapter procedure_VhodTableAdapter;
        private System.Windows.Forms.Label кодLabel1;
        private System.Windows.Forms.Label фИОLabel1;
        private System.Windows.Forms.Label рольLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

