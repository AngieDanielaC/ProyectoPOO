using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoPOO
{
    public partial class ucMotivacion : UserControl
    {
        public ucMotivacion()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void bttDestacado_Click(object sender, EventArgs e)
        {
            ucMotivacionDestacado nuevoControl = new ucMotivacionDestacado();
            nuevoControl.Dock = DockStyle.Fill;

            Control contenedor = this.Parent;

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                contenedor.Controls.Add(nuevoControl);
            }
        }

        private void bttAsistencia_Click(object sender, EventArgs e)
        {
            ucMotivacionAsistencia nuevoControl = new ucMotivacionAsistencia();
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
