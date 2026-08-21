using System;
using System.Collections.Generic;
using System.Text;

namespace Falco.Modelli
{
    public class DDTCorpo
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string NumeroProgressivo { get; set; } = string.Empty;

        public string CedenteRagioneSociale { get; set; } = string.Empty;
        public string CedentePartitaIVA { get; set; } = string.Empty;
        public string CedenteCodiceFiscale { get; set; } = string.Empty;

        public string CessionarioRagioneSociale { get; set; } = string.Empty;
        public string CessionarioIndirizzo { get; set; } = string.Empty;
        public string CessionarioPartitaIVA { get; set; } = string.Empty;
        public string CessionarioCodiceFiscale { get; set; } = string.Empty;

        public string LuoghiPartenza { get; set; } = string.Empty;
        public string Destinazione { get; set; } = string.Empty;
        public string CaualeTrasporto { get; set; } = string.Empty;

        public List<DatoMerci> Merci { get; set; } = new();
        public decimal PesoTotale { get; set; }
        public int NumColli { get; set; }

        public string VettoreNome { get; set; } = string.Empty;
        public string VettorePartitaIVA { get; set; } = string.Empty;
        public string NumLetteraVettura { get; set; } = string.Empty;
    }

    public class DatoMerci
    {
        public string CodiceArticolo { get; set; } = string.Empty;
        public string Descrizione { get; set; } = string.Empty;
        public decimal Quantita { get; set; }
        public string UnitàMisura { get; set; } = string.Empty;
        public decimal PrezzoUnitario { get; set; }
    }




}
