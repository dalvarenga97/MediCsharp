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
    public partial class frmSucursal : Form
    {
        public frmSucursal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = ObtenerSucursalFormulario();

            Sucursal.AgregarSucursal(sucursal);

            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {

        }

        private Sucursal ObtenerSucursalFormulario()
        {
            Sucursal s = new Sucursal();
            s.NumeroSucursal = Convert.ToInt64(txtCodigo.Text);
            s.NombreSucursal = txtNombre.Text;
            s.Direccion = txtDescripcion.Text;
            s.CantidadPisos = Convert.ToInt64(txtCantidadPisos.Text);
            s.HorarioInicioVisitas = dtpiniciovisitas.Value.Date;
            s.HorarioFinVisitas = dtpfinvisitas.Value.Date;
            return s;

        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCantidadPisos.Text = "";
            dtpiniciovisitas.Value = System.DateTime.Now;
            dtpfinvisitas.Value = System.DateTime.Now;
        }
    }
}
