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
            //Altri siti
            //https://www.agenziaentrate.gov.it/portale/normativa-prassi-e-regole-tecniche-fatture-elettroniche
            //https://www.agenziaentrate.gov.it/portale/web/guest/fogli-di-stile-per-ricevute
            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9


            //Altri
            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9
            //https://www.agenziaentrate.gov.it/portale/specifiche-tecniche-versione-1.9
            //https://www.agenziaentrate.gov.it/portale/normativa-prassi-e-regole-tecniche-fatture-elettroniche
            //Scaricare il file di Stile
            //Leggere anche la firma
            //Icone
            //https://graphicsurf.com/all-graphics/


        }

        private void informazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformazioni frmInformazioni = new FrmInformazioni();
            frmInformazioni.ShowDialog();
        }
    }
}
