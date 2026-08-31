using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmInserisciModificaDDT : Form
    {
        public FrmInserisciModificaDDT()
        {
            InitializeComponent();
        }
        public Int32? idDDT;


        private void FrmInserisciModificaDDT_Load(object sender, EventArgs e)
        {

            try
            {
                this.Text = Utility.TitoloForm;
                //TODO: Caricamento dati del CEdente e trasporto se
                if (idDDT != null )
                {
                    //modifica
                    BtnSalva.Visible = true;
                }




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }
    }
}
