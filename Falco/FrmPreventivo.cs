using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmPreventivo : Form
    {
        public FrmPreventivo()
        {
            InitializeComponent();
        }

        private void FrmPreventivo_Load(object sender, EventArgs e)
        {
            this.Text = Utility.TitoloForm;
            //TODO: Due form, inserimento e visualizzazione.
            //Inserimento, cancellazione e visualizzazione.
            //Visualizzazione, griglia, menu e pulsante inserisci. 
            try
            {
                CaricaDati();
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }



        }



        private void CaricaDati()
        {
            try
            {




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        
        
        
        
        
        
        }





    }
}
