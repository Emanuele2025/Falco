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

        private void FrmInserisciModificaDDT_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.Text = Utility.TitoloForm;
                //TODO: Caricamento dati del CEdente e trasporto se

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }
    }
}
