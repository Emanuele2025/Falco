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


        Int32 idAgendaSelezionato = 0;


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
                if (dtgDatiDTT.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selezionare una riga");
                    return;
                }

                if (!Utility.CancellaRecord())
                {
                    return;
                }
                int idRecord = 0;
                idRecord = Convert.ToInt32(dtgDatiDTT.SelectedRows[0].Cells["IdDDT"].Value);

                

                //Cancello


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }

        private void MniModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatiDTT.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selezionare una riga");
                    return;
                }


                idAgendaSelezionato = Convert.ToInt32(dtgDatiDTT.SelectedRows[0].Cells["IdAgenda"].Value);
                //TODO: Apro la finestra



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }
    }
}
