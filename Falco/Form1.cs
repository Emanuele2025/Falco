namespace Falco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9.1-%C2%A0-utilizzabili-dal-15-maggio-2026-
            //documentazione https://www.fatturapa.gov.it/it/news/Nuove-funzionalita-per-laccesso-al-sistema-di-accreditamento-e-la-gestione-del-canale-trasmissivo-SdiSFTP/


            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9


            //Altri siti
            //https://www.agenziaentrate.gov.it/portale/normativa-prassi-e-regole-tecniche-fatture-elettroniche
            //https://www.agenziaentrate.gov.it/portale/web/guest/fogli-di-stile-per-ricevute
            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9
            //https://www.fatturapa.gov.it/it/index.html

            //Altri
            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9
            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9
            //https://www.agenziaentrate.gov.it/portale/normativa-prassi-e-regole-tecniche-fatture-elettroniche
            //Scaricare il file di Stile
            //Leggere anche la firma
            //Icone
            //https://graphicsurf.com/all-graphics/
            //Non ancora utiizzato https://allsvgicons.com/pack/dashicons/ 
            //Contatto
            // supportofatturapa@agenziaentrate.it
            //Strumento online https://www.freeconvert.com/it


            try
            {

                decimal numero = 1875.23m;

                // string risultato = numero.ConvertiEuroInLettere(true);
                string risultato = numero.ConvertiEuroInLettere();
                // MessageBox.Show(risultato);






            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }

        }

        private void informazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformazioni frmInformazioni = new FrmInformazioni();
            frmInformazioni.ShowDialog();
        }

        private void mniAnagrafica_Click(object sender, EventArgs e)
        {
            //Apre la form dell'anagrafica
            Cursor.Current = Cursors.WaitCursor;

            Cursor.Current = Cursors.Default;

        }

        private void leggiFatturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                FrmLeggiFattura leggiFattura = new FrmLeggiFattura();
                leggiFattura.ShowDialog();


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;


            }







        }

        private void MniDocumentoDDT_Click(object sender, EventArgs e)
        {
            //Richiamare la form
            Cursor.Current = Cursors.WaitCursor;
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;


            }
        }

        private void impostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;


            }

        }

        private void MniCreaNuovoPreventivo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;


            }
        }

        private void MniPreventivoGestione_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;


            }
        }
    }
}
