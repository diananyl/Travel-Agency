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
    public partial class DelAdmForm : Form
    {
        public DelAdmForm()
        {
            InitializeComponent();
        }

        private void DelAdmForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.turAgEgorovaDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.View_Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.view_Отдел_кадровTableAdapter.Fill(this.turAgEgorovaDataSet.View_Отдел_кадров);

        }

        private void del_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.сотрудникиTableAdapter._DeleteQuery(Convert.ToInt64(код_сотрудникаLabel1.Text));                
                this.view_Отдел_кадровTableAdapter.Fill(this.turAgEgorovaDataSet.View_Отдел_кадров);
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertForm d = new InsertForm();
            d.ShowDialog();
        }
    }
}
