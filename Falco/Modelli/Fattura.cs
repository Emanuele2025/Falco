using System;
using System.Collections.Generic;
using System.Text;

namespace Falco.Modelli
{
    public class Fattura
    {
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public Cliente Mittente { get; set; }
        public Cliente Destinatario { get; set; }
        public List<DtoArticolo> Articoli { get; set; } = new();
        public string Causale { get; set; }
        public string TipoDocumento { get; set; } = "TD01"; // Fattura
        public string CIG { get; set; }
        public string CUP { get; set; }

        public decimal TotaleImponibile
        {
            get => Articoli.Sum(a => a.Quantita * a.PrezzoUnitario);
        }

        public decimal TotaleIva
        {
            get => Articoli.Sum(a =>
                (a.Quantita * a.PrezzoUnitario * a.AliquotaIva / 100));
        }

        public decimal TotaleDocumento
        {
            get => TotaleImponibile + TotaleIva;
        }
    }
}
