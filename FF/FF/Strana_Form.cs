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
    public partial class Strana_Form : Form
    {
        public Strana_Form()
        {
            InitializeComponent();
        }

        

        private void Button_st_Click(object sender, EventArgs e)
        
            {
            try
            {
                this.pr_STRANATableAdapter.Fill(this.turAgEgorovaDataSet.Pr_STRANA, ST_comboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
       
    }
}
