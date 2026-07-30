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
    public partial class ucCompararCompetencias : UserControl
    {
        public ucCompararCompetencias()
        {
            InitializeComponent();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            ucSebCompetencia nuevoControl = new ucSebCompetencia();
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
