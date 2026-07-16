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
            BtnCrea = new Button();
            label2 = new Label();
            cmbClienti = new ComboBox();
            BtnNuovoCliente = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnCrea
            // 
            BtnCrea.Location = new Point(38, 306);
            BtnCrea.Margin = new Padding(3, 2, 3, 2);
            BtnCrea.Name = "BtnCrea";
            BtnCrea.Size = new Size(82, 22);
            BtnCrea.TabIndex = 3;
            BtnCrea.Text = "Crea";
            BtnCrea.UseVisualStyleBackColor = true;
            BtnCrea.Click += BtnCrea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 52);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Cliente:";
            // 
            // cmbClienti
            // 
            cmbClienti.FormattingEnabled = true;
            cmbClienti.Location = new Point(21, 71);
            cmbClienti.Margin = new Padding(3, 2, 3, 2);
            cmbClienti.Name = "cmbClienti";
            cmbClienti.Size = new Size(224, 23);
            cmbClienti.TabIndex = 5;
            // 
            // BtnNuovoCliente
            // 
            BtnNuovoCliente.Location = new Point(251, 70);
            BtnNuovoCliente.Margin = new Padding(3, 2, 3, 2);
            BtnNuovoCliente.Name = "BtnNuovoCliente";
            BtnNuovoCliente.Size = new Size(36, 22);
            BtnNuovoCliente.TabIndex = 6;
            BtnNuovoCliente.Text = "...";
            toolTip1.SetToolTip(BtnNuovoCliente, "Crea un nuovo cliente");
            BtnNuovoCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(700, 21);
            label1.TabIndex = 7;
            label1.Text = "Gestione delle fatture Elettroniche - Creazione delle fatture";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmCreaFattura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(BtnNuovoCliente);
            Controls.Add(cmbClienti);
            Controls.Add(label2);
            Controls.Add(BtnCrea);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCreaFattura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Fattura Elettronica";
            Load += FrmCreaFattura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnCrea;
        private Label label2;
        private ComboBox cmbClienti;
        private Button BtnNuovoCliente;
        private ToolTip toolTip1;
        private Label label1;
    }
}