using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmLeggiFattura : Form
    {
        public FrmLeggiFattura()
        {
            InitializeComponent();
        }

        private void FrmLeggiFattura_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloForm;
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }

        private void BtnCercaCartella_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (OpenFileDialog openDlg = new OpenFileDialog())
                {

                    // openDlg.FileName = TxtPercorsoNomeFile.Text;
                    openDlg.Multiselect = false;

                    openDlg.Filter = "XML Files (*.xml) | *.xml";

                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        TxtPercorsoCartella.Text = openDlg.FileName;
                    }

                }
               


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
