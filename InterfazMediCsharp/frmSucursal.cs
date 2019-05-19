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
            LimpiarFormulario();
            ActualizarListaSucursal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = (Sucursal)lstSucursal.SelectedItem;
            Sucursal.EliminarSucursal(sucursal);
            ActualizarListaSucursal();
            LimpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = ObtenerSucursalFormulario();

            Sucursal.AgregarSucursal(sucursal);

            ActualizarListaSucursal();

            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstSucursal.SelectedIndex;
            Sucursal.listaSucursal[index] = ObtenerSucursalFormulario();
            MessageBox.Show("Sucursal Modificada con Exito");
            ActualizarListaSucursal();
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
            s.Direccion = txtDireccion.Text;
            s.CantidadPisos = Convert.ToInt64(txtCantidadPisos.Text);
            s.HorarioInicioVisitas = dtpiniciovisitas.Value;
            s.HorarioFinVisitas = dtpfinvisitas.Value;
            return s;

        }
        private void ActualizarListaSucursal()
        {
            lstSucursal.DataSource = null;
            lstSucursal.DataSource = Sucursal.ObtenerSucursal();

        }
        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCantidadPisos.Text = "";
            dtpiniciovisitas.Value = System.DateTime.Now;
            dtpfinvisitas.Value = System.DateTime.Now;
        }

        private void lstSucursal_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = (Sucursal)lstSucursal.SelectedItem;

            if (sucursal != null)
            {
                txtCodigo.Text = Convert.ToString(sucursal.NumeroSucursal);
                txtNombre.Text = sucursal.NombreSucursal;
                txtDireccion.Text = sucursal.Direccion;
                txtCantidadPisos.Text = Convert.ToString(sucursal.CantidadPisos);
                dtpiniciovisitas.Value = sucursal.HorarioInicioVisitas;
                dtpfinvisitas.Value = sucursal.HorarioFinVisitas;
            }
        }

        private void frmSucursal_Load_1(object sender, EventArgs e)
        {

        }
    }
}
