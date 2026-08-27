using Falco.Modelli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
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
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.Text = Utility.TitoloForm;






            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

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
                        fattura.PartitaIvaMittente += " " + mittente
                            .Descendants("CodiceFiscale").FirstOrDefault()?.Value ?? "";

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
                            PrezzoUnitario = decimal.Parse(linea.Descendants( "PrezzoUnitario").FirstOrDefault()?.Value ?? "0") / 100,
                            Importo = decimal.Parse(linea.Descendants( "ImportoLinea").FirstOrDefault()?.Value ?? "0")/100,
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
                TxtPartitaIva.Text = fattura.PartitaIvaMittente;
                TxtIndirizzo.Text = fattura.IndirizzoFornitore;
                TxtNumeroFattura.Text = fattura.NumeroFattura;
                TxtNomeCliente.Text = fattura.RagioneSocialeDestinatario;
               // string TotaleFattura = "";
                var Dettagli = fattura.DettagliFattura.ToList();
                Dettagli.Add(new Dettagli { Descrizione="Totale Fattura", Importo =  fattura.ImportoTotale / 100  });
                //TxtIndirizzoCliente.Text = fattura
                dgvDatiFattura.DataSource = Dettagli;
                //if (xmlContent.Contains("FatturaElettronica"))
                //{
                //    var fattura = Deserialize<FatturaElettronica>(xmlContent);
                //    MostraFatturaOrdinaria(fattura);
                //}
                //else if (xmlContent.Contains("FatturaElettronicaSemplificata"))
                //{
                //    var fattura = Deserialize<FatturaElettronicaSemplificata>(xmlContent);
                //    MostraFa



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }





        }
//        private void MostraFatturaSemplificata(FatturaElettronicaSemplificata fattura)
//        {
//            var header = fattura.FatturaElettronicaHeader;
//            var body = fattura.FatturaElettronicaBody;

//            string mittente = header.CedentePrestatore.DatiAnagrafici.Anagrafica.Denominazione;
//            string cliente = header.CessionarioCommittente.DatiAnagrafici.Anagrafica.Denominazione;
//            var datiDoc = body.DatiGenerali.DatiGeneraliDocumento;

//            string valore = $@"FORMATO: FATTURA SEMPLIFICATA
//MITTENTE: {mittente}
//CLIENTE: {cliente}

//FATTURA N: {datiDoc.Numero} del {datiDoc.Data:dd/MM/yyyy}
//TOTALE: € {datiDoc.ImportoTotaleDocumento}";

//            var righe = body.DatiBeniServizi.DettaglioLinee.Select(r => new {
//                Riga = r.NumeroLinea,
//                Descrizione = r.Descrizione,
//                Quantita = r.Quantita,
//                Prezzo = r.PrezzoUnitario,
//                Totale = r.PrezzoTotale
//            }).ToList();
//            dgvDatiFattura.DataSource = righe;
//        }



        #endregion




        private void BtnLeggiFattura_Click(object sender, EventArgs e)
        {
            if (TxtPercorsoCartella.Text.Trim() == "")
            {
                Utility.MessaggioInfo("Selezionare una fattura");
                return;
            }
            LeggiFattura();
          var fattura =  LeggiFatturaXml(TxtPercorsoCartella.Text.Trim());
            //Gestire per i vari campi
            //TODO: vedere anche le altre classi di fattura
             //Trovare indirizzo + IVA + indirizzo cliente e mittente TxtIndirizzoCliente.Text = fattura.FatturaElettronicaHeader.CessionarioCommittente
            TxtIndirizzo.Text = fattura.FatturaElettronicaHeader.CessionarioCommittente.Sede.Indirizzo + " " + fattura.FatturaElettronicaHeader.CessionarioCommittente.Sede.CAP + " " + fattura.FatturaElettronicaHeader.CessionarioCommittente.Sede.Comune;
            TxtIndirizzoCliente.Text = fattura.FatturaElettronicaHeader.CedentePrestatore.Sede.Indirizzo + " " + fattura.FatturaElettronicaHeader.CedentePrestatore.Sede.CAP + " " + fattura.FatturaElettronicaHeader.CedentePrestatore.Sede.Comune;
        }

        public FatturaElettronicaType LeggiFatturaXml(string percorsoFile)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FatturaElettronicaType));

            using (StreamReader reader = new StreamReader(percorsoFile))
            {
                return (FatturaElettronicaType)serializer.Deserialize(reader);
            }
        }
        // Trasforma la tua classe C# in un file XML pronto per lo SDI
        public void CreaFatturaXml(FatturaElettronicaType fattura, string percorsoFile)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FatturaElettronicaType));

            // Impostiamo i namespace corretti richiesti dall'Agenzia delle Entrate
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("p", "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2");
            namespaces.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
            namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            // Impostazioni per avere un XML formattato e pulito
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = false,
                Encoding = System.Text.Encoding.UTF8
            };

            using (XmlWriter writer = XmlWriter.Create(percorsoFile, settings))
            {
                serializer.Serialize(writer, fattura, namespaces);
            }
        }
    }
}
