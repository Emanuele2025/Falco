using System;
using System.Collections.Generic;
using System.Text;

namespace Falco.Modelli
{
     
    public class DtoProdotti
    {
        public string Descrizione { get; set; }
        public decimal Quantita { get; set; }
        public decimal PrezzoUnitario { get; set; }
        public decimal AliquotaIva { get; set; }
        public string Natura { get; set; } // N1, N2, N3, N4, N5, N6
        public string Scorte { get; set; }
        public string Note { get; set; }
    }
}
