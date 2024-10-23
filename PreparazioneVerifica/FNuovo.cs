using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparazioneVerifica
{
    public partial class FNuovo : Form
    {
        public CVelivolo Velivolo { get; set; }
        public FNuovo()
        {
            InitializeComponent();
        }

        private void FNuovo_Load(object sender, EventArgs e)
        {
            PNL_ELICOTTERO.Enabled = false;
            PNL_ELICOTTERO.Visible = false;
        }

        private void CMB_SCELTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void TXT_HMAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = (char)0;
        }

        private void TXT_NELICHE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = (char)0;
        }

        private void TXT_HNOW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = (char)0;
        }

        private void BTN_CHIUDI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_INVIA_Click(object sender, EventArgs e)
        {
            int index, hMax, hNow, nEliche;
            string tHNow = TXT_HNOW.Text, tNEliche, tHMax = TXT_HMAX.Text;
            try
            {
                index = CMB_SCELTA.SelectedIndex;
                if (index != -1 && tHNow != string.Empty && tHMax != string.Empty && TXT_PROD.Text != string.Empty)
                {
                    int.TryParse(tHMax, out hMax);
                    int.TryParse(tHNow, out hNow);
                    if (index == 0 && hNow <= hMax && TXT_NELICHE.Text != string.Empty)
                    {
                        int.TryParse(TXT_NELICHE.Text, out nEliche);
                        Velivolo = new CElicottero(TXT_PROD.Text, hMax, hNow, nEliche);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (index == 1 && hNow <= hMax)
                    {
                        Velivolo = new CAereo(TXT_PROD.Text, hMax, hNow);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                        MessageBox.Show("Qualcosa è andato storto!");
                }
                else
                    MessageBox.Show("Qualcosa è andato storto!");
            }
            catch
            {
                MessageBox.Show("Qualcosa è andato storto!");
            }
        }

        private void CMB_SCELTA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CMB_SCELTA.SelectedIndex == 0) 
            {
                PNL_ELICOTTERO.Enabled = true;
                PNL_ELICOTTERO.Visible = true;
            }
            else
            {
                PNL_ELICOTTERO.Enabled = false;
                PNL_ELICOTTERO.Visible = false;
            }
        }
    }
}
