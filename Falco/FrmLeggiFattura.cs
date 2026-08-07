using Falco.Modelli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        #region Funzioni 

        private void LeggiFattura()
        {

            try
            {
                XDocument doc = XDocument.Load(TxtPercorsoCartella.Text);
                XNamespace ns = "http://www.fatturapa.gov.it/sdi";

                DtoFattura fattura = new DtoFattura();
                // Header (dati mittente/destinatario)
                var header = doc.Descendants( "FatturaElettronicaHeader").FirstOrDefault();
                if (header != null)
                {
                    var mittente = header.Descendants(  "CedentePrestatore").FirstOrDefault();
                    if (mittente != null)
                    {
                        fattura.RagioneSocialeMittente = mittente
                            .Descendants( "Denominazione").FirstOrDefault()?.Value ?? "";
                        fattura.PartitaIvaMittente = mittente
                            .Descendants("IdFiscaleIVA")
                            .Descendants("IdCode").FirstOrDefault()?.Value ?? "";
                    }

                    var destinatario = header.Descendants( "CessionarioCommittente").FirstOrDefault();
                    if (destinatario != null)
                    {
                        fattura.RagioneSocialeDestinatario = destinatario
                            .Descendants( "Denominazione").FirstOrDefault()?.Value ?? "";
                    }
                }

                // Dati generali
                var datiGenerali = doc.Descendants( "DatiGenerali").FirstOrDefault();
                if (datiGenerali != null)
                {
                    var dg = datiGenerali.Descendants( "DatiGeneraliDocumento").FirstOrDefault();
                    if (dg != null)
                    {
                        fattura.NumeroFattura = dg.Descendants( "Numero").FirstOrDefault()?.Value ?? "";

                        string dataStr = dg.Descendants( "Data").FirstOrDefault()?.Value ?? "";
                        if (DateTime.TryParse(dataStr, out var data))
                            fattura.DataFattura = data;
                    }
                }

                // Linee di dettaglio
                var body = doc.Descendants( "FatturaElettronicaBody").FirstOrDefault();
                if (body != null)
                {
                    var linee = body.Descendants( "DettaglioLinee");
                    foreach (var linea in linee)
                    {
                        var dettaglio = new Dettagli
                        {
                            Descrizione = linea.Descendants( "Descrizione").FirstOrDefault()?.Value ?? "",
                            Quantita = decimal.Parse(linea.Descendants( "Quantita").FirstOrDefault()?.Value ?? "0"),
                            PrezzoUnitario = decimal.Parse(linea.Descendants( "PrezzoUnitario").FirstOrDefault()?.Value ?? "0"),
                            Importo = decimal.Parse(linea.Descendants( "ImportoLinea").FirstOrDefault()?.Value ?? "0"),
                            AliquotaIva = decimal.Parse(linea.Descendants( "AliquotaIVA").FirstOrDefault()?.Value ?? "0")
                        };
                        fattura.DettagliFattura.Add(dettaglio);
                    }

                    // Totale
                    var riepilogo = body.Descendants( "DatiRiepilogo").FirstOrDefault();
                    if (riepilogo != null)
                    {
                        fattura.ImportoTotale = decimal.Parse(
                            riepilogo.Descendants( "ImponibileImporto").FirstOrDefault()?.Value ?? "0");
                    }
                }

                txtNomeFornitore.Text = fattura.RagioneSocialeMittente;






            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }





        }




        #endregion




        private void BtnLeggiFattura_Click(object sender, EventArgs e)
        {
            if (TxtPercorsoCartella.Text.Trim() == "")
            {
                Utility.MessaggioInfo("Selezionare una fattura");
                return;
            }
            LeggiFattura();
        }
    }
}
