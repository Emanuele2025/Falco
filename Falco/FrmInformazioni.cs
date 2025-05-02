using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falco
{
    public partial class FrmInformazioni : Form
    {
        public FrmInformazioni()
        {
            InitializeComponent();
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://icons8.it/",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void LnkIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://icons8.it/",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
