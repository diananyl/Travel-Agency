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
    public partial class Otel_Form : Form
    {
        public Otel_Form()
        {
            InitializeComponent();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pr_OTELTableAdapter.Fill(this.turAgEgorovaDataSet.Pr_OTEL, OP_comboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pr_OTELTableAdapter.Fill(this.turAgEgorovaDataSet.Pr_OTEL, OP_comboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
