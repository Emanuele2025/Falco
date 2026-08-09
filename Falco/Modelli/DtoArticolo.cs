using System;
using System.Collections.Generic;
using System.Text;

namespace Falco.Modelli
{
    public class DtoArticolo
    {
        public string Descrizione { get; set; }
        public decimal Quantita { get; set; }
        public decimal PrezzoUnitario { get; set; }
        public decimal AliquotaIva { get; set; }
        public string Natura { get; set; } // N1, N2, N3, N4, N5, N6
    }
}
