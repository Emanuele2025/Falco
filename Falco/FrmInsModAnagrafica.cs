using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmInsModAnagrafica : Form
    {

        public int? IdCliente;


        public FrmInsModAnagrafica()
        {
            InitializeComponent();
        }

        private void FrmInsModAnagrafica_Load(object sender, EventArgs e)
        {
            try
            {
                //TODO: gestione del colore status delle casse
                //OGgetto contesto inserire 
                //Varie funzionalit
                CaricaDati();




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }


        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        #region Funzionalità

        private void CaricaDati()
        {

            try
            {
                if (IdCliente.HasValue)
                {

                    //TODO: carico i dati del cliente

                }

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }





        }


        #endregion




        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtRagioneSociale.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Il campo denominazione sociale è obbligatorio. ");
                    return;
                }











            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void BtnSalva_Click(object sender, EventArgs e)
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
