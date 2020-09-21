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
    public partial class BronForm : Form
    {
        public BronForm()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)       
        {

            try
            {
                this.zZZabroNTableAdapter.Fill(this.turAgEgorovaDataSet.ZZZabroN, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(BF_comboBox.Text, typeof(bool))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        
    }
}
