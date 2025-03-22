using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Falco
{
    public partial class FrmCreaFattura : Form
    {
        public FrmCreaFattura()
        {
            InitializeComponent();
        }

        private void BtnCrea_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            // Creazione del nodo radice <FatturaElettronica>
            XmlElement root = doc.CreateElement("FatturaElettronica");
            doc.AppendChild(root);

            // Dati dell'emittente
            XmlElement cedente = doc.CreateElement("CedentePrestatore");
            root.AppendChild(cedente);
            XmlElement nomeCedente = doc.CreateElement("Nome");
            nomeCedente.InnerText = "Azienda Esempio S.r.l.";
            cedente.AppendChild(nomeCedente);

            // Dati del destinatario
            XmlElement cessionario = doc.CreateElement("CessionarioCommittente");
            root.AppendChild(cessionario);
            XmlElement nomeCessionario = doc.CreateElement("Nome");
            nomeCessionario.InnerText = "Cliente Esempio S.p.A.";
            cessionario.AppendChild(nomeCessionario);

            // Dettagli della fattura
            XmlElement dettagliFattura = doc.CreateElement("DettagliFattura");
            root.AppendChild(dettagliFattura);
            XmlElement numeroFattura = doc.CreateElement("NumeroFattura");
            numeroFattura.InnerText = "12345";
            dettagliFattura.AppendChild(numeroFattura);

            // Salvataggio del file XML
            doc.Save("fattura.xml");

            Console.WriteLine("Fattura Elettronica Creata con Successo!");
        }
    }
}
