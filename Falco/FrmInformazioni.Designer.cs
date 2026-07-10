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
            label1 = new Label();
            BtnChiudi = new Button();
            label3 = new Label();
            LnkIcon = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(700, 21);
            label1.TabIndex = 2;
            label1.Text = "Informazioni Falco - Programma per la gestione della fatturazione elettronica";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Location = new Point(586, 307);
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
            label3.Location = new Point(0, 167);
            label3.Name = "label3";
            label3.Size = new Size(358, 15);
            label3.TabIndex = 5;
            label3.Text = "Un grazie ai siti qui di seguito per le icone ed immagini gratuite.";
            // 
            // LnkIcon
            // 
            LnkIcon.AutoSize = true;
            LnkIcon.Location = new Point(0, 209);
            LnkIcon.Name = "LnkIcon";
            LnkIcon.Size = new Size(143, 15);
            LnkIcon.TabIndex = 6;
            LnkIcon.TabStop = true;
            LnkIcon.Text = "icons by https://icons8.it/";
            LnkIcon.LinkClicked += LnkIcon_LinkClicked;
            // 
            // FrmInformazioni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(LnkIcon);
            Controls.Add(label3);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInformazioni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informazioni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private Label label3;
        private LinkLabel LnkIcon;
    }
}