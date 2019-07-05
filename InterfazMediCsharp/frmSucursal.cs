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
        string modo;
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
            Sucursal sucrusal = (Sucursal)lstSucursal.SelectedItem;
            Sucursal.EliminarSucursal(sucrusal);
            ActualizarListaSucursal();
            LimpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //if (modo == "I")
            //{
            //    Sucursal sucursal = ObtenerSucursalFormulario();

            //    Sucursal.AgregarSucursal(sucursal);


            //}
            //else if (modo == "E")
            //{
            //    int index = lstSucursal.SelectedIndex;

            //    Sucursal sucursal = ObtenerSucursalFormulario();
            //    Sucursal.EditarSucursal(index, sucursal);

            //}

            //ActualizarListaSucursal();
            //LimpiarFormulario();
            //BloquearFormulario();

            string Valoringresado = "";
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el nombre", "ADVERTENCIA");
                txtNombre.SelectAll();
                txtNombre.Focus();
                Valoringresado = "-1";
                return;
            }

            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el direccion", "ADVERTENCIA");
                txtDireccion.SelectAll();
                txtDireccion.Focus();
                Valoringresado = "-1";
                return;
            }

            if (txtCantidadPisos.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese la Cantidad de pisos", "ADVERTENCIA");
                txtCantidadPisos.SelectAll();
                txtCantidadPisos.Focus();
                Valoringresado = "-1";
                return;
            }

            else
           if (modo == "I")
            {
                Sucursal sucursal = ObtenerSucursalFormulario();

                Sucursal.AgregarSucursal(sucursal);


            }
            else if (modo == "E")
            {
                int index = lstSucursal.SelectedIndex;

                Sucursal sucursal = ObtenerSucursalFormulario();
                Sucursal.EditarSucursal(index, sucursal);

            }

            ActualizarListaSucursal();
            LimpiarFormulario();
            BloquearFormulario();

        }

        private void BloquearFormulario()
        {
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtCantidadPisos.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = false;

        }
        private void DesbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtCantidadPisos.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = true;

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
            ActualizarListaSucursal();
            BloquearFormulario();
        }

        private Sucursal ObtenerSucursalFormulario()
        {
            Sucursal s = new Sucursal();
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                s.Id = Convert.ToInt32(txtId.Text);
            }
            s.NombreSucursal = txtNombre.Text;
            s.Direccion = txtDireccion.Text;
            s.CantidadPisos = Convert.ToInt32(txtCantidadPisos.Text);
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
        }

        private void lstSucursal_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = (Sucursal)lstSucursal.SelectedItem;

            if (sucursal != null)
            {
                txtId.Text = Convert.ToString(sucursal.Id);
                txtNombre.Text = sucursal.NombreSucursal;
                txtDireccion.Text = sucursal.Direccion;
                txtCantidadPisos.Text = Convert.ToString(sucursal.CantidadPisos);
                DesbloquearFormulario();
            }

        }

        private void frmSucursal_Load_1(object sender, EventArgs e)
        {
            ActualizarListaSucursal();
            BloquearFormulario();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo foramto texto");
            }
        }

        private void txtCantidadPisos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo foramto Numero");
            }

        }
    }
}
