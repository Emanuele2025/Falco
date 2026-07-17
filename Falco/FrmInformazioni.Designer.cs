namespace Falco
{
    partial class FrmInformazioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformazioni));
            BtnChiudi = new Button();
            label3 = new Label();
            LnkIcon = new LinkLabel();
            label2 = new Label();
            lnkduckduckgo = new LinkLabel();
            pcbLogo = new PictureBox();
            LblDescrizione = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Location = new Point(675, 436);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 3;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(302, 265);
            label3.Name = "label3";
            label3.Size = new Size(358, 15);
            label3.TabIndex = 5;
            label3.Text = "Un grazie ai siti qui di seguito per le icone ed immagini gratuite.";
            // 
            // LnkIcon
            // 
            LnkIcon.AutoSize = true;
            LnkIcon.Location = new Point(302, 321);
            LnkIcon.Name = "LnkIcon";
            LnkIcon.Size = new Size(143, 15);
            LnkIcon.TabIndex = 6;
            LnkIcon.TabStop = true;
            LnkIcon.Text = "icons by https://icons8.it/";
            LnkIcon.LinkClicked += LnkIcon_LinkClicked;
            // 
            // label2
            // 
            label2.BackColor = Color.DeepSkyBlue;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(787, 21);
            label2.TabIndex = 7;
            label2.Text = "Informazioni Falco - Programma per la gestione della fatturazione elettronica";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lnkduckduckgo
            // 
            lnkduckduckgo.AutoSize = true;
            lnkduckduckgo.Location = new Point(302, 292);
            lnkduckduckgo.Name = "lnkduckduckgo";
            lnkduckduckgo.Size = new Size(455, 15);
            lnkduckduckgo.TabIndex = 27;
            lnkduckduckgo.TabStop = true;
            lnkduckduckgo.Text = "L'immagine del falco creata tramite Duckduckgo AI Image Generator https://duck.ai/";
            lnkduckduckgo.LinkClicked += lnkduckduckgo_LinkClicked;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.Falco;
            pcbLogo.Location = new Point(0, 21);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(296, 239);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 28;
            pcbLogo.TabStop = false;
            // 
            // LblDescrizione
            // 
            LblDescrizione.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescrizione.Location = new Point(302, 40);
            LblDescrizione.Name = "LblDescrizione";
            LblDescrizione.Size = new Size(473, 65);
            LblDescrizione.TabIndex = 29;
            LblDescrizione.Text = "Programma gratuito per la gestione delle fatture elettroniche";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 21);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 30;
            label1.Text = "Descrizione:";
            // 
            // FrmInformazioni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 469);
            Controls.Add(label1);
            Controls.Add(LblDescrizione);
            Controls.Add(pcbLogo);
            Controls.Add(lnkduckduckgo);
            Controls.Add(label2);
            Controls.Add(LnkIcon);
            Controls.Add(label3);
            Controls.Add(BtnChiudi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInformazioni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informazioni";
            Load += FrmInformazioni_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnChiudi;
        private Label label3;
        private LinkLabel LnkIcon;
        private Label label2;
        private LinkLabel lnkduckduckgo;
        private PictureBox pcbLogo;
        private Label LblDescrizione;
        private Label label1;
    }
}