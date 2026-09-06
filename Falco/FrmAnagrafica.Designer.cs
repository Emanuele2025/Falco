namespace Falco
{
    partial class FrmAnagrafica
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
            label1 = new Label();
            BtnChiudi = new Button();
            dtgDatiAnagrafica = new DataGridView();
            CmsMenu = new ContextMenuStrip(components);
            MniModifica = new ToolStripMenuItem();
            MniElimina = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgDatiAnagrafica).BeginInit();
            CmsMenu.SuspendLayout();
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
            label1.Size = new Size(1293, 21);
            label1.TabIndex = 8;
            label1.Text = "Gestione delle fatture Elettroniche - Creazione delle fatture";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1199, 645);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 16;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // dtgDatiAnagrafica
            // 
            dtgDatiAnagrafica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiAnagrafica.Dock = DockStyle.Top;
            dtgDatiAnagrafica.Location = new Point(0, 21);
            dtgDatiAnagrafica.Name = "dtgDatiAnagrafica";
            dtgDatiAnagrafica.Size = new Size(1293, 526);
            dtgDatiAnagrafica.TabIndex = 17;
            // 
            // CmsMenu
            // 
            CmsMenu.Items.AddRange(new ToolStripItem[] { MniModifica, MniElimina });
            CmsMenu.Name = "CmsMenu";
            CmsMenu.Size = new Size(181, 70);
            // 
            // MniModifica
            // 
            MniModifica.Name = "MniModifica";
            MniModifica.Size = new Size(180, 22);
            MniModifica.Text = "Modifica...";
            // 
            // MniElimina
            // 
            MniElimina.Name = "MniElimina";
            MniElimina.Size = new Size(180, 22);
            MniElimina.Text = "Elimina";
            // 
            // FrmAnagrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 678);
            Controls.Add(dtgDatiAnagrafica);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            Name = "FrmAnagrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione anagrafica Clienti";
            Load += FrmAnagrafica_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatiAnagrafica).EndInit();
            CmsMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private DataGridView dtgDatiAnagrafica;
        private ContextMenuStrip CmsMenu;
        private ToolStripMenuItem MniModifica;
        private ToolStripMenuItem MniElimina;
    }
}