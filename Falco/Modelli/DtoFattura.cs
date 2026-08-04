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

        public string NominativoFornitore { get; set; }
        public string IndirizzoFornitore { get; set; }

        public string PartitaIvaFornitore { get; set; }

        public string NumeroFattura { get; set; }

        public DateTime DataFattura { get; set; }




        public string NominativoCliente { get; set; }


    }
}
