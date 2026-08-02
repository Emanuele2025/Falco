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
                //TODO testare
                using (OpenFileDialog openDlg = new OpenFileDialog())
                {

                    // openDlg.FileName = TxtPercorsoNomeFile.Text;
                    openDlg.Multiselect = false;

                    openDlg.Filter = "XML Files (*.xml)";

                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {

                        TxtPercorsoCartella.Text = openDlg.FileName;

                    }

                }
                //Apro la finestra di dialogo per la selezione della cartella
                //using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                //{
                //    folderBrowserDialog.Description = "Seleziona la cartella di destinazione per salvare l'immagine di bing";
                //    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        // Imposto il percorso selezionato nella casella di testo
                //        TxtPercorsoCartella.Text = folderBrowserDialog.SelectedPath;
                //    }
                //}


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
