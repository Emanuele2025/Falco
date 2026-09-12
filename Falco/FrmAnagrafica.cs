using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmAnagrafica : Form
    {
        public FrmAnagrafica()
        {
            InitializeComponent();
        }

        private void FrmAnagrafica_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.Text = Utility.TitoloForm;
                CaricaDati();


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

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MniElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatiAnagrafica.SelectedRows.Count == 0)
                {
                    Utility.MessaggioInfo("Selezionare una riga.");
                    return;
                }
                if (!Utility.CancellaRecord())
                {
                    return;
                }




               



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }



        private void CaricaDati()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        
        
        
        
        
        }






    }
}
