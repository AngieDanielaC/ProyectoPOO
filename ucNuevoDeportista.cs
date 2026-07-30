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
    public partial class ucNuevoDeportista : UserControl
    {
        public ucNuevoDeportista()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            usDeportistas nuevoControl = new usDeportistas();
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
