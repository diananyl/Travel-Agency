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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turAgEgorovaDataSet);

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.View_Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.view_Отдел_кадровTableAdapter.Fill(this.turAgEgorovaDataSet.View_Отдел_кадров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.turAgEgorovaDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(фИОTextBox1.Text)
               && !string.IsNullOrEmpty(возрастTextBox1.Text)
               && !string.IsNullOrEmpty(полTextBox1.Text) && !string.IsNullOrEmpty(адресTextBox1.Text)
               && !string.IsNullOrEmpty(паспортные_данныеTextBox1.Text) && !string.IsNullOrEmpty(код_должностиTextBox1.Text))
            {
                try
                {
                    this.сотрудникиTableAdapter.Insert(фИОTextBox1.Text, Convert.ToByte(возрастTextBox1.Text),
                    Convert.ToString(полTextBox1.Text), адресTextBox1.Text,телефонTextBox1.Text,
                    паспортные_данныеTextBox1.Text, Convert.ToInt64(код_должностиTextBox1.Text));
                    this.сотрудникиTableAdapter.Fill(this.turAgEgorovaDataSet.Сотрудники);
                    this.view_Отдел_кадровTableAdapter.Fill(this.turAgEgorovaDataSet.View_Отдел_кадров);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пустые поля недопустимы");
            }
        }
    }
}
