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
            creaToolStripMenuItem = new ToolStripMenuItem();
            inviateToolStripMenuItem = new ToolStripMenuItem();
            gestioneToolStripMenuItem = new ToolStripMenuItem();
            fattureRicevuteToolStripMenuItem = new ToolStripMenuItem();
            fattureInviateToolStripMenuItem = new ToolStripMenuItem();
            dTTToolStripMenuItem = new ToolStripMenuItem();
            documentoDiTrasportoToolStripMenuItem = new ToolStripMenuItem();
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
            fatturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { creaToolStripMenuItem, inviateToolStripMenuItem, gestioneToolStripMenuItem, fattureRicevuteToolStripMenuItem, fattureInviateToolStripMenuItem });
            fatturaToolStripMenuItem.Name = "fatturaToolStripMenuItem";
            fatturaToolStripMenuItem.Size = new Size(56, 20);
            fatturaToolStripMenuItem.Text = "Fattura";
            // 
            // creaToolStripMenuItem
            // 
            creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            creaToolStripMenuItem.Size = new Size(168, 22);
            creaToolStripMenuItem.Text = "Crea";
            // 
            // inviateToolStripMenuItem
            // 
            inviateToolStripMenuItem.Name = "inviateToolStripMenuItem";
            inviateToolStripMenuItem.Size = new Size(168, 22);
            inviateToolStripMenuItem.Text = "Inviate";
            // 
            // gestioneToolStripMenuItem
            // 
            gestioneToolStripMenuItem.Name = "gestioneToolStripMenuItem";
            gestioneToolStripMenuItem.Size = new Size(168, 22);
            gestioneToolStripMenuItem.Text = "Gestione";
            // 
            // fattureRicevuteToolStripMenuItem
            // 
            fattureRicevuteToolStripMenuItem.Name = "fattureRicevuteToolStripMenuItem";
            fattureRicevuteToolStripMenuItem.Size = new Size(168, 22);
            fattureRicevuteToolStripMenuItem.Text = "Fatture Ricevute...";
            // 
            // fattureInviateToolStripMenuItem
            // 
            fattureInviateToolStripMenuItem.Name = "fattureInviateToolStripMenuItem";
            fattureInviateToolStripMenuItem.Size = new Size(168, 22);
            fattureInviateToolStripMenuItem.Text = "Fatture Inviate...";
            // 
            // dTTToolStripMenuItem
            // 
            dTTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentoDiTrasportoToolStripMenuItem });
            dTTToolStripMenuItem.Name = "dTTToolStripMenuItem";
            dTTToolStripMenuItem.Size = new Size(41, 20);
            dTTToolStripMenuItem.Text = "DDT";
            // 
            // documentoDiTrasportoToolStripMenuItem
            // 
            documentoDiTrasportoToolStripMenuItem.Name = "documentoDiTrasportoToolStripMenuItem";
            documentoDiTrasportoToolStripMenuItem.Size = new Size(204, 22);
            documentoDiTrasportoToolStripMenuItem.Text = "Documento Di Trasporto";
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
            impostazioniToolStripMenuItem.Size = new Size(151, 22);
            impostazioniToolStripMenuItem.Text = "Impostazioni...";
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
            informazioniToolStripMenuItem.Size = new Size(184, 26);
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
        private ToolStripMenuItem creaToolStripMenuItem;
        private ToolStripMenuItem opzioniToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem informazioniToolStripMenuItem;
        private ToolStripMenuItem clientiToolStripMenuItem;
        private ToolStripMenuItem mniAnagrafica;
        private ToolStripMenuItem inviateToolStripMenuItem;
        private ToolStripMenuItem gestioneToolStripMenuItem;
        private ToolStripMenuItem fattureRicevuteToolStripMenuItem;
        private ToolStripMenuItem fattureInviateToolStripMenuItem;
        private ToolStripMenuItem dTTToolStripMenuItem;
        private ToolStripMenuItem documentoDiTrasportoToolStripMenuItem;
        private ToolStripMenuItem impostazioniToolStripMenuItem;
    }
}
