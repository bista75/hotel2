using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {

             if (cmb_n1.SelectedItem == null || cmb_n2.SelectedItem == null)
            {
                
                MessageBox.Show("Attenzione! Selezionare sia la stagione che il tipo di stanza.");
                return;
            }
            else
            {
                int giorni = Convert.ToInt32(txt_n1.Text);
                string stagione = cmb_n1.SelectedItem.ToString();
                string stanza = cmb_n2.SelectedItem.ToString();
                bool parcheggio = chk_n1.Checked;

                
            }
        }

        
    }
}
