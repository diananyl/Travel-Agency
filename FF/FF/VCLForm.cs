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
    public partial class VCLForm : Form
    {
        public VCLForm()
        {
            InitializeComponent();
        }

        private void VCLForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.View_Klient". При необходимости она может быть перемещена или удалена.
            this.view_KlientTableAdapter.Fill(this.turAgEgorovaDataSet.View_Klient);


        }
    }
}
