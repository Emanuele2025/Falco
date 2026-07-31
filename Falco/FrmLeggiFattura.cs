using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmLeggiFattura : Form
    {
        public FrmLeggiFattura()
        {
            InitializeComponent();
        }

        private void FrmLeggiFattura_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloForm;
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Si è verificato il seguente errore: " + ex.Message);
            }
        }
    }
}
