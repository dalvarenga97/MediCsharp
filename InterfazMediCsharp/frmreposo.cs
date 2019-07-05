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
    public partial class frmreposo : Form
    {
        Reposo reposo;
        public frmreposo()
        {
            InitializeComponent();
            LimpiarForm();
            ActualizarDataGrid();
        }

        private void frmreposo_Load(object sender, EventArgs e)
        {
            cmbDoctor.DataSource = Doctor.ObtenerDoctores();
            cmbPaciente.DataSource = Paciente.ObtenerPacientes();
            reposo = new Reposo();
            dtgReposo.AutoGenerateColumns = true;

            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dtgReposo.DataSource = null;
            dtgReposo.DataSource = Reposo.listaReposo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Reposo rp = new Reposo();
           // rp.Id = txtId.Text;
            rp.doctor = (Doctor)cmbDoctor.SelectedItem;
            rp.paciente = (Paciente)cmbPaciente.SelectedItem;
           // rp.CantidadDias = txtCantidadDias.Text;
            Reposo.listaReposo.Add(rp);

            ActualizarDataGrid();
            LimpiarForm();
        }

        public void LimpiarForm()
        {
            txtId.Text = "";
            cmbDoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            txtCantidadDias.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Reposo reposo = (Reposo)dtgReposo.CurrentRow.DataBoundItem;
            if (reposo != null)
            {
                Reposo.listaReposo.Remove(reposo);
            }
            ActualizarDataGrid();
            LimpiarForm();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Reposo.AgregarReposo(reposo);
            MessageBox.Show("El reposo se guardó con Exito!!");
            LimpiarForm();
            dtgReposo.DataSource = null;
            cmbDoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            reposo = new Reposo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadDias_KeyPress(object sender, KeyPressEventArgs e)
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
