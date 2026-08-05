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
    public partial class ucMotivacionAsistencia : UserControl
    {
        public ucMotivacionAsistencia()
        {
            InitializeComponent();
        }

        private void ucMotivacionAsistencia_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1", "Juan Segundo");
            dataGridView1.Rows.Add("2", "Juan Tercero");
            dataGridView1.Rows.Add("3", "Juan De la Torre");

            dataGridView2.Rows.Add("1", "Juan Segundo");
            dataGridView2.Rows.Add("2", "Juan Tercero");
            dataGridView2.Rows.Add("3", "Juan De la Torre");

            dataGridView3.Rows.Add("Juan Segundo", "80%");
            dataGridView3.Rows.Add("Juan Tercero", "100%");
            dataGridView3.Rows.Add("Juan De la Torre", "67%");

            dataGridView4.Rows.Add("Juan Segundo", "80%");
            dataGridView4.Rows.Add("Juan Tercero", "100%");
            dataGridView4.Rows.Add("Juan De la Torre", "67%");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
