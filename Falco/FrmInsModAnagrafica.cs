using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmInsModAnagrafica : Form
    {
        public FrmInsModAnagrafica()
        {
            InitializeComponent();
        }

        private void FrmInsModAnagrafica_Load(object sender, EventArgs e)
        {
            try
            {
                //TODO: gestione del colore status delle casse
                //OGgetto contesto inserire 
                //Varie funzionalit





            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }
    }
}
