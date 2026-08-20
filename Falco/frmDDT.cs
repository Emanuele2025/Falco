using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class frmDDT : Form
    {
        public frmDDT()
        {
            InitializeComponent();
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDDT_Load(object sender, EventArgs e)
        {
            this.Text = Utility.TitoloForm;
        }
    }
}
