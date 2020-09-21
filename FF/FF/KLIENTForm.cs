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
    public partial class KLIENTForm : Form
    {
        public KLIENTForm()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
            this.tableAdapterManager.UpdateAll(this.turAgEgorovaDataSet);

        }

        private void KLIENTForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.Kliente". При необходимости она может быть перемещена или удалена.
            this.klienteTableAdapter.Fill(this.turAgEgorovaDataSet.Kliente);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.View_KLIENTi". При необходимости она может быть перемещена или удалена.

          

        }
    }
}
