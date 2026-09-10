namespace Falco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            esciToolStripMenuItem = new ToolStripMenuItem();
            clientiToolStripMenuItem = new ToolStripMenuItem();
            mniAnagrafica = new ToolStripMenuItem();
            fatturaToolStripMenuItem = new ToolStripMenuItem();
            MniCrea = new ToolStripMenuItem();
            MniInviate = new ToolStripMenuItem();
            MniGestione = new ToolStripMenuItem();
            MniFattureRicevute = new ToolStripMenuItem();
            MniFattureInviate = new ToolStripMenuItem();
            MniLeggiFattura = new ToolStripMenuItem();
            dTTToolStripMenuItem = new ToolStripMenuItem();
            MniDocumentoDDT = new ToolStripMenuItem();
            opzioniToolStripMenuItem = new ToolStripMenuItem();
            impostazioniToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            informazioniToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(1096, 21);
            label1.TabIndex = 1;
            label1.Text = "Gestione delle fatture Elettroniche - Principale";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, clientiToolStripMenuItem, fatturaToolStripMenuItem, dTTToolStripMenuItem, opzioniToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1096, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { esciToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // esciToolStripMenuItem
            // 
            esciToolStripMenuItem.Image = Properties.Resources.Esci;
            esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            esciToolStripMenuItem.Size = new Size(184, 26);
            esciToolStripMenuItem.Text = "Esci";
            esciToolStripMenuItem.Click += esciToolStripMenuItem_Click;
            // 
            // clientiToolStripMenuItem
            // 
            clientiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniAnagrafica });
            clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            clientiToolStripMenuItem.Size = new Size(53, 20);
            clientiToolStripMenuItem.Text = "Clienti";
            // 
            // mniAnagrafica
            // 
            mniAnagrafica.Name = "mniAnagrafica";
            mniAnagrafica.Size = new Size(140, 22);
            mniAnagrafica.Text = "Anagrafica...";
            mniAnagrafica.Click += mniAnagrafica_Click;
            // 
            // fatturaToolStripMenuItem
            // 
            fatturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MniCrea, MniInviate, MniGestione, MniFattureRicevute, MniFattureInviate, MniLeggiFattura });
            fatturaToolStripMenuItem.Name = "fatturaToolStripMenuItem";
            fatturaToolStripMenuItem.Size = new Size(56, 20);
            fatturaToolStripMenuItem.Text = "Fattura";
            // 
            // MniCrea
            // 
            MniCrea.Name = "MniCrea";
            MniCrea.Size = new Size(180, 22);
            MniCrea.Text = "Crea";
            // 
            // MniInviate
            // 
            MniInviate.Name = "MniInviate";
            MniInviate.Size = new Size(180, 22);
            MniInviate.Text = "Inviate";
            // 
            // MniGestione
            // 
            MniGestione.Name = "MniGestione";
            MniGestione.Size = new Size(180, 22);
            MniGestione.Text = "Gestione";
            // 
            // MniFattureRicevute
            // 
            MniFattureRicevute.Name = "MniFattureRicevute";
            MniFattureRicevute.Size = new Size(180, 22);
            MniFattureRicevute.Text = "Fatture Ricevute...";
            // 
            // MniFattureInviate
            // 
            MniFattureInviate.Name = "MniFattureInviate";
            MniFattureInviate.Size = new Size(180, 22);
            MniFattureInviate.Text = "Fatture Inviate...";
            // 
            // MniLeggiFattura
            // 
            MniLeggiFattura.Name = "MniLeggiFattura";
            MniLeggiFattura.Size = new Size(180, 22);
            MniLeggiFattura.Text = "Leggi Fattura...";
            MniLeggiFattura.Click += leggiFatturaToolStripMenuItem_Click;
            // 
            // dTTToolStripMenuItem
            // 
            dTTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MniDocumentoDDT });
            dTTToolStripMenuItem.Name = "dTTToolStripMenuItem";
            dTTToolStripMenuItem.Size = new Size(41, 20);
            dTTToolStripMenuItem.Text = "DDT";
            // 
            // MniDocumentoDDT
            // 
            MniDocumentoDDT.Name = "MniDocumentoDDT";
            MniDocumentoDDT.Size = new Size(213, 22);
            MniDocumentoDDT.Text = "Documento Di Trasporto...";
            MniDocumentoDDT.Click += MniDocumentoDDT_Click;
            // 
            // opzioniToolStripMenuItem
            // 
            opzioniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impostazioniToolStripMenuItem });
            opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            opzioniToolStripMenuItem.Size = new Size(60, 20);
            opzioniToolStripMenuItem.Text = "Opzioni";
            // 
            // impostazioniToolStripMenuItem
            // 
            impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            impostazioniToolStripMenuItem.Size = new Size(180, 22);
            impostazioniToolStripMenuItem.Text = "Impostazioni...";
            impostazioniToolStripMenuItem.Click += impostazioniToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { informazioniToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // informazioniToolStripMenuItem
            // 
            informazioniToolStripMenuItem.Image = Properties.Resources.Informazioni;
            informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            informazioniToolStripMenuItem.Size = new Size(150, 22);
            informazioniToolStripMenuItem.Text = "Informazioni...";
            informazioniToolStripMenuItem.Click += informazioniToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 525);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Fattura Elettronica";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem esciToolStripMenuItem;
        private ToolStripMenuItem fatturaToolStripMenuItem;
        private ToolStripMenuItem MniCrea;
        private ToolStripMenuItem opzioniToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem informazioniToolStripMenuItem;
        private ToolStripMenuItem clientiToolStripMenuItem;
        private ToolStripMenuItem mniAnagrafica;
        private ToolStripMenuItem MniInviate;
        private ToolStripMenuItem MniGestione;
        private ToolStripMenuItem MniFattureRicevute;
        private ToolStripMenuItem MniFattureInviate;
        private ToolStripMenuItem dTTToolStripMenuItem;
        private ToolStripMenuItem MniDocumentoDDT;
        private ToolStripMenuItem impostazioniToolStripMenuItem;
        private ToolStripMenuItem MniLeggiFattura;
    }
}
