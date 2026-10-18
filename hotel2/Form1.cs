using System;
using System.CodeDom;
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
                
                MessageBox.Show(
                        "Selezionare sia la stagione che il tipo di stanza",
                        "Attenzione!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                string stagione = cmb_n1.SelectedItem.ToString();
                string stanza = cmb_n2.SelectedItem.ToString();
                bool parcheggio = chk_n1.Checked;
                double costoGiornaliero = 0, costoParcheggio = 0, costoStanza = 0;

                if (stagione == "Bassa Stagione")
                {
                    if (stanza == "Base")
                    {
                        costoGiornaliero = 15;
                    }
                    else if (stanza == "Media")
                    {
                        costoGiornaliero = 30;
                    }
                    else if(stanza == "Alta")
                    {
                        costoGiornaliero = 45;
                    }
                    
                }
                else if (stagione == "Media Stagione")
                {
                    if (stanza == "Base")
                    {
                        costoGiornaliero = 20;
                    }
                    else if (stanza == "Media")
                    {
                        costoGiornaliero = 35;
                    }
                    else if (stanza == "Alta")
                    {
                        costoGiornaliero = 50;
                    }
                }
                else if (stagione == "Alta Stagione")
                {
                    if (stanza == "Base")
                    {
                        costoGiornaliero = 25;
                    }
                    else if (stanza == "Media")
                    {
                        costoGiornaliero = 40;
                    }
                    else if (stanza == "Alta")
                    {
                        costoGiornaliero = 55;
                    }

                }


                if (txt_n1.Text == "")
                {
                    MessageBox.Show(
                        "Inserire un numero di giorni",
                        "Attenzione!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                int giorni = Convert.ToInt32(txt_n1.Text);
                if (giorni <= 0)
                {
                    
                    MessageBox.Show(
                        "Inserire correttamente il numero di giorni",
                        "Attenzione!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txt_n1.Clear();
                    return;
                    
                }
                else
                {
                    
                    for (int i = 1; i <= giorni; i++)
                    {
                        if (i <= 2)
                        {
                            costoStanza += costoGiornaliero;
                        }
                        else if (i <= 7)
                        {
                            costoStanza += costoGiornaliero * 0.75;
                        }
                        else
                        {
                            costoStanza += costoGiornaliero * 0.65;
                        }
                    }
                }

                
               

                if (chk_n1.Checked)
                {
                    costoParcheggio = giorni * 5;
                }

                MessageBox.Show($"Stagione: {stagione} | Stanza: {stanza} | Tariffa giornaliera: {costoGiornaliero} | Costo Stanza: {costoStanza}");
                double totale = costoStanza + costoParcheggio;
                lbl_n6.Text = "Spesa totale:" + totale;
            }
        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Questo programma permette di calcolare il preventivo per il soggiorno del Bista Grand Hotel.\n\n" +
                "L'utente può selezionare la stagione, il tipo di stanza, la durata della permanenza e l'eventuale parcheggio.\n\n" +
                "Il sistema applicherà automaticamente tariffe e sconti (25% dai 3 ai 7 giorni e 35% oltre i 7) mostrando poi il costo totale.",
                "Informazioni sul programma",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

    }
}
