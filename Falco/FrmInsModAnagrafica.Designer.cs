namespace Falco
{
    partial class FrmInsModAnagrafica
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
            BtnChiudi = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
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
            label1.Size = new Size(1324, 21);
            label1.TabIndex = 9;
            label1.Text = "Gestione delle fatture Elettroniche - Anagrafica Clienti";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1220, 532);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 17;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 35);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 18;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(430, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 23);
            textBox2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 217);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 20;
            label3.Text = "label3";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(430, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 23);
            textBox3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 163);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 22;
            label4.Text = "label4";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 235);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 23);
            textBox4.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 217);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 24;
            label5.Text = "label5";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 181);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(267, 23);
            textBox5.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 163);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 26;
            label6.Text = "label6";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(23, 121);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(267, 23);
            textBox6.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 98);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 28;
            label7.Text = "label7";
            // 
            // FrmInsModAnagrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 565);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            Name = "FrmInsModAnagrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Inserimento modifica Anagrafica";
            Load += FrmInsModAnagrafica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
    }
}