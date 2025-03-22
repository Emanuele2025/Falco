namespace Falco
{
    partial class FrmCreaFattura
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
            BtnCrea = new Button();
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
            label1.Size = new Size(800, 28);
            label1.TabIndex = 2;
            label1.Text = "Crea Fattura";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnCrea
            // 
            BtnCrea.Location = new Point(43, 408);
            BtnCrea.Name = "BtnCrea";
            BtnCrea.Size = new Size(94, 29);
            BtnCrea.TabIndex = 3;
            BtnCrea.Text = "Crea";
            BtnCrea.UseVisualStyleBackColor = true;
            BtnCrea.Click += BtnCrea_Click;
            // 
            // FrmCreaFattura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCrea);
            Controls.Add(label1);
            Name = "FrmCreaFattura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Fattura Elettronica";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnCrea;
    }
}