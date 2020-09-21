using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void авторизацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.авторизацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turAgEgorovaDataSet);

        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.Авторизация". При необходимости она может быть перемещена или удалена.
            this.авторизацияTableAdapter.Fill(this.turAgEgorovaDataSet.Авторизация);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox_Log.Text)
                && !string.IsNullOrWhiteSpace(textBox_Pas.Text)
                && !string.IsNullOrWhiteSpace(textBox_FIO.Text))
                {
                try
                {
                    this.авторизацияTableAdapter.Insert(textBox_Log.Text, textBox_Pas.Text, textBox_FIO.Text, "c");
                    MessageBox.Show("Данные зарегистрированы");
                }
                catch(Exception)
                {
                    MessageBox.Show("Заполните поля");
                }
                }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}
