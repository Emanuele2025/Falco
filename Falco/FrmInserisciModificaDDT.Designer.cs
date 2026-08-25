namespace Falco
{
    partial class FrmInserisciModificaDDT
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            TxtProgressivo = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            TxtCodiceFiscaleCedente = new TextBox();
            label7 = new Label();
            TxtPartitaIvaCedente = new TextBox();
            label6 = new Label();
            TxtIndirizzoCedente = new TextBox();
            label5 = new Label();
            TxtRagioneSociale = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            TxtCodiceFiscaleCessonario = new TextBox();
            label8 = new Label();
            TxtPartitaIvaCessonario = new TextBox();
            label9 = new Label();
            TxtIndirizzoCessonario = new TextBox();
            label10 = new Label();
            TxtRagioneSocialeCessonario = new TextBox();
            label11 = new Label();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            label16 = new Label();
            textBox6 = new TextBox();
            label17 = new Label();
            textBox7 = new TextBox();
            label18 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            textBox3 = new TextBox();
            label14 = new Label();
            TxtVettore = new TextBox();
            label15 = new Label();
            BtnChiudi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 35);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(333, 53);
            dateTimePicker1.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "Progressivo:";
            // 
            // TxtProgressivo
            // 
            TxtProgressivo.Location = new Point(12, 53);
            TxtProgressivo.Name = "TxtProgressivo";
            TxtProgressivo.Size = new Size(304, 23);
            TxtProgressivo.TabIndex = 3;
            TxtProgressivo.Enter += txt_Enter;
            TxtProgressivo.Leave += txt_Leave;
            // 
            // label3
            // 
            label3.BackColor = Color.DeepSkyBlue;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1296, 21);
            label3.TabIndex = 9;
            label3.Text = "Gestione delle fatture Elettroniche - Inserimento o modifica DDT";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtCodiceFiscaleCedente);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtPartitaIvaCedente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtIndirizzoCedente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtRagioneSociale);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 254);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cedente";
            // 
            // TxtCodiceFiscaleCedente
            // 
            TxtCodiceFiscaleCedente.Location = new Point(6, 209);
            TxtCodiceFiscaleCedente.Name = "TxtCodiceFiscaleCedente";
            TxtCodiceFiscaleCedente.Size = new Size(409, 23);
            TxtCodiceFiscaleCedente.TabIndex = 11;
            TxtCodiceFiscaleCedente.Enter += txt_Enter;
            TxtCodiceFiscaleCedente.Leave += txt_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 191);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 10;
            label7.Text = "Codice Fiscale:";
            // 
            // TxtPartitaIvaCedente
            // 
            TxtPartitaIvaCedente.Location = new Point(6, 154);
            TxtPartitaIvaCedente.Name = "TxtPartitaIvaCedente";
            TxtPartitaIvaCedente.Size = new Size(409, 23);
            TxtPartitaIvaCedente.TabIndex = 9;
            TxtPartitaIvaCedente.Enter += txt_Enter;
            TxtPartitaIvaCedente.Leave += txt_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 136);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 8;
            label6.Text = "Partita IVA:";
            // 
            // TxtIndirizzoCedente
            // 
            TxtIndirizzoCedente.Location = new Point(6, 102);
            TxtIndirizzoCedente.Name = "TxtIndirizzoCedente";
            TxtIndirizzoCedente.Size = new Size(409, 23);
            TxtIndirizzoCedente.TabIndex = 7;
            TxtIndirizzoCedente.Enter += txt_Enter;
            TxtIndirizzoCedente.Leave += txt_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 84);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 6;
            label5.Text = "Indirizzo:";
            // 
            // TxtRagioneSociale
            // 
            TxtRagioneSociale.Location = new Point(6, 47);
            TxtRagioneSociale.Name = "TxtRagioneSociale";
            TxtRagioneSociale.Size = new Size(409, 23);
            TxtRagioneSociale.TabIndex = 5;
            TxtRagioneSociale.Enter += txt_Enter;
            TxtRagioneSociale.Leave += txt_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 4;
            label4.Text = "Ragione Sociale:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtCodiceFiscaleCessonario);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(TxtPartitaIvaCessonario);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TxtIndirizzoCessonario);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(TxtRagioneSocialeCessonario);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(501, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 254);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cessonario";
            // 
            // TxtCodiceFiscaleCessonario
            // 
            TxtCodiceFiscaleCessonario.Location = new Point(6, 209);
            TxtCodiceFiscaleCessonario.Name = "TxtCodiceFiscaleCessonario";
            TxtCodiceFiscaleCessonario.Size = new Size(409, 23);
            TxtCodiceFiscaleCessonario.TabIndex = 11;
            TxtCodiceFiscaleCessonario.Enter += txt_Enter;
            TxtCodiceFiscaleCessonario.Leave += txt_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 191);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 10;
            label8.Text = "Codice Fiscale:";
            // 
            // TxtPartitaIvaCessonario
            // 
            TxtPartitaIvaCessonario.Location = new Point(6, 154);
            TxtPartitaIvaCessonario.Name = "TxtPartitaIvaCessonario";
            TxtPartitaIvaCessonario.Size = new Size(409, 23);
            TxtPartitaIvaCessonario.TabIndex = 9;
            TxtPartitaIvaCessonario.Enter += txt_Enter;
            TxtPartitaIvaCessonario.Leave += txt_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 136);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 8;
            label9.Text = "Partita IVA:";
            // 
            // TxtIndirizzoCessonario
            // 
            TxtIndirizzoCessonario.Location = new Point(6, 102);
            TxtIndirizzoCessonario.Name = "TxtIndirizzoCessonario";
            TxtIndirizzoCessonario.Size = new Size(409, 23);
            TxtIndirizzoCessonario.TabIndex = 7;
            TxtIndirizzoCessonario.Enter += txt_Enter;
            TxtIndirizzoCessonario.Leave += txt_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 84);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 6;
            label10.Text = "Indirizzo:";
            // 
            // TxtRagioneSocialeCessonario
            // 
            TxtRagioneSocialeCessonario.Location = new Point(6, 47);
            TxtRagioneSocialeCessonario.Name = "TxtRagioneSocialeCessonario";
            TxtRagioneSocialeCessonario.Size = new Size(409, 23);
            TxtRagioneSocialeCessonario.TabIndex = 5;
            TxtRagioneSocialeCessonario.Enter += txt_Enter;
            TxtRagioneSocialeCessonario.Leave += txt_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 29);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 4;
            label11.Text = "Ragione Sociale:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(TxtVettore);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(18, 357);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(930, 254);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trasporto";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(491, 154);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(409, 23);
            textBox5.TabIndex = 17;
            textBox5.Enter += txt_Enter;
            textBox5.Leave += txt_Leave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(491, 136);
            label16.Name = "label16";
            label16.Size = new Size(90, 15);
            label16.TabIndex = 16;
            label16.Text = "Luogo di arrivo:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(491, 102);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(409, 23);
            textBox6.TabIndex = 15;
            textBox6.Enter += txt_Enter;
            textBox6.Leave += txt_Leave;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(491, 84);
            label17.Name = "label17";
            label17.Size = new Size(81, 15);
            label17.TabIndex = 14;
            label17.Text = "Numero Colli:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(491, 47);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(409, 23);
            textBox7.TabIndex = 13;
            textBox7.Enter += txt_Enter;
            textBox7.Leave += txt_Leave;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(491, 29);
            label18.Name = "label18";
            label18.Size = new Size(35, 15);
            label18.TabIndex = 12;
            label18.Text = "Peso:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 23);
            textBox1.TabIndex = 11;
            textBox1.Enter += txt_Enter;
            textBox1.Leave += txt_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 191);
            label12.Name = "label12";
            label12.Size = new Size(118, 15);
            label12.TabIndex = 10;
            label12.Text = "Motivo del trasporto:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 23);
            textBox2.TabIndex = 9;
            textBox2.Enter += txt_Enter;
            textBox2.Leave += txt_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 136);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 8;
            label13.Text = "Luogo di arrivo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(409, 23);
            textBox3.TabIndex = 7;
            textBox3.Enter += txt_Enter;
            textBox3.Leave += txt_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 84);
            label14.Name = "label14";
            label14.Size = new Size(92, 15);
            label14.TabIndex = 6;
            label14.Text = "Luogo Partenza:";
            // 
            // TxtVettore
            // 
            TxtVettore.Location = new Point(6, 47);
            TxtVettore.Name = "TxtVettore";
            TxtVettore.Size = new Size(409, 23);
            TxtVettore.TabIndex = 5;
            TxtVettore.Enter += txt_Enter;
            TxtVettore.Leave += txt_Leave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 29);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 4;
            label15.Text = "Vettore:";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1180, 723);
            BtnChiudi.Margin = new Padding(3, 2, 3, 2);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(82, 22);
            BtnChiudi.TabIndex = 16;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // FrmInserisciModificaDDT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 756);
            Controls.Add(BtnChiudi);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(TxtProgressivo);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInserisciModificaDDT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione DDT - Inserimento e Modifica";
            Load += FrmInserisciModificaDDT_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox TxtProgressivo;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox TxtIndirizzoCedente;
        private Label label5;
        private TextBox TxtRagioneSociale;
        private Label label4;
        private TextBox TxtCodiceFiscaleCedente;
        private Label label7;
        private TextBox TxtPartitaIvaCedente;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox TxtCodiceFiscaleCessonario;
        private Label label8;
        private TextBox TxtPartitaIvaCessonario;
        private Label label9;
        private TextBox TxtIndirizzoCessonario;
        private Label label10;
        private TextBox TxtRagioneSocialeCessonario;
        private Label label11;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label label12;
        private TextBox textBox2;
        private Label label13;
        private TextBox textBox3;
        private Label label14;
        private TextBox TxtVettore;
        private Label label15;
        private TextBox textBox5;
        private Label label16;
        private TextBox textBox6;
        private Label label17;
        private TextBox textBox7;
        private Label label18;
        private Button BtnChiudi;
    }
}