using Falco.Modelli;
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
                if (idDDT != null)
                {
                    //modifica
                    BtnSalva.Visible = true;
                    BtnInserisci.Visible = false;
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

                DDTCorpo dttCorpo = new DDTCorpo
                {
                    CaualeTrasporto = CmbCausale.ValueMember,
                    CedenteCodiceFiscale = TxtCodiceFiscaleCedente.Text.Trim(),
                    CedentePartitaIVA = TxtPartitaIvaCedente.Text.Trim(),
                    CedenteRagioneSociale = TxtRagioneSocialeCessonario.Text.Trim(),
                    CessionarioCodiceFiscale = TxtCodiceFiscaleCessonario.Text.Trim(),
                    CessionarioIndirizzo = TxtIndirizzoCessonario.Text.Trim(),
                    CessionarioPartitaIVA = TxtPartitaIvaCessonario.Text.Trim(),
                    CessionarioRagioneSociale = TxtRagioneSocialeCessonario.Text.Trim(),
                    Data = DtpData.Value,
                    Destinazione = TxtLuogoArrivo.Text.Trim(),
                    LuoghiPartenza = TxtLuogoPartenza.Text.Trim(),

                    NumColli = (TxtNumeroColli.Text.Trim() != "") ? Convert.ToInt32(TxtNumeroColli.Text.Trim()) : 0,

                    NumeroProgressivo = TxtProgressivo.Text.Trim(),
                    VettoreNome = TxtVettore.Text.Trim(),
                    VettorePartitaIVA = TxtPartitaIvaVettore.Text.Trim(),
                    NumLetteraVettura = TxtNumeroVettura.Text.Trim(),
                    PesoTotale = (TxtPeso.Text.Trim() != "") ? Convert.ToInt32(TxtPeso.Text.Trim()) : 0,
                    



                };


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
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
