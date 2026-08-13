namespace Falco
{
    partial class FrmLeggiFattura
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeggiFattura));
            label1 = new Label();
            BtnCercaCartella = new Button();
            lblEtichetta = new Label();
            TxtPercorsoCartella = new TextBox();
            BtnChiudi = new Button();
            groupBox1 = new GroupBox();
            TxtNumeroFattura = new TextBox();
            label6 = new Label();
            TxtPartitaIva = new TextBox();
            label5 = new Label();
            TxtIndirizzo = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            txtNomeFornitore = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            TxtNumeroFatturaCliente = new TextBox();
            label7 = new Label();
            TxtPartitaIvaClienti = new TextBox();
            label8 = new Label();
            TxtIndirizzoCliente = new TextBox();
            label9 = new Label();
            TxtNomeCliente = new TextBox();
            label10 = new Label();
            dgvDatiFattura = new DataGridView();
            tltInformazioni = new ToolTip(components);
            BtnLeggiFattura = new Button();
            Descrizione = new DataGridViewTextBoxColumn();
            Quantita = new DataGridViewTextBoxColumn();
            PrezzoUnitario = new DataGridViewTextBoxColumn();
            IVA = new DataGridViewTextBoxColumn();
            Importo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatiFattura).BeginInit();
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
            label1.Size = new Size(1163, 21);
            label1.TabIndex = 8;
            label1.Text = "Gestione delle fatture Elettroniche - Lettura della fattura, estrapolazione informazioni";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnCercaCartella
            // 
            BtnCercaCartella.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaCartella.Location = new Point(567, 39);
            BtnCercaCartella.Name = "BtnCercaCartella";
            BtnCercaCartella.Size = new Size(30, 29);
            BtnCercaCartella.TabIndex = 13;
            BtnCercaCartella.Text = "...";
            BtnCercaCartella.TextAlign = ContentAlignment.TopLeft;
            tltInformazioni.SetToolTip(BtnCercaCartella, "Apre una finestra per la selezione del file della fattura elettronica");
            BtnCercaCartella.UseVisualStyleBackColor = true;
            BtnCercaCartella.Click += BtnCercaCartella_Click;
            // 
            // lblEtichetta
            // 
            lblEtichetta.AutoSize = true;
            lblEtichetta.Location = new Point(12, 25);
            lblEtichetta.Name = "lblEtichetta";
            lblEtichetta.Size = new Size(254, 15);
            lblEtichetta.TabIndex = 12;
            lblEtichetta.Text = "Percorso della fattura elettronica da esaminare:";
            // 
            // TxtPercorsoCartella
            // 
            TxtPercorsoCartella.Location = new Point(12, 39);
            TxtPercorsoCartella.Name = "TxtPercorsoCartella";
            TxtPercorsoCartella.ReadOnly = true;
            TxtPercorsoCartella.Size = new Size(555, 23);
            TxtPercorsoCartella.TabIndex = 11;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1056, 645);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 14;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtNumeroFattura);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtPartitaIva);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtIndirizzo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNomeFornitore);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 230);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fornitore";
            // 
            // TxtNumeroFattura
            // 
            TxtNumeroFattura.Location = new Point(21, 164);
            TxtNumeroFattura.Name = "TxtNumeroFattura";
            TxtNumeroFattura.ReadOnly = true;
            TxtNumeroFattura.Size = new Size(502, 23);
            TxtNumeroFattura.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 147);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 22;
            label6.Text = "Numero Fattura:";
            // 
            // TxtPartitaIva
            // 
            TxtPartitaIva.Location = new Point(21, 122);
            TxtPartitaIva.Name = "TxtPartitaIva";
            TxtPartitaIva.ReadOnly = true;
            TxtPartitaIva.Size = new Size(502, 23);
            TxtPartitaIva.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 105);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 20;
            label5.Text = "Partita IVA:";
            // 
            // TxtIndirizzo
            // 
            TxtIndirizzo.Location = new Point(21, 79);
            TxtIndirizzo.Name = "TxtIndirizzo";
            TxtIndirizzo.ReadOnly = true;
            TxtIndirizzo.Size = new Size(502, 23);
            TxtIndirizzo.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 62);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 18;
            label4.Text = "Indirizzo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-280, -189);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(502, 23);
            textBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-284, -206);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 15;
            label3.Text = "Nome:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Image = Properties.Resources.chiudi;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(755, 415);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 17;
            button1.Text = "Chiudi";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtNomeFornitore
            // 
            txtNomeFornitore.Location = new Point(21, 35);
            txtNomeFornitore.Name = "txtNomeFornitore";
            txtNomeFornitore.ReadOnly = true;
            txtNomeFornitore.Size = new Size(502, 23);
            txtNomeFornitore.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtNumeroFatturaCliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TxtPartitaIvaClienti);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(TxtIndirizzoCliente);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TxtNomeCliente);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(600, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(552, 230);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente";
            // 
            // TxtNumeroFatturaCliente
            // 
            TxtNumeroFatturaCliente.Location = new Point(17, 167);
            TxtNumeroFatturaCliente.Name = "TxtNumeroFatturaCliente";
            TxtNumeroFatturaCliente.ReadOnly = true;
            TxtNumeroFatturaCliente.Size = new Size(502, 23);
            TxtNumeroFatturaCliente.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 150);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 30;
            label7.Text = "Numero Fattura:";
            // 
            // TxtPartitaIvaClienti
            // 
            TxtPartitaIvaClienti.Location = new Point(17, 125);
            TxtPartitaIvaClienti.Name = "TxtPartitaIvaClienti";
            TxtPartitaIvaClienti.ReadOnly = true;
            TxtPartitaIvaClienti.Size = new Size(502, 23);
            TxtPartitaIvaClienti.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 108);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 28;
            label8.Text = "Partita IVA:";
            // 
            // TxtIndirizzoCliente
            // 
            TxtIndirizzoCliente.Location = new Point(17, 82);
            TxtIndirizzoCliente.Name = "TxtIndirizzoCliente";
            TxtIndirizzoCliente.ReadOnly = true;
            TxtIndirizzoCliente.Size = new Size(502, 23);
            TxtIndirizzoCliente.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 65);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 26;
            label9.Text = "Indirizzo:";
            // 
            // TxtNomeCliente
            // 
            TxtNomeCliente.Location = new Point(17, 38);
            TxtNomeCliente.Name = "TxtNomeCliente";
            TxtNomeCliente.ReadOnly = true;
            TxtNomeCliente.Size = new Size(502, 23);
            TxtNomeCliente.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 21);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 24;
            label10.Text = "Nome:";
            // 
            // dgvDatiFattura
            // 
            dgvDatiFattura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatiFattura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatiFattura.Columns.AddRange(new DataGridViewColumn[] { Descrizione, Quantita, PrezzoUnitario, IVA, Importo });
            dgvDatiFattura.Location = new Point(12, 320);
            dgvDatiFattura.Name = "dgvDatiFattura";
            dgvDatiFattura.Size = new Size(1139, 271);
            dgvDatiFattura.TabIndex = 17;
            // 
            // BtnLeggiFattura
            // 
            BtnLeggiFattura.Location = new Point(14, 64);
            BtnLeggiFattura.Name = "BtnLeggiFattura";
            BtnLeggiFattura.Size = new Size(75, 23);
            BtnLeggiFattura.TabIndex = 18;
            BtnLeggiFattura.Text = "Leggi fattura";
            BtnLeggiFattura.UseVisualStyleBackColor = true;
            BtnLeggiFattura.Click += BtnLeggiFattura_Click;
            // 
            // Descrizione
            // 
            Descrizione.DataPropertyName = "Descrizione";
            Descrizione.HeaderText = "Descrizione";
            Descrizione.MinimumWidth = 100;
            Descrizione.Name = "Descrizione";
            Descrizione.Width = 300;
            // 
            // Quantita
            // 
            Quantita.DataPropertyName = "Quantita";
            Quantita.HeaderText = "Quantità";
            Quantita.Name = "Quantita";
            Quantita.Width = 80;
            // 
            // PrezzoUnitario
            // 
            PrezzoUnitario.DataPropertyName = "PrezzoUnitario";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            PrezzoUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            PrezzoUnitario.HeaderText = "Prezzo Unitario";
            PrezzoUnitario.MinimumWidth = 100;
            PrezzoUnitario.Name = "PrezzoUnitario";
            PrezzoUnitario.Width = 300;
            // 
            // IVA
            // 
            IVA.DataPropertyName = "IVA";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            IVA.DefaultCellStyle = dataGridViewCellStyle2;
            IVA.HeaderText = "Iva";
            IVA.Name = "IVA";
            IVA.Width = 80;
            // 
            // Importo
            // 
            Importo.DataPropertyName = "Importo";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Importo.DefaultCellStyle = dataGridViewCellStyle3;
            Importo.HeaderText = "Importo";
            Importo.MinimumWidth = 100;
            Importo.Name = "Importo";
            Importo.Width = 300;
            // 
            // FrmLeggiFattura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 687);
            Controls.Add(BtnLeggiFattura);
            Controls.Add(dgvDatiFattura);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BtnChiudi);
            Controls.Add(BtnCercaCartella);
            Controls.Add(lblEtichetta);
            Controls.Add(TxtPercorsoCartella);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLeggiFattura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Programma gratuito di Fattura Elettronica";
            Load += FrmLeggiFattura_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatiFattura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnCercaCartella;
        private Label lblEtichetta;
        private TextBox TxtPercorsoCartella;
        private Button BtnChiudi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvDatiFattura;
        private TextBox txtNomeFornitore;
        private Label label2;
        private TextBox TxtPartitaIva;
        private Label label5;
        private TextBox TxtIndirizzo;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private TextBox TxtNumeroFattura;
        private Label label6;
        private ToolTip tltInformazioni;
        private Button BtnLeggiFattura;
        private TextBox TxtNumeroFatturaCliente;
        private Label label7;
        private TextBox TxtPartitaIvaClienti;
        private Label label8;
        private TextBox TxtIndirizzoCliente;
        private Label label9;
        private TextBox TxtNomeCliente;
        private Label label10;
        private DataGridViewTextBoxColumn Descrizione;
        private DataGridViewTextBoxColumn Quantita;
        private DataGridViewTextBoxColumn PrezzoUnitario;
        private DataGridViewTextBoxColumn IVA;
        private DataGridViewTextBoxColumn Importo;
    }
}