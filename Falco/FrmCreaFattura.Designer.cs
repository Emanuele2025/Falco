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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            BtnCrea = new Button();
            label2 = new Label();
            cmbClienti = new ComboBox();
            BtnNuovoCliente = new Button();
            toolTip1 = new ToolTip(components);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Cliente:";
            // 
            // cmbClienti
            // 
            cmbClienti.FormattingEnabled = true;
            cmbClienti.Location = new Point(24, 95);
            cmbClienti.Name = "cmbClienti";
            cmbClienti.Size = new Size(256, 28);
            cmbClienti.TabIndex = 5;
            // 
            // BtnNuovoCliente
            // 
            BtnNuovoCliente.Location = new Point(287, 94);
            BtnNuovoCliente.Name = "BtnNuovoCliente";
            BtnNuovoCliente.Size = new Size(41, 29);
            BtnNuovoCliente.TabIndex = 6;
            BtnNuovoCliente.Text = "...";
            toolTip1.SetToolTip(BtnNuovoCliente, "Crea un nuovo cliente");
            BtnNuovoCliente.UseVisualStyleBackColor = true;
            // 
            // FrmCreaFattura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnNuovoCliente);
            Controls.Add(cmbClienti);
            Controls.Add(label2);
            Controls.Add(BtnCrea);
            Controls.Add(label1);
            Name = "FrmCreaFattura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Fattura Elettronica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnCrea;
        private Label label2;
        private ComboBox cmbClienti;
        private Button BtnNuovoCliente;
        private ToolTip toolTip1;
    }
}