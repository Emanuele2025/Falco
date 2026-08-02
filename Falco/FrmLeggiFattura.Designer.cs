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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeggiFattura));
            label1 = new Label();
            BtnCercaCartella = new Button();
            lblEtichetta = new Label();
            TxtPercorsoCartella = new TextBox();
            BtnChiudi = new Button();
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
            label1.Size = new Size(800, 21);
            label1.TabIndex = 8;
            label1.Text = "Gestione delle fatture Elettroniche - Lettura della fattura, estrapolazione informazioni";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnCercaCartella
            // 
            BtnCercaCartella.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaCartella.Location = new Point(323, 57);
            BtnCercaCartella.Name = "BtnCercaCartella";
            BtnCercaCartella.Size = new Size(30, 29);
            BtnCercaCartella.TabIndex = 13;
            BtnCercaCartella.Text = "...";
            BtnCercaCartella.TextAlign = ContentAlignment.TopLeft;
            BtnCercaCartella.UseVisualStyleBackColor = true;
            BtnCercaCartella.Click += BtnCercaCartella_Click;
            // 
            // lblEtichetta
            // 
            lblEtichetta.AutoSize = true;
            lblEtichetta.Location = new Point(12, 39);
            lblEtichetta.Name = "lblEtichetta";
            lblEtichetta.Size = new Size(152, 15);
            lblEtichetta.TabIndex = 12;
            lblEtichetta.Text = "Percorso dove salvare il file:";
            // 
            // TxtPercorsoCartella
            // 
            TxtPercorsoCartella.Location = new Point(12, 57);
            TxtPercorsoCartella.Name = "TxtPercorsoCartella";
            TxtPercorsoCartella.ReadOnly = true;
            TxtPercorsoCartella.Size = new Size(305, 23);
            TxtPercorsoCartella.TabIndex = 11;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleRight;
            BtnChiudi.Location = new Point(693, 408);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 14;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // FrmLeggiFattura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnChiudi);
            Controls.Add(BtnCercaCartella);
            Controls.Add(lblEtichetta);
            Controls.Add(TxtPercorsoCartella);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLeggiFattura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Programma gratuito di Fattura Elettronica";
            Load += FrmLeggiFattura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnCercaCartella;
        private Label lblEtichetta;
        private TextBox TxtPercorsoCartella;
        private Button BtnChiudi;
    }
}