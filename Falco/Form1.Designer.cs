﻿namespace Falco
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            esciToolStripMenuItem = new ToolStripMenuItem();
            fatturaToolStripMenuItem = new ToolStripMenuItem();
            creaToolStripMenuItem = new ToolStripMenuItem();
            opzioniToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            informazioniToolStripMenuItem = new ToolStripMenuItem();
            clientiToolStripMenuItem = new ToolStripMenuItem();
            anagraficaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(800, 28);
            label1.TabIndex = 1;
            label1.Text = "Gestione e funzionalità per la fattura elettronica";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, clientiToolStripMenuItem, fatturaToolStripMenuItem, opzioniToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { esciToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // esciToolStripMenuItem
            // 
            esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            esciToolStripMenuItem.Size = new Size(117, 26);
            esciToolStripMenuItem.Text = "Esci";
            esciToolStripMenuItem.Click += esciToolStripMenuItem_Click;
            // 
            // fatturaToolStripMenuItem
            // 
            fatturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { creaToolStripMenuItem });
            fatturaToolStripMenuItem.Name = "fatturaToolStripMenuItem";
            fatturaToolStripMenuItem.Size = new Size(68, 24);
            fatturaToolStripMenuItem.Text = "Fattura";
            // 
            // creaToolStripMenuItem
            // 
            creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            creaToolStripMenuItem.Size = new Size(224, 26);
            creaToolStripMenuItem.Text = "Crea";
            // 
            // opzioniToolStripMenuItem
            // 
            opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            opzioniToolStripMenuItem.Size = new Size(75, 24);
            opzioniToolStripMenuItem.Text = "Opzioni";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { informazioniToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(30, 24);
            toolStripMenuItem1.Text = "?";
            // 
            // informazioniToolStripMenuItem
            // 
            informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            informazioniToolStripMenuItem.Size = new Size(224, 26);
            informazioniToolStripMenuItem.Text = "Informazioni";
            // 
            // clientiToolStripMenuItem
            // 
            clientiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anagraficaToolStripMenuItem });
            clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            clientiToolStripMenuItem.Size = new Size(65, 24);
            clientiToolStripMenuItem.Text = "Clienti";
            // 
            // anagraficaToolStripMenuItem
            // 
            anagraficaToolStripMenuItem.Name = "anagraficaToolStripMenuItem";
            anagraficaToolStripMenuItem.Size = new Size(224, 26);
            anagraficaToolStripMenuItem.Text = "Anagrafica";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem anagraficaToolStripMenuItem;
    }
}
