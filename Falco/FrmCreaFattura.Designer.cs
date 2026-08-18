namespace Falco
{
    partial class FrmCreaFattura
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
            BtnCrea = new Button();
            label2 = new Label();
            cmbClienti = new ComboBox();
            BtnNuovoCliente = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
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
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCrea
            // 
            BtnCrea.Location = new Point(29, 402);
            BtnCrea.Margin = new Padding(3, 2, 3, 2);
            BtnCrea.Name = "BtnCrea";
            BtnCrea.Size = new Size(82, 22);
            BtnCrea.TabIndex = 3;
            BtnCrea.Text = "Crea";
            BtnCrea.UseVisualStyleBackColor = true;
            BtnCrea.Click += BtnCrea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1080, 35);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Cliente:";
            // 
            // cmbClienti
            // 
            cmbClienti.FormattingEnabled = true;
            cmbClienti.Location = new Point(1085, 54);
            cmbClienti.Margin = new Padding(3, 2, 3, 2);
            cmbClienti.Name = "cmbClienti";
            cmbClienti.Size = new Size(224, 23);
            cmbClienti.TabIndex = 5;
            // 
            // BtnNuovoCliente
            // 
            BtnNuovoCliente.Location = new Point(1315, 53);
            BtnNuovoCliente.Margin = new Padding(3, 2, 3, 2);
            BtnNuovoCliente.Name = "BtnNuovoCliente";
            BtnNuovoCliente.Size = new Size(36, 22);
            BtnNuovoCliente.TabIndex = 6;
            BtnNuovoCliente.Text = "...";
            toolTip1.SetToolTip(BtnNuovoCliente, "Crea un nuovo cliente");
            BtnNuovoCliente.UseVisualStyleBackColor = true;
            BtnNuovoCliente.Click += BtnNuovoCliente_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1368, 21);
            label1.TabIndex = 7;
            label1.Text = "Gestione delle fatture Elettroniche - Creazione delle fatture";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(0, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 230);
            groupBox1.TabIndex = 16;
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
            button1.Location = new Point(1107, 545);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 0;
            label7.Text = "Nome:";
            // 
            // FrmCreaFattura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 631);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(BtnNuovoCliente);
            Controls.Add(cmbClienti);
            Controls.Add(label2);
            Controls.Add(BtnCrea);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCreaFattura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Fattura Elettronica";
            Load += FrmCreaFattura_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnCrea;
        private Label label2;
        private ComboBox cmbClienti;
        private Button BtnNuovoCliente;
        private ToolTip toolTip1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox TxtNumeroFattura;
        private Label label6;
        private TextBox TxtPartitaIva;
        private Label label5;
        private TextBox TxtIndirizzo;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private TextBox txtNomeFornitore;
        private Label label7;
    }
}