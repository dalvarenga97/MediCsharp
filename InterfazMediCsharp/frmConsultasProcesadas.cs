using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediCsharp;

namespace InterfazMediCsharp
{
    public partial class frmConsultasProcesadas : Form
    {
        public frmConsultasProcesadas()
        {
            InitializeComponent();
        }

        private void frmConsultasProcesadas_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgtConsultasPendientes.DataSource = null;
            dgtConsultasPendientes.DataSource = Consulta.ObtenerConsultasPendientes();
            dgtConsultasPendientes.Columns[1].Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<int> listaIds = new List<int>();
            foreach (DataGridViewRow registro in dgtConsultasPendientes.Rows)
            {
                if (registro.Cells[0].Value == null) registro.Cells[0].Value = false;
                if ((bool)registro.Cells[0].Value == true)
                {
                    listaIds.Add((int)registro.Cells[1].Value);

                }

            }
            Consulta.ConfirmarConsultas(listaIds);
            ActualizarDataGrid();
        }
    }
}
