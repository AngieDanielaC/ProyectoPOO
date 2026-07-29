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
    public partial class ucSebCompetencia : UserControl
    {
        public ucSebCompetencia()
        {
            InitializeComponent();
        }

        private void btnVerComptencias_Click(object sender, EventArgs e)
        {
            ucVerTodasLasCompetencias nuevoControl = new ucVerTodasLasCompetencias();
            nuevoControl.Dock = DockStyle.Fill;

            Control contenedor = this.Parent;

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                contenedor.Controls.Add(nuevoControl);
            }
        }

        private void btnRegistrarCompetencia_Click(object sender, EventArgs e)
        {
            ucRegistrarCompetencia nuevoControl = new ucRegistrarCompetencia();
            nuevoControl.Dock = DockStyle.Fill;

            Control contenedor = this.Parent;

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                contenedor.Controls.Add(nuevoControl);
            }
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            ucCompararCompetencias nuevoControl = new ucCompararCompetencias();
            nuevoControl.Dock = DockStyle.Fill;

            Control contenedor = this.Parent;

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                contenedor.Controls.Add(nuevoControl);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ucCompetencias nuevoControl = new ucCompetencias();
            nuevoControl.Dock = DockStyle.Fill;

            Control contenedor = this.Parent;

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                contenedor.Controls.Add(nuevoControl);
            }
        }
    }
}
