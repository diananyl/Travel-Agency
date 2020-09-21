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
    public partial class Avtor : Form
    {
        public Avtor()
        {
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.procedure_VhodTableAdapter.Fill(this.turAgEgorovaDataSet.Procedure_Vhod, Log_textBox.Text, Pas_textBox.Text);
                Log_textBox.Text = "";
                Pas_textBox.Text = "";
                if (рольLabel1.Text == "a")
                {
                  
                    FormDirekAdmin f = new FormDirekAdmin();
                    f.label1.Text = кодLabel1.Text;
                    f.label2.Text = фИОLabel1.Text;                   
                    f.ShowDialog();
                    
                }
                if (рольLabel1.Text == "glm")
                {
                    FormGlMan fg = new FormGlMan();
                    fg.label_fg2.Text = кодLabel1.Text;                    
                    fg.Text = фИОLabel1.Text;
                    fg.ShowDialog();                   
                }
                if (рольLabel1.Text == "m")
                {
                    Man_Form fg = new Man_Form();
                    fg.label_fg2.Text = кодLabel1.Text;
                    fg.Text = фИОLabel1.Text;
                    fg.ShowDialog();
                }
                if (рольLabel1.Text == "b")
                {
                FormBuch fb = new FormBuch();
                    fb.label2.Text = кодLabel1.Text;
                    fb.Text = фИОLabel1.Text;
                    fb.ShowDialog();
                }
                if (рольLabel1.Text == "c")
                {
                    ClientForm fb = new ClientForm();
                    fb.label2.Text = кодLabel1.Text;
                    fb.Text = фИОLabel1.Text;
                    fb.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message +" Введите логин и пароль");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turAgEgorovaDataSet.Авторизация". При необходимости она может быть перемещена или удалена.
            this.авторизацияTableAdapter.Fill(this.turAgEgorovaDataSet.Авторизация);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReg ff = new FormReg();
            ff.ShowDialog();
        }

        

        private void АвторизацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.авторизацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turAgEgorovaDataSet);

        }

        
    }
}
