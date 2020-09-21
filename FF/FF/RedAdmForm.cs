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
    public partial class RedAdmForm : Form
    {
        
        public RedAdmForm()
        {
            InitializeComponent();
        }

        private void RedAdmForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.View_Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.view_Отдел_кадровTableAdapter.Fill(this.turAgEgorovaDataSet.View_Отдел_кадров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.turAgEgorovaDataSet.Сотрудники);
           
           

        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turAgEgorovaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.сотрудникиTableAdapter._UpdateQuery(Convert.ToString(фИОTextBox.Text), 
                    Convert.ToByte(возрастTextBox.Text), Convert.ToString(полTextBox.Text),
                    Convert.ToString(адресTextBox.Text),
                    Convert.ToString(телефонTextBox.Text), Convert.ToString(паспортные_данныеTextBox.Text), 
                    Convert.ToInt64(код_должностиTextBox.Text), Convert.ToInt64(код_сотрудникаLabel2.Text));
                this.view_Отдел_кадровTableAdapter.Fill(this.turAgEgorovaDataSet.View_Отдел_кадров);
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка");
            }
        }

      
    }
    }

