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
    public partial class frmReceta : Form
    {

       // Receta receta;
        public frmReceta()
        {
            InitializeComponent();
        }

        private void gpbMedicamento_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            DetalleReceta dm = new DetalleReceta();
            dm.Cantidad = Convert.ToInt16(txtCantidad.Text);
            dm.NombreMedicamento = (Medicamento)cmbMedicamento.SelectedItem;
            //receta.detalle_medicamento.Add(dm);
          // ActualizarDataGrid();
            //LimpiarReceta();
        }

        private void btnEliminarReceta_Click(object sender, EventArgs e)
        {
            DetalleReceta dtm = (DetalleReceta)dtgDetalleReceta.CurrentRow.DataBoundItem;
            if (dtm != null)
            {
               // consulta.detalle_medicamento.Remove(dtm);
            }
          //  ActualizarDataGrid();
           // LimpiarReceta();
        }

        private void dtgDetalleMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReceta_Load(object sender, EventArgs e)
        {

        }
    }
}
