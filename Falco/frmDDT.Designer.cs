namespace Falco
{
    partial class frmDDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDDT));
            label1 = new Label();
            BtnChiudi = new Button();
            dtgDatiDTT = new DataGridView();
            BtnInserisci = new Button();
            cmsMenu = new ContextMenuStrip(components);
            MniModifica = new ToolStripMenuItem();
            eliminaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgDatiDTT).BeginInit();
            cmsMenu.SuspendLayout();
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
            label1.Size = new Size(1403, 21);
            label1.TabIndex = 8;
            label1.Text = "Gestione delle fatture Elettroniche - Gestione documento di Trasporto";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1269, 731);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 15;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // dtgDatiDTT
            // 
            dtgDatiDTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiDTT.Dock = DockStyle.Top;
            dtgDatiDTT.Location = new Point(0, 21);
            dtgDatiDTT.Name = "dtgDatiDTT";
            dtgDatiDTT.Size = new Size(1403, 597);
            dtgDatiDTT.TabIndex = 16;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Location = new Point(17, 736);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 17;
            BtnInserisci.Text = "Inserisci";
            BtnInserisci.UseVisualStyleBackColor = true;
            BtnInserisci.Click += BtnInserisci_Click;
            // 
            // cmsMenu
            // 
            cmsMenu.Items.AddRange(new ToolStripItem[] { MniModifica, eliminaToolStripMenuItem });
            cmsMenu.Name = "cmsMenu";
            cmsMenu.Size = new Size(181, 70);
            // 
            // MniModifica
            // 
            MniModifica.Name = "MniModifica";
            MniModifica.Size = new Size(180, 22);
            MniModifica.Text = "Modifica..";
            MniModifica.Click += MniModifica_Click;
            // 
            // eliminaToolStripMenuItem
            // 
            eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            eliminaToolStripMenuItem.Size = new Size(180, 22);
            eliminaToolStripMenuItem.Text = "Elimina";
            eliminaToolStripMenuItem.Click += eliminaToolStripMenuItem_Click;
            // 
            // frmDDT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 775);
            Controls.Add(BtnInserisci);
            Controls.Add(dtgDatiDTT);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDDT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione Documento Di Trasprto";
            Load += frmDDT_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatiDTT).EndInit();
            cmsMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private DataGridView dtgDatiDTT;
        private Button BtnInserisci;
        private ContextMenuStrip cmsMenu;
        private ToolStripMenuItem MniModifica;
        private ToolStripMenuItem eliminaToolStripMenuItem;
    }
}