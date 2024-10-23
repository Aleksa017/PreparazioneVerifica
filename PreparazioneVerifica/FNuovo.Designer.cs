namespace PreparazioneVerifica
{
    partial class FNuovo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CMB_SCELTA = new ComboBox();
            BTN_CHIUDI = new Button();
            BTN_INVIA = new Button();
            PNL_ELICOTTERO = new Panel();
            label4 = new Label();
            TXT_NELICHE = new TextBox();
            TXT_PROD = new TextBox();
            TXT_HMAX = new TextBox();
            TXT_HNOW = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PNL_ELICOTTERO.SuspendLayout();
            SuspendLayout();
            // 
            // CMB_SCELTA
            // 
            CMB_SCELTA.FormattingEnabled = true;
            CMB_SCELTA.Items.AddRange(new object[] { "Elicottero", "Aereo" });
            CMB_SCELTA.Location = new Point(24, 12);
            CMB_SCELTA.Name = "CMB_SCELTA";
            CMB_SCELTA.Size = new Size(161, 23);
            CMB_SCELTA.TabIndex = 0;
            CMB_SCELTA.SelectedIndexChanged += CMB_SCELTA_SelectedIndexChanged;
            CMB_SCELTA.KeyPress += CMB_SCELTA_KeyPress;
            // 
            // BTN_CHIUDI
            // 
            BTN_CHIUDI.Location = new Point(12, 277);
            BTN_CHIUDI.Name = "BTN_CHIUDI";
            BTN_CHIUDI.Size = new Size(109, 37);
            BTN_CHIUDI.TabIndex = 1;
            BTN_CHIUDI.Text = "CHIUDI";
            BTN_CHIUDI.UseVisualStyleBackColor = true;
            BTN_CHIUDI.Click += BTN_CHIUDI_Click;
            // 
            // BTN_INVIA
            // 
            BTN_INVIA.Location = new Point(441, 277);
            BTN_INVIA.Name = "BTN_INVIA";
            BTN_INVIA.Size = new Size(106, 37);
            BTN_INVIA.TabIndex = 2;
            BTN_INVIA.Text = "INVIA";
            BTN_INVIA.UseVisualStyleBackColor = true;
            BTN_INVIA.Click += BTN_INVIA_Click;
            // 
            // PNL_ELICOTTERO
            // 
            PNL_ELICOTTERO.Controls.Add(label4);
            PNL_ELICOTTERO.Controls.Add(TXT_NELICHE);
            PNL_ELICOTTERO.Location = new Point(12, 186);
            PNL_ELICOTTERO.Name = "PNL_ELICOTTERO";
            PNL_ELICOTTERO.Size = new Size(334, 49);
            PNL_ELICOTTERO.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 17);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 9;
            label4.Text = "Numero di eliche";
            // 
            // TXT_NELICHE
            // 
            TXT_NELICHE.Location = new Point(12, 14);
            TXT_NELICHE.Name = "TXT_NELICHE";
            TXT_NELICHE.Size = new Size(158, 23);
            TXT_NELICHE.TabIndex = 0;
            TXT_NELICHE.KeyPress += TXT_NELICHE_KeyPress;
            // 
            // TXT_PROD
            // 
            TXT_PROD.Location = new Point(24, 68);
            TXT_PROD.Name = "TXT_PROD";
            TXT_PROD.Size = new Size(158, 23);
            TXT_PROD.TabIndex = 1;
            // 
            // TXT_HMAX
            // 
            TXT_HMAX.Location = new Point(24, 111);
            TXT_HMAX.Name = "TXT_HMAX";
            TXT_HMAX.Size = new Size(158, 23);
            TXT_HMAX.TabIndex = 4;
            TXT_HMAX.KeyPress += TXT_HMAX_KeyPress;
            // 
            // TXT_HNOW
            // 
            TXT_HNOW.Location = new Point(24, 157);
            TXT_HNOW.Name = "TXT_HNOW";
            TXT_HNOW.Size = new Size(158, 23);
            TXT_HNOW.TabIndex = 5;
            TXT_HNOW.KeyPress += TXT_HNOW_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 71);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "Produttore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 114);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 7;
            label2.Text = "Altezza massima";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 160);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 8;
            label3.Text = "Altezza di volo attuale";
            // 
            // FNuovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 324);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXT_HNOW);
            Controls.Add(TXT_HMAX);
            Controls.Add(TXT_PROD);
            Controls.Add(PNL_ELICOTTERO);
            Controls.Add(BTN_INVIA);
            Controls.Add(BTN_CHIUDI);
            Controls.Add(CMB_SCELTA);
            Name = "FNuovo";
            Text = "FNuovo";
            Load += FNuovo_Load;
            PNL_ELICOTTERO.ResumeLayout(false);
            PNL_ELICOTTERO.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CMB_SCELTA;
        private Button BTN_CHIUDI;
        private Button BTN_INVIA;
        private Panel PNL_ELICOTTERO;
        private TextBox TXT_PROD;
        private TextBox TXT_NELICHE;
        private TextBox TXT_HMAX;
        private TextBox TXT_HNOW;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}