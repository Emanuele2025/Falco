using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class frmDDT : Form
    {
        public frmDDT()
        {
            InitializeComponent();
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDDT_Load(object sender, EventArgs e)
        {
            this.Text = Utility.TitoloForm;
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            //Richiamare la form
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificare la selezione del record

                //Messaggio

                //Cancello


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }
    }
}
