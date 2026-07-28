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
    public partial class wfrMenuPrincipal : Form
    {
        public wfrMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerarSesionMeno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private UserControl controlActivo = null;
        private void AbrirControlEnPanel(UserControl controlHijo)
        {
            if (controlActivo != null)
                pnlContenedor.Controls.Remove(controlActivo);

            controlActivo = controlHijo;
            controlHijo.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(controlHijo);
            pnlContenedor.Tag = controlHijo;

            controlHijo.BringToFront();
            controlHijo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ucInicio());
        }

        private void btnDeportistas_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new usDeportistas());
        }

        private void btnMonitoreo_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ucMonitoreo());
        }

        private void btnEntrenamientos_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ucEntrenamientos());
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ucCompetencias());
        }

        private void btnBienestar_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ucBienestar());
        }

        private void btnMotivacion_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ucMotivacion());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ucReportes());
        }

        private void btnCerrarM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
