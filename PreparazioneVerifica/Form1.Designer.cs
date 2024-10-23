namespace PreparazioneVerifica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LST_VELIVOLI = new ListBox();
            BTN_NUOVO = new Button();
            BTN_AGGIUNGI = new Button();
            BTN_RIMUOVI = new Button();
            BTN_CONFRONTA = new Button();
            BTN_EQUALS = new Button();
            TXT_AGGIUNGI = new TextBox();
            label1 = new Label();
            PNL_AGGIUNGI = new Panel();
            BTN_INVIA1 = new Button();
            PNL_ELIMINA = new Panel();
            BTN_INVIA2 = new Button();
            label3 = new Label();
            TXT_ELIMINA = new TextBox();
            PNL_AGGIUNGI.SuspendLayout();
            PNL_ELIMINA.SuspendLayout();
            SuspendLayout();
            // 
            // LST_VELIVOLI
            // 
            LST_VELIVOLI.FormattingEnabled = true;
            LST_VELIVOLI.ItemHeight = 15;
            LST_VELIVOLI.Location = new Point(230, 12);
            LST_VELIVOLI.Name = "LST_VELIVOLI";
            LST_VELIVOLI.Size = new Size(558, 334);
            LST_VELIVOLI.TabIndex = 0;
            // 
            // BTN_NUOVO
            // 
            BTN_NUOVO.Location = new Point(30, 24);
            BTN_NUOVO.Name = "BTN_NUOVO";
            BTN_NUOVO.Size = new Size(174, 32);
            BTN_NUOVO.TabIndex = 1;
            BTN_NUOVO.Text = "NUOVO VELIVOLO";
            BTN_NUOVO.UseVisualStyleBackColor = true;
            BTN_NUOVO.Click += BTN_NUOVO_Click;
            // 
            // BTN_AGGIUNGI
            // 
            BTN_AGGIUNGI.Location = new Point(30, 76);
            BTN_AGGIUNGI.Name = "BTN_AGGIUNGI";
            BTN_AGGIUNGI.Size = new Size(174, 37);
            BTN_AGGIUNGI.TabIndex = 2;
            BTN_AGGIUNGI.Text = "AGGIUNGI PASSEGGERO";
            BTN_AGGIUNGI.UseVisualStyleBackColor = true;
            BTN_AGGIUNGI.Click += BTN_AGGIUNGI_Click;
            // 
            // BTN_RIMUOVI
            // 
            BTN_RIMUOVI.Location = new Point(30, 134);
            BTN_RIMUOVI.Name = "BTN_RIMUOVI";
            BTN_RIMUOVI.Size = new Size(174, 37);
            BTN_RIMUOVI.TabIndex = 3;
            BTN_RIMUOVI.Text = "RIMUOVI PASSEGGERO";
            BTN_RIMUOVI.UseVisualStyleBackColor = true;
            BTN_RIMUOVI.Click += BTN_RIMUOVI_Click;
            // 
            // BTN_CONFRONTA
            // 
            BTN_CONFRONTA.Location = new Point(30, 190);
            BTN_CONFRONTA.Name = "BTN_CONFRONTA";
            BTN_CONFRONTA.Size = new Size(174, 37);
            BTN_CONFRONTA.TabIndex = 4;
            BTN_CONFRONTA.Text = "CONFRONTA QUALITA'";
            BTN_CONFRONTA.UseVisualStyleBackColor = true;
            BTN_CONFRONTA.Click += BTN_CONFRONTA_Click;
            // 
            // BTN_EQUALS
            // 
            BTN_EQUALS.Location = new Point(30, 251);
            BTN_EQUALS.Name = "BTN_EQUALS";
            BTN_EQUALS.Size = new Size(174, 37);
            BTN_EQUALS.TabIndex = 5;
            BTN_EQUALS.Text = "SONO UGUALI?";
            BTN_EQUALS.UseVisualStyleBackColor = true;
            BTN_EQUALS.Click += BTN_EQUALS_Click;
            // 
            // TXT_AGGIUNGI
            // 
            TXT_AGGIUNGI.Location = new Point(12, 35);
            TXT_AGGIUNGI.Name = "TXT_AGGIUNGI";
            TXT_AGGIUNGI.Size = new Size(186, 23);
            TXT_AGGIUNGI.TabIndex = 6;
            TXT_AGGIUNGI.KeyPress += TXT_AGGIUNGI_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 8;
            label1.Text = "Inserire codice fiscale";
            // 
            // PNL_AGGIUNGI
            // 
            PNL_AGGIUNGI.Controls.Add(BTN_INVIA1);
            PNL_AGGIUNGI.Controls.Add(label1);
            PNL_AGGIUNGI.Controls.Add(TXT_AGGIUNGI);
            PNL_AGGIUNGI.Location = new Point(331, 113);
            PNL_AGGIUNGI.Name = "PNL_AGGIUNGI";
            PNL_AGGIUNGI.Size = new Size(211, 114);
            PNL_AGGIUNGI.TabIndex = 10;
            // 
            // BTN_INVIA1
            // 
            BTN_INVIA1.Location = new Point(12, 74);
            BTN_INVIA1.Name = "BTN_INVIA1";
            BTN_INVIA1.Size = new Size(186, 27);
            BTN_INVIA1.TabIndex = 11;
            BTN_INVIA1.Text = "INVIA";
            BTN_INVIA1.UseVisualStyleBackColor = true;
            BTN_INVIA1.Click += BTN_INVIA1_Click;
            // 
            // PNL_ELIMINA
            // 
            PNL_ELIMINA.Controls.Add(BTN_INVIA2);
            PNL_ELIMINA.Controls.Add(label3);
            PNL_ELIMINA.Controls.Add(TXT_ELIMINA);
            PNL_ELIMINA.Location = new Point(331, 113);
            PNL_ELIMINA.Name = "PNL_ELIMINA";
            PNL_ELIMINA.Size = new Size(211, 114);
            PNL_ELIMINA.TabIndex = 12;
            // 
            // BTN_INVIA2
            // 
            BTN_INVIA2.Location = new Point(12, 74);
            BTN_INVIA2.Name = "BTN_INVIA2";
            BTN_INVIA2.Size = new Size(186, 27);
            BTN_INVIA2.TabIndex = 11;
            BTN_INVIA2.Text = "INVIA";
            BTN_INVIA2.UseVisualStyleBackColor = true;
            BTN_INVIA2.Click += BTN_INVIA2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 17);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 8;
            label3.Text = "Inserire codice fiscale";
            // 
            // TXT_ELIMINA
            // 
            TXT_ELIMINA.Location = new Point(12, 35);
            TXT_ELIMINA.Name = "TXT_ELIMINA";
            TXT_ELIMINA.Size = new Size(186, 23);
            TXT_ELIMINA.TabIndex = 6;
            TXT_ELIMINA.KeyPress += TXT_ELIMINA_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 373);
            Controls.Add(PNL_ELIMINA);
            Controls.Add(PNL_AGGIUNGI);
            Controls.Add(BTN_EQUALS);
            Controls.Add(BTN_CONFRONTA);
            Controls.Add(BTN_RIMUOVI);
            Controls.Add(BTN_AGGIUNGI);
            Controls.Add(BTN_NUOVO);
            Controls.Add(LST_VELIVOLI);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PNL_AGGIUNGI.ResumeLayout(false);
            PNL_AGGIUNGI.PerformLayout();
            PNL_ELIMINA.ResumeLayout(false);
            PNL_ELIMINA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox LST_VELIVOLI;
        private Button BTN_NUOVO;
        private Button BTN_AGGIUNGI;
        private Button BTN_RIMUOVI;
        private Button BTN_CONFRONTA;
        private Button BTN_EQUALS;
        private TextBox TXT_AGGIUNGI;
        private Label label1;
        private Panel PNL_AGGIUNGI;
        private Button BTN_INVIA1;
        private Panel PNL_ELIMINA;
        private Button BTN_INVIA2;
        private Label label3;
        private TextBox TXT_ELIMINA;
    }
}
