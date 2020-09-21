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
    public partial class FormDirekAdmin : Form
    {
        public FormDirekAdmin()
        {
            InitializeComponent();
        }

        private void Button_Sotrud_Click(object sender, EventArgs e)
        {
            FormSotrDol ff = new FormSotrDol();
            ff.ShowDialog();
        }

        private void Button_put_Click(object sender, EventArgs e)
        {
            RF r = new RF();
            r.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ProsSForm fi = new ProsSForm();
            fi.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           FilterForm f = new FilterForm();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedAdmForm af = new RedAdmForm();
            af.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelAdmForm df = new DelAdmForm();
            df.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KLIENTForm f = new KLIENTForm();
            f.ShowDialog();
        }
    }
}
