using System;
using System.Collections.Generic;
using System.Text;

namespace Falco.Modelli
{
    /// <summary>
    /// Classe per gestire i dati della fattura
    /// </summary>
    public class DtoFattura
    {

        public string RagioneSocialeMittente { get; set; }
        public string IndirizzoFornitore { get; set; }

        public string PartitaIvaMittente { get; set; }

        public string NumeroFattura { get; set; }

        public DateTime DataFattura { get; set; }

        public string RagioneSocialeDestinatario { get; set; }

        public decimal ImportoTotale { get; set; }

        public string NominativoCliente { get; set; }

        public List<Dettagli> DettagliFattura { get; set; } = new List<Dettagli>();


    }

    public class Dettagli
    {
        public string Descrizione { get; set; }
        public decimal Quantita { get; set; }
        public decimal PrezzoUnitario { get; set; }

        public decimal AliquotaIva { get; set; }
        public decimal Importo { get; set; }
        
    }
}
