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
    public partial class VOtd_Form : Form
    {
        public VOtd_Form()
        {
            InitializeComponent();
        }

        

        private void Vot_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.pr_Vid_OtTableAdapter.Fill(this.turAgEgorovaDataSet.Pr_Vid_Ot, VO_comboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       
    }
}
