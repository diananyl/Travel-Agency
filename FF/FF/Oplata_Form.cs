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
    public partial class Oplata_Form : Form
    {
        public Oplata_Form()
        {
            InitializeComponent();
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pr_OPLATATableAdapter.Fill(this.turAgEgorovaDataSet.Pr_OPLATA, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(Op_comboBox.Text, typeof(bool))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       
    }
}
