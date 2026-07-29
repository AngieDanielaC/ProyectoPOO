using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO
{
    public partial class ucBienestar : UserControl
    {
        public ucBienestar()
        {
            InitializeComponent();
        }
        private UserControl controlActivo = null;
        private void AbrirFrmBienestar(UserControl controlhijo)
        {
            if (controlActivo != null)
            {
                panelBienestar.Controls.Remove(controlActivo);
                controlActivo.Dispose();
            }
            controlActivo = controlhijo;
            controlhijo.Dock = DockStyle.Fill;
            panelBienestar.Controls.Add(controlhijo);
            panelBienestar.Tag = controlhijo;

            controlhijo.BringToFront();
            controlhijo.Show();
        }

        private void btnRFatiga_Click(object sender, EventArgs e)
        {
            AbrirFrmBienestar(new ucBRiesgoF());
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            AbrirFrmBienestar(new ucBGastoC());
        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            AbrirFrmBienestar(new ucBVRe());
        }
    }
}
