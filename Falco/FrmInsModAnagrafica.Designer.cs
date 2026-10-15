namespace Falco
{
    partial class FrmInsModAnagrafica
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
            label1 = new Label();
            BtnChiudi = new Button();
            label2 = new Label();
            TxtRagioneSociale = new TextBox();
            TxtPersonaRiferimento = new TextBox();
            label3 = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            TxtTelefono = new TextBox();
            label5 = new Label();
            TxtPartitaIva = new TextBox();
            label6 = new Label();
            TxtIndirizzo = new TextBox();
            label7 = new Label();
            TxtIban = new TextBox();
            label8 = new Label();
            TxtSito = new TextBox();
            label9 = new Label();
            TxtSettore = new TextBox();
            label10 = new Label();
            TxtPec = new TextBox();
            label11 = new Label();
            TxtNazione = new TextBox();
            label12 = new Label();
            TxtAlbo = new TextBox();
            label13 = new Label();
            TxtNote = new TextBox();
            label14 = new Label();
            textBox14 = new TextBox();
            label15 = new Label();
            BtnSalva = new Button();
            BtnInserisci = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1324, 21);
            label1.TabIndex = 9;
            label1.Text = "Gestione delle fatture Elettroniche - Anagrafica Clienti";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1220, 532);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 17;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 35);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 18;
            label2.Text = "Ragione Sociale:";
            // 
            // TxtRagioneSociale
            // 
            TxtRagioneSociale.Location = new Point(19, 53);
            TxtRagioneSociale.Name = "TxtRagioneSociale";
            TxtRagioneSociale.Size = new Size(267, 23);
            TxtRagioneSociale.TabIndex = 19;
            TxtRagioneSociale.Enter += txt_Enter;
            TxtRagioneSociale.Leave += txt_Leave;
            // 
            // TxtPersonaRiferimento
            // 
            TxtPersonaRiferimento.Location = new Point(356, 68);
            TxtPersonaRiferimento.Name = "TxtPersonaRiferimento";
            TxtPersonaRiferimento.Size = new Size(267, 23);
            TxtPersonaRiferimento.TabIndex = 21;
            TxtPersonaRiferimento.Enter += txt_Enter;
            TxtPersonaRiferimento.Leave += txt_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Email:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(356, 122);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(267, 23);
            TxtEmail.TabIndex = 23;
            TxtEmail.Enter += txt_Enter;
            TxtEmail.Leave += txt_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 50);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 22;
            label4.Text = "Persona di Riferimento:";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(23, 235);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(267, 23);
            TxtTelefono.TabIndex = 25;
            TxtTelefono.Enter += txt_Enter;
            TxtTelefono.Leave += txt_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 217);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 24;
            label5.Text = "Telefono:";
            // 
            // TxtPartitaIva
            // 
            TxtPartitaIva.Location = new Point(23, 181);
            TxtPartitaIva.Name = "TxtPartitaIva";
            TxtPartitaIva.Size = new Size(267, 23);
            TxtPartitaIva.TabIndex = 27;
            TxtPartitaIva.Enter += txt_Enter;
            TxtPartitaIva.Leave += txt_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 163);
            label6.Name = "label6";
            label6.Size = new Size(148, 15);
            label6.TabIndex = 26;
            label6.Text = "Partita Iva / Codice Fiscale:";
            // 
            // TxtIndirizzo
            // 
            TxtIndirizzo.Location = new Point(23, 121);
            TxtIndirizzo.Name = "TxtIndirizzo";
            TxtIndirizzo.Size = new Size(267, 23);
            TxtIndirizzo.TabIndex = 29;
            TxtIndirizzo.Enter += txt_Enter;
            TxtIndirizzo.Leave += txt_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 98);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 28;
            label7.Text = "Indirizzo:";
            // 
            // TxtIban
            // 
            TxtIban.Location = new Point(356, 235);
            TxtIban.Name = "TxtIban";
            TxtIban.Size = new Size(267, 23);
            TxtIban.TabIndex = 33;
            TxtIban.Enter += txt_Enter;
            TxtIban.Leave += txt_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 163);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 32;
            label8.Text = "Sito:";
            // 
            // TxtSito
            // 
            TxtSito.Location = new Point(356, 181);
            TxtSito.Name = "TxtSito";
            TxtSito.Size = new Size(267, 23);
            TxtSito.TabIndex = 31;
            TxtSito.Enter += txt_Enter;
            TxtSito.Leave += txt_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 217);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 30;
            label9.Text = "Iban:";
            // 
            // TxtSettore
            // 
            TxtSettore.Location = new Point(657, 122);
            TxtSettore.Name = "TxtSettore";
            TxtSettore.Size = new Size(267, 23);
            TxtSettore.TabIndex = 37;
            TxtSettore.Enter += txt_Enter;
            TxtSettore.Leave += txt_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(657, 50);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 36;
            label10.Text = "Indirizzo PEC:";
            // 
            // TxtPec
            // 
            TxtPec.Location = new Point(657, 68);
            TxtPec.Name = "TxtPec";
            TxtPec.Size = new Size(267, 23);
            TxtPec.TabIndex = 35;
            TxtPec.Enter += txt_Enter;
            TxtPec.Leave += txt_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(657, 104);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 34;
            label11.Text = "Settore:";
            // 
            // TxtNazione
            // 
            TxtNazione.Location = new Point(657, 235);
            TxtNazione.Name = "TxtNazione";
            TxtNazione.Size = new Size(267, 23);
            TxtNazione.TabIndex = 41;
            TxtNazione.Enter += txt_Enter;
            TxtNazione.Leave += txt_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(657, 163);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 40;
            label12.Text = "Albo:";
            // 
            // TxtAlbo
            // 
            TxtAlbo.Location = new Point(657, 181);
            TxtAlbo.Name = "TxtAlbo";
            TxtAlbo.Size = new Size(267, 23);
            TxtAlbo.TabIndex = 39;
            TxtAlbo.Enter += txt_Enter;
            TxtAlbo.Leave += txt_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(657, 217);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 38;
            label13.Text = "Nazione:";
            // 
            // TxtNote
            // 
            TxtNote.Location = new Point(949, 122);
            TxtNote.Multiline = true;
            TxtNote.Name = "TxtNote";
            TxtNote.Size = new Size(267, 136);
            TxtNote.TabIndex = 45;
            TxtNote.Enter += txt_Enter;
            TxtNote.Leave += txt_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(949, 50);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 44;
            label14.Text = "label14";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(949, 68);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(267, 23);
            textBox14.TabIndex = 43;
            textBox14.Enter += txt_Enter;
            textBox14.Leave += txt_Leave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(949, 104);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 42;
            label15.Text = "Note";
            // 
            // BtnSalva
            // 
            BtnSalva.Location = new Point(122, 516);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 47;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Visible = false;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Location = new Point(32, 516);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 46;
            BtnInserisci.Text = "Inserisci";
            BtnInserisci.UseVisualStyleBackColor = true;
            BtnInserisci.Click += BtnInserisci_Click;
            // 
            // FrmInsModAnagrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 565);
            Controls.Add(BtnSalva);
            Controls.Add(BtnInserisci);
            Controls.Add(TxtNote);
            Controls.Add(label14);
            Controls.Add(textBox14);
            Controls.Add(label15);
            Controls.Add(TxtNazione);
            Controls.Add(label12);
            Controls.Add(TxtAlbo);
            Controls.Add(label13);
            Controls.Add(TxtSettore);
            Controls.Add(label10);
            Controls.Add(TxtPec);
            Controls.Add(label11);
            Controls.Add(TxtIban);
            Controls.Add(label8);
            Controls.Add(TxtSito);
            Controls.Add(label9);
            Controls.Add(TxtIndirizzo);
            Controls.Add(label7);
            Controls.Add(TxtPartitaIva);
            Controls.Add(label6);
            Controls.Add(TxtTelefono);
            Controls.Add(label5);
            Controls.Add(TxtEmail);
            Controls.Add(label4);
            Controls.Add(TxtPersonaRiferimento);
            Controls.Add(label3);
            Controls.Add(TxtRagioneSociale);
            Controls.Add(label2);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            Name = "FrmInsModAnagrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Inserimento modifica Anagrafica";
            Load += FrmInsModAnagrafica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private Label label2;
        private TextBox TxtRagioneSociale;
        private TextBox TxtPersonaRiferimento;
        private Label label3;
        private TextBox TxtEmail;
        private Label label4;
        private TextBox TxtTelefono;
        private Label label5;
        private TextBox TxtPartitaIva;
        private Label label6;
        private TextBox TxtIndirizzo;
        private Label label7;
        private TextBox TxtIban;
        private Label label8;
        private TextBox TxtSito;
        private Label label9;
        private TextBox TxtSettore;
        private Label label10;
        private TextBox TxtPec;
        private Label label11;
        private TextBox TxtNazione;
        private Label label12;
        private TextBox TxtAlbo;
        private Label label13;
        private TextBox TxtNote;
        private Label label14;
        private TextBox textBox14;
        private Label label15;
        private Button BtnSalva;
        private Button BtnInserisci;
    }
}