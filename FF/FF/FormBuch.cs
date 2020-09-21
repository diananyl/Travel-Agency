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
    public partial class FormBuch : Form
    {
        public FormBuch()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RF fp = new RF();
            fp.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProsSForm f = new ProsSForm();
            f.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormSotrDol f = new FormSotrDol();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KLIENTForm f = new KLIENTForm();
            f.ShowDialog();
        }
    }
}
