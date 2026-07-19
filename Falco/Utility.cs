using System;
using System.Collections.Generic;
using System.Text;

namespace Falco
{
    public static class Utility
    {
        #region Campi e proprietà
        const string titolo = "Falco";

        private static readonly string[] Unita = { "zero", "uno", "due", "tre", "quattro", "cinque", "sei", "sette", "otto", "nove" };

        private static readonly string[] Decine = { "", "dieci", "venti", "trenta", "quaranta", "cinquanta", "sessanta", "settanta", "ottanta", "novanta" };

        private static readonly string[] DecineSpeciali = { "dieci", "undici", "dodici", "tredici", "quattordici", "quindici", "sedici", "diciassette", "diciotto", "diciannove" };








        #endregion


        #region Messaggi a video


        /// <summary>
        /// Messaggio informativo
        /// </summary>
        /// <param name="testo">testo da visualizzare</param>
        public static void MessaggioInfo(string testo)
        {
            MessageBox.Show(testo, titolo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// MEssaggio di errore
        /// </summary>
        /// <param name="testo"> testo da visualizzare</param>
        public static void MessaggioErrore(string testo)
        {
            MessageBox.Show(testo, titolo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Visualizza un messaggio per cancellare il record
        /// </summary>
        /// <returns>Restituisce SI se è stata scelta la volontà di cancellare record</returns>
        public static bool CancellaRecord()
        {
            return MessageBox.Show("Si è certi di voler eliminare il record selezionato?", titolo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }
        /// <summary>
        /// Messaggio di scelta si e no generico
        /// </summary>
        /// <param name="testo">testo da visualizzare</param>
        /// <returns></returns>
        public static bool MessaggioSiNo(string testo)
        {
            return MessageBox.Show(testo, titolo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }





        #endregion


        #region Funzioni

        //TODO: fare funzione da importo euro a testo
        //https://emanuelemattei.blogspot.com/search?q=estendere&updated-max=2026-02-11T06:00:00%2B01:00&max-results=20&start=3&by-date=true



        public static string ConvertiEuroInLettere(this decimal importo, bool centesimiTesto = false)
        {
            if (importo == 0)
                return "zero euro";

            long euro = (long)Math.Floor(importo);
            int centesimi = (int)((importo - euro) * 100);

            string euroTesto = ConvertiNumeroInLettere(euro);

            if (!centesimiTesto)
                return $"{euroTesto} euro /{centesimi:00}";

            string centesimiTestoStr = ConvertiNumeroInLettere(centesimi);
            return $"{euroTesto} euro e {centesimiTestoStr} centesimi";
        }

        private static string ConvertiNumeroInLettere(long numero)
        {
            return numero switch
            {
                < 10 => Unita[numero],
                < 20 => DecineSpeciali[numero - 10],
                < 100 => Decine[numero / 10] + (numero % 10 > 0 ? Unita[numero % 10] : ""),
                < 1000 => (numero / 100 == 1 ? "cento" : Unita[numero / 100] + "cento")
                          + (numero % 100 > 0 ? ConvertiNumeroInLettere(numero % 100) : ""),
                < 1_000_000 => (numero / 1000 == 1 ? "mille" : ConvertiNumeroInLettere(numero / 1000) + "mila")
                               + (numero % 1000 > 0 ? ConvertiNumeroInLettere(numero % 1000) : ""),
                < 1_000_000_000 => (numero / 1_000_000 == 1 ? "un milione" : ConvertiNumeroInLettere(numero / 1_000_000) + " milioni")
                                   + (numero % 1_000_000 > 0 ? ConvertiNumeroInLettere(numero % 1_000_000) : ""),
                _ => (numero / 1_000_000_000 == 1 ? "un miliardo" : ConvertiNumeroInLettere(numero / 1_000_000_000) + " miliardi")
                     + (numero % 1_000_000_000 > 0 ? ConvertiNumeroInLettere(numero % 1_000_000_000) : "")
            };
        }






        #endregion












    }
}
