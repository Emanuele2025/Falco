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
            LnkIcon = new LinkLabel();
            label2 = new Label();
            lnkduckduckgo = new LinkLabel();
            pcbLogo = new PictureBox();
            LblDescrizione = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lnlEmail = new LinkLabel();
            label8 = new Label();
            label3 = new Label();
            lkluxwing = new LinkLabel();
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
            // LnkIcon
            // 
            LnkIcon.AutoSize = true;
            LnkIcon.Location = new Point(303, 347);
            LnkIcon.Name = "LnkIcon";
            LnkIcon.Size = new Size(471, 15);
            LnkIcon.TabIndex = 6;
            LnkIcon.TabStop = true;
            LnkIcon.Text = "Alcune icone utilizzate in questo programma sono fornite da   icons by https://icons8.it/";
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
            lnkduckduckgo.Location = new Point(302, 323);
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
            LblDescrizione.Size = new Size(473, 48);
            LblDescrizione.TabIndex = 29;
            LblDescrizione.Text = "Programma gratuito per la gestione delle fatture elettroniche - free program for managing electronic invoices";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 88);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 31;
            label4.Text = "Ideatore:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 105);
            label5.Name = "label5";
            label5.Size = new Size(485, 44);
            label5.TabIndex = 32;
            label5.Text = "Realizzato da Emanuele Mattei con amore - Made with love by Emanuele Mattei";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(303, 149);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 33;
            label6.Text = "Contatti:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(302, 166);
            label7.Name = "label7";
            label7.Size = new Size(485, 63);
            label7.TabIndex = 34;
            label7.Text = "Per informazioni o altro contattare Emanuele al numeo di telefono 339.1980065 oppure  tramite email - For info or anything else, get in touch with Emanuele at 339.1980065 or by email:\r\n";
            // 
            // lnlEmail
            // 
            lnlEmail.AutoSize = true;
            lnlEmail.Location = new Point(611, 238);
            lnlEmail.Name = "lnlEmail";
            lnlEmail.Size = new Size(176, 15);
            lnlEmail.TabIndex = 35;
            lnlEmail.TabStop = true;
            lnlEmail.Text = "emanuelemattei@tutanota.com";
            lnlEmail.LinkClicked += lnlEmail_LinkClicked;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(303, 264);
            label8.Name = "label8";
            label8.Size = new Size(484, 37);
            label8.TabIndex = 36;
            label8.Text = "Le icone e le immagini utilizzate in questo programma provengono dai siti elencati di seguito, che le mettono gratuitamente a disposizione dei propri utenti.";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(307, 301);
            label3.Name = "label3";
            label3.Size = new Size(58, 22);
            label3.TabIndex = 37;
            label3.Text = "Crediti";
            // 
            // lkluxwing
            // 
            lkluxwing.AutoSize = true;
            lkluxwing.Location = new Point(302, 372);
            lkluxwing.Name = "lkluxwing";
            lkluxwing.Size = new Size(483, 15);
            lkluxwing.TabIndex = 38;
            lkluxwing.TabStop = true;
            lkluxwing.Text = "Alcune icone utilizzate in questo programma sono fornite da  uxwing https://uxwing.com/";
            lkluxwing.LinkClicked += lkluxwing_LinkClicked;
            // 
            // FrmInformazioni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 469);
            Controls.Add(lkluxwing);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(lnlEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(LblDescrizione);
            Controls.Add(pcbLogo);
            Controls.Add(lnkduckduckgo);
            Controls.Add(label2);
            Controls.Add(LnkIcon);
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
        private LinkLabel LnkIcon;
        private Label label2;
        private LinkLabel lnkduckduckgo;
        private PictureBox pcbLogo;
        private Label LblDescrizione;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel lnlEmail;
        private Label label8;
        private Label label3;
        private LinkLabel lkluxwing;
    }
}