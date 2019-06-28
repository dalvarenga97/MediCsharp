using MediCsharp;
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
    public partial class frmReceta : Form
    {
        Consulta consulta;

        public frmReceta()
        {
            InitializeComponent();
        }

        private void frmReceta_Load(object sender, EventArgs e)
        {

            cmbConsulta.DataSource = Consulta.ObtenerConsulta();
            cmbConsulta.SelectedItem = null;
            ActualizarDataGrid();
        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            DetalleMedicamento dm = new DetalleMedicamento();
            dm.Cantidad = Convert.ToInt16(txtCantidad.Text);
            dm.NombreMedicamento = (Medicamento)cmbMedicamento.SelectedItem;
            dm.NumeroConsulta = (Consulta)cmbConsulta.SelectedItem;
            consulta.detalle_medicamento.Add(dm);
            ActualizarDataGrid();
            LimpiarReceta();
        }

        private void btnEliminarReceta_Click(object sender, EventArgs e)
        {
            DetalleMedicamento dtm = (DetalleMedicamento)dtgDetalleMedicamento.CurrentRow.DataBoundItem;
            if (dtm != null)
            {
                consulta.detalle_medicamento.Remove(dtm);
            }
            ActualizarDataGrid();
            LimpiarReceta();
        }

        private void cmbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgDetalleMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarDataGrid()
        {
            dtgDetalleMedicamento.DataSource = null;
            dtgDetalleMedicamento.DataSource = consulta.detalle_medicamento;
        }

        private void LimpiarReceta()
        {
            txtCantidad.Text = "";
            cmbMedicamento.SelectedItem = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
