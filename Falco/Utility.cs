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



        







        #endregion












    }
}
