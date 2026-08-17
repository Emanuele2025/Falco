using Falco.Modelli;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Falco
{
    public class FatturaXmlGenerator
    {
        public static string GeneraFatturaXml(Fattura fattura, string nomeFile = null)
        {
            XmlDocument doc = new();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(declaration);

            // Root element
            XmlElement root = doc.CreateElement("p:FatturaElettronica");
            root.SetAttribute("xmlns:p", "http://www.fatturapa.gov.it/sdi/fatturapa/v1.2");
            root.SetAttribute("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            root.SetAttribute("versione", "FPR12");
            doc.AppendChild(root);

            // FatturaElettronicaHeader
            XmlElement header = doc.CreateElement("FatturaElettronicaHeader");
            root.AppendChild(header);

            // DatiTrasmissione
            XmlElement datiTrasmissione = doc.CreateElement("DatiTrasmissione");
            header.AppendChild(datiTrasmissione);

            AddElement(datiTrasmissione, "ProgressivoInvio", "1");
            AddElement(datiTrasmissione, "FormatoTrasmissione", "FPR12");

            // IdTrasmittente
            XmlElement idTrasmittente = doc.CreateElement("IdTrasmittente");
            datiTrasmissione.AppendChild(idTrasmittente);
            AddElement(idTrasmittente, "IdPaese", "IT");
            AddElement(idTrasmittente, "IdCodice", fattura.Mittente.PartitaIva);

            AddElement(datiTrasmissione, "ProgressivoInvio", "1");
            AddElement(datiTrasmissione, "FormatoTrasmissione", "FPR12");

            // PECDestinatario (obbligatorio anche se vuoto)
            AddElement(datiTrasmissione, "PECDestinatario", "commercialista@pec.it");

            // DatiRicezione
            XmlElement datiRicezione = doc.CreateElement("CodiceDestinatario");
            datiTrasmissione.AppendChild(datiRicezione);
            datiRicezione.InnerText = "0000000";

            // DatifatturaBody
            XmlElement body = doc.CreateElement("FatturaElettronicaBody");
            root.AppendChild(body);

            // DatiGenerali
            XmlElement datiGenerali = doc.CreateElement("DatiGenerali");
            body.AppendChild(datiGenerali);

            XmlElement datiGeneraliDocumento = doc.CreateElement("DatiGeneraliDocumento");
            datiGenerali.AppendChild(datiGeneraliDocumento);

            AddElement(datiGeneraliDocumento, "TipoDocumento", fattura.TipoDocumento);
            AddElement(datiGeneraliDocumento, "Divisa", "EUR");
            AddElement(datiGeneraliDocumento, "Data", fattura.Data.ToString("yyyy-MM-dd"));
            AddElement(datiGeneraliDocumento, "Numero", fattura.Numero);
            AddElement(datiGeneraliDocumento, "Causale", fattura.Causale ?? "Vendita");

            if (!string.IsNullOrEmpty(fattura.CIG))
                AddElement(datiGeneraliDocumento, "CIG", fattura.CIG);
            if (!string.IsNullOrEmpty(fattura.CUP))
                AddElement(datiGeneraliDocumento, "CUP", fattura.CUP);

            // DatiRiepilogo
            XmlElement datiRiepilogo = doc.CreateElement("DatiRiepilogo");
            datiGeneraliDocumento.AppendChild(datiRiepilogo);

            var gruppiIva = fattura.Articoli.GroupBy(a => a.AliquotaIva);

            foreach (var gruppo in gruppiIva)
            {
                XmlElement riepilogo = doc.CreateElement("DatiRiepilogo");
                datiGeneraliDocumento.AppendChild(riepilogo);

                decimal imponibile = gruppo.Sum(a => a.Quantita * a.PrezzoUnitario);
                decimal iva = imponibile * gruppo.Key / 100;

                AddElement(riepilogo, "AliquotaIVA", gruppo.Key.ToString("F2"));
                AddElement(riepilogo, "ImponibileImporto", imponibile.ToString("F2"));
                AddElement(riepilogo, "ImpostaImporto", iva.ToString("F2"));
                AddElement(riepilogo, "EsigibilitaIVA", "I");
            }

            AddElement(datiGeneraliDocumento, "ImportoTotaleDocumento",
                fattura.TotaleDocumento.ToString("F2"));

            // Dati Mittente
            XmlElement datiMittente = doc.CreateElement("DatiMittente");
            header.AppendChild(datiMittente);
            AggiungiDatiCliente(datiMittente, fattura.Mittente, doc);

            // Dati Destinatario
            XmlElement datiDestinatario = doc.CreateElement("DatiDestinatario");
            header.AppendChild(datiDestinatario);
            AggiungiDatiCliente(datiDestinatario, fattura.Destinatario, doc);

            // DatiLineeDocumento
            XmlElement datiLinee = doc.CreateElement("DatiLineeDocumento");
            body.AppendChild(datiLinee);

            int numeroLinea = 1;
            foreach (var articolo in fattura.Articoli)
            {
                XmlElement linea = doc.CreateElement("DettaglioLinee");
                datiLinee.AppendChild(linea);

                AddElement(linea, "NumeroLinea", numeroLinea.ToString());
                AddElement(linea, "Descrizione", articolo.Descrizione);
                AddElement(linea, "Quantita", articolo.Quantita.ToString("F2"));
                AddElement(linea, "UnitaMisura", "pz");
                AddElement(linea, "PrezzoUnitario", articolo.PrezzoUnitario.ToString("F2"));

               // decimal scontoLinea = 0;
                AddElement(linea, "PrezzoTotale",
                    (articolo.Quantita * articolo.PrezzoUnitario).ToString("F2"));

                XmlElement aliquota = doc.CreateElement("AliquotaIVA");
                linea.AppendChild(aliquota);
                aliquota.InnerText = articolo.AliquotaIva.ToString("F2");

                if (!string.IsNullOrEmpty(articolo.Natura))
                {
                    AddElement(linea, "Natura", articolo.Natura);
                }

                numeroLinea++;
            }

            // Salva il file
            if (!string.IsNullOrEmpty(nomeFile))
            {
                XmlWriterSettings settings = new()
                {
                    Indent = true,
                    IndentChars = "  ",
                    Encoding = System.Text.Encoding.UTF8,
                    ConformanceLevel = ConformanceLevel.Document
                };

                using (XmlWriter writer = XmlWriter.Create(nomeFile, settings))
                {
                    doc.WriteTo(writer);
                }
            }

            return doc.OuterXml;
        }

        private static void AggiungiDatiCliente(XmlElement parent, Cliente cliente, XmlDocument doc)
        {
            XmlElement datiAnagrafici = doc.CreateElement("DatiAnagrafici");
            parent.AppendChild(datiAnagrafici);

            if (!string.IsNullOrEmpty(cliente.PartitaIva))
            {
                XmlElement idFiscaleIVA = doc.CreateElement("IdFiscaleIVA");
                datiAnagrafici.AppendChild(idFiscaleIVA);
                AddElement(idFiscaleIVA, "IdPaese", "IT");
                AddElement(idFiscaleIVA, "IdCodice", cliente.PartitaIva);
            }
            else if (!string.IsNullOrEmpty(cliente.CodiceFiscale))
            {
                AddElement(datiAnagrafici, "CodiceFiscale", cliente.CodiceFiscale);
            }

            XmlElement anagrafica = doc.CreateElement("Anagrafica");
            datiAnagrafici.AppendChild(anagrafica);
            AddElement(anagrafica, "Denominazione",
                $"{cliente.Nome} {cliente.Cognome}".Trim());

            XmlElement indirizzo = doc.CreateElement("Indirizzo");
            parent.AppendChild(indirizzo);
            AddElement(indirizzo, "Indirizzo", cliente.Indirizzo);
            AddElement(indirizzo, "NumeroCivico", cliente.Civico ?? "1");
            AddElement(indirizzo, "CAP", cliente.Cap);
            AddElement(indirizzo, "Comune", cliente.Comune);
            AddElement(indirizzo, "Provincia", cliente.Provincia ?? "XX");
            AddElement(indirizzo, "Nazione", cliente.Nazione ?? "IT");
        }

        private static void AddElement(XmlElement parent, string name, string value)
        {
            XmlElement element = parent.OwnerDocument.CreateElement(name);
            element.InnerText = value ?? string.Empty;
            parent.AppendChild(element);
        }
    }
}
