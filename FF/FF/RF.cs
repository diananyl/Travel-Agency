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
    public partial class RF : Form
    {
        public RF()
        {
            InitializeComponent();
        }

        private void RF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.turAgEgorovaDataSet.View_1);

        }
    }
}
