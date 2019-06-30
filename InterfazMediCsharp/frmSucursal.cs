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
            if (lstSucursal.SelectedItem != null)
            {
                Sucursal sucursalSeleccionada = (Sucursal)lstSucursal.SelectedItem;
                Sucursal.EliminarSucursal(sucursalSeleccionada);

                lstSucursal.DataSource = null;
                lstSucursal.DataSource = Sucursal.ObtenerSucursal();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Sucursal su = new Sucursal();
            su.NombreSucursal = txtNombre.Text;
            su.Direccion = txtDireccion.Text;
            su.CantidadPisos = Convert.ToInt16(txtCantidadPisos.Text);
            su.HorarioInicioVisitas = dtpiniciovisitas.Value.Date;
            su.HorarioFinVisitas = dtpfinvisitas.Value.Date;

        }
    
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Sucursal su = ObtenerSucursalFormulario();

            int index = lstSucursal.SelectedIndex;
            Sucursal.EditarSucursal(index, su);

            MessageBox.Show("La sucursal se modifico con Exito");

            ActualizarListaSucursal();
            LimpiarFormulario();
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
            s.NumeroSucursal = Convert.ToInt32(txtId.Text);
            s.NombreSucursal = txtNombre.Text;
            s.Direccion = txtDireccion.Text;
            s.CantidadPisos = Convert.ToInt32(txtCantidadPisos.Text);
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
            txtId.Text = "";
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
                txtId.Text = Convert.ToString(sucursal.NumeroSucursal);
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
