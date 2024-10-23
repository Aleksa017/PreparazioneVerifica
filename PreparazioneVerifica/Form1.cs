namespace PreparazioneVerifica
{
    public partial class Form1 : Form
    {
        List<CVelivolo> ListaV;
        CVelivolo s1, s2;

        public Form1()
        {
            InitializeComponent();
            ListaV = new List<CVelivolo>();
        }

        private void BTN_NUOVO_Click(object sender, EventArgs e)
        {
            FNuovo f2 = new FNuovo();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Velivolo inserito correttamente!");
                if (f2.Velivolo is CElicottero)
                    LST_VELIVOLI.Items.Add((f2.Velivolo as CElicottero).DisplayInfo());
                else
                    LST_VELIVOLI.Items.Add((f2.Velivolo as CAereo).DisplayInfo());

                ListaV.Add(f2.Velivolo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PNL_AGGIUNGI.Visible = false;
            PNL_ELIMINA.Visible = false;
        }

        //AGGIUNGI PASSEGGERO
        private void BTN_AGGIUNGI_Click(object sender, EventArgs e)
        {
            PNL_AGGIUNGI.Visible = true;
        }

        private void BTN_INVIA1_Click(object sender, EventArgs e)
        {
            int index;
            string cod = TXT_AGGIUNGI.Text;
            try
            {
                index = LST_VELIVOLI.SelectedIndex;
                if (index != -1 && cod != string.Empty)
                {
                    if (ListaV[index] is CAereo a)
                    {
                        a.AddPasseggero(cod.ToUpper());
                        MessageBox.Show("Elemento inserito correttamente!");
                        LST_VELIVOLI.Items[index] = a.DisplayInfo();
                        PNL_AGGIUNGI.Visible = false;
                    }
                    else
                        MessageBox.Show("L'elemento selezionato non supporta la funzione");
                }
                else
                    MessageBox.Show("Devi prima selezionare un velivolo dalla lista e inserire un codice fiscale");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Indice non selezionato");
            }
            catch
            {
                MessageBox.Show("Si è verificato un errore!");
            }
        }

        //RIMUOVI PASSEGGERO

        private void BTN_RIMUOVI_Click(object sender, EventArgs e)
        {
            PNL_ELIMINA.Visible = true;
        }

        private void BTN_INVIA2_Click(object sender, EventArgs e)
        {
            int index;
            string cod = TXT_ELIMINA.Text;
            try
            {
                index = LST_VELIVOLI.SelectedIndex;
                if (index != -1 && cod != string.Empty)
                {
                    if (ListaV[index] is CAereo a)
                    {
                        MessageBox.Show(a.RemovePasseggero(cod.ToUpper()));
                        LST_VELIVOLI.Items[index] = a.DisplayInfo();
                        PNL_ELIMINA.Visible = false;
                    }
                    else
                        MessageBox.Show("L'elemento selezionato non supporta la funzione");
                }
                else
                    MessageBox.Show("Devi prima selezionare un velivolo dalla lista e inserire un codice fiscale");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Indice non selezionato");
            }
            catch
            {
                MessageBox.Show("Si è verificato un errore!");
            }
        }

        //CONTROLLI TEXTBOX
        private void TXT_ELIMINA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = (char)0;
        }

        private void TXT_AGGIUNGI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = (char)0;
        }

        private void BTN_CONFRONTA_Click(object sender, EventArgs e)
        {
            if (s1 == null)
            {
                s1 = ListaV[LST_VELIVOLI.SelectedIndex];
                MessageBox.Show("Elemento selezionato correttamente, seleziona il secondo e ripremi il pulsante");
            }
            else if (s2 == null)
                s2 = ListaV[LST_VELIVOLI.SelectedIndex];

            if (s1 != null && s2 != null)
            {
                if (s1 is CAereo a)
                {
                    if (a.Superiore(s2))
                        MessageBox.Show("Il primo elemento selezionato è migliore!");
                    else
                        MessageBox.Show("Il primo elemento non è superiore o non è dello stesso tipo del secondo!");
                }
                else if (s1 is CElicottero el)
                {
                    if (el.Superiore(s2))
                        MessageBox.Show("Il primo elemento selezionato è migliore!");
                    else
                        MessageBox.Show("Il primo elemento non è superiore o non è dello stesso tipo del secondo!");
                }
                s1 = null;
                s2 = null;
            }
        }

        private void BTN_EQUALS_Click(object sender, EventArgs e)
        {
            if (s1 == null)
            {
                s1 = ListaV[LST_VELIVOLI.SelectedIndex];
                MessageBox.Show("Elemento selezionato correttamente, seleziona il secondo e ripremi il pulsante");
            }
            else if (s2 == null)
                s2 = ListaV[LST_VELIVOLI.SelectedIndex];

            if (s1 != null && s2 != null)
            {
                if (s1 is CAereo primo && s2 is CAereo secondo)
                {
                    if (primo.Equals(secondo))
                        MessageBox.Show("Gli aerei selezionati sono uguali");
                    else
                        MessageBox.Show("Gli aerei selezionati non sono uguali");
                }
                else if (s1 is CElicottero first && s2 is CElicottero second)
                {
                    if (first.Equals(second))
                        MessageBox.Show("Gli elicotteri selezionati sono uguali");
                    else
                        MessageBox.Show("Gli elicotteri selezionati non sono uguali");
                }
                else
                    MessageBox.Show("Elementi selezionati di tipologie diverse!");
                s1 = null;
                s2 = null;
            }
        }
    }
}
