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
    public partial class FormGlMan : Form
    {
        public FormGlMan()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ProsSForm ff = new ProsSForm();
            ff.ShowDialog();
        }

        private void St_button_Click(object sender, EventArgs e)
        {
            Strana_Form ff = new Strana_Form();
            ff.ShowDialog();
        }       

      

        private void Ot_button_Click_1(object sender, EventArgs e)
        {
            Otel_Form fo = new Otel_Form();
            fo.ShowDialog();
        }

        private void Vot_button_Click_1(object sender, EventArgs e)
        {
            VOtd_Form ft = new VOtd_Form();
            ft.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BronForm frt = new BronForm();
            frt.ShowDialog();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Oplata_Form fot = new Oplata_Form();
            fot.ShowDialog();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RF r = new RF();
            r.ShowDialog();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KLIENTForm f = new KLIENTForm();
            f.ShowDialog();
        }
    }
}
