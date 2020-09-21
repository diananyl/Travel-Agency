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
    public partial class ProsSForm : Form
    {
        public ProsSForm()
        {
            InitializeComponent();
        }

        private void ProsSForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.View_Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.view_Отдел_кадровTableAdapter.Fill(this.turAgEgorovaDataSet.View_Отдел_кадров);

        }
    }
}
