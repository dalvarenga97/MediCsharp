using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazMediCsharp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente form = new frmPaciente();
            form.Show();

        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctor form = new frmDoctor();
            form.Show();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicamento form = new frmMedicamento();
                form.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursal form = new frmSucursal();
            form.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta form = new frmConsulta();
            form.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercade form = new frmAcercade();
            form.Show();
        }

        private void reposoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreposo form = new frmreposo();
            form.Show();
        }
    }
}
