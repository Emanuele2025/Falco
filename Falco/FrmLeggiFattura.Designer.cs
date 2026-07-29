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
            label1 = new Label();
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
            // FrmLeggiFattura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "FrmLeggiFattura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Programma gratuito di Fattura Elettronica";
            Load += FrmLeggiFattura_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}