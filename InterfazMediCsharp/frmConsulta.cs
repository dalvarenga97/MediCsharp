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
    public partial class frmConsulta : Form
    {
        Consulta consulta;
        public frmConsulta()
        {
            InitializeComponent();
        }



        private void frmConsulta_Load(object sender, EventArgs e)
        {
            cmbMedicamento.DataSource = Medicamento.ObtenerMedicamento();
            cmbNombreDoctor.DataSource = Doctor.ObtenerDoctor();
            cmbCIpaciente.DataSource = Paciente.ObtenerPaciente();

            consulta = new Consulta();
            dtgDetalleMedicamento.AutoGenerateColumns = true;
        }

        private void ActualizarDataGrid()
        {
            dtgDetalleMedicamento.DataSource = null;
            dtgDetalleMedicamento.DataSource = consulta.detalle_medicamento;
        }

        private void Limpiar()
        {
            txtCantidad.Text = "";
            cmbMedicamento.SelectedItem = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.NumeroConsulta = Convert.ToInt16(txtNumeroConsulta.Text);
            consulta.NombreDoctor = (Doctor)cmbNombreDoctor.SelectedItem;
            consulta.CIPaciente = (Paciente)cmbCIpaciente.SelectedItem;
            consulta.NombrePaciente = txtNombrePaciente.Text;
            consulta.Sucursal = (Sucursal)cmbSucursal.SelectedValue;
            consulta.HoraInicioConsulta = dtpHoraInicio.Value.Date;
            consulta.HoraFinConsulta = dtpHoraFin.Value.Date;
            consulta.Diagnostico = txtDiagnostico.Text;

            Consulta.listaConsulta.Add(consulta);

            ActualizarDataGrid();
            LimpiarForm();
        }
        
        public void LimpiarForm() {
            txtNumeroConsulta.Text = "";
            cmbNombreDoctor.SelectedItem = null;
            cmbCIpaciente.SelectedItem = null;
            txtNombrePaciente.Text = "";
            cmbSucursal.SelectedItem = null;
            dtpHoraInicio.Value = System.DateTime.Now;
            dtpHoraFin.Value = System.DateTime.Now;
            txtDiagnostico.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Consulta consulta = (Consulta)dtgDetalleMedicamento.CurrentRow.DataBoundItem;
            if (consulta != null)
            {
                Consulta.listaConsulta.Remove(consulta);
            }
            ActualizarDataGrid();
            LimpiarForm();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           // int index = lstconsultas.SelectedIndex;
           // Sucursal.listaSucursal[index] = ObtenerlistaConsulta();
            MessageBox.Show("Sucursal Modificada con Exito");
          //  ActualizarListaSucursal();
        }

        private void button2_Click(object sender, EventArgs e)  //Es el boton btnAgregarReceta
        {
            DetalleMedicamento dm = new DetalleMedicamento();
            dm.Cantidad = Convert.ToInt16(txtCantidad.Text);
            dm.NombreMedicamento = (Medicamento)cmbMedicamento.SelectedItem;
            consulta.detalle_medicamento.Add(dm);
            ActualizarDataGrid();
            Limpiar();
        }

        private void btnEliminarReceta_Click(object sender, EventArgs e)
        {
            DetalleMedicamento dtm = (DetalleMedicamento)dtgDetalleMedicamento.CurrentRow.DataBoundItem;
            if (dtm != null)
            {
                consulta.detalle_medicamento.Remove(dtm);
            }
            ActualizarDataGrid();
            LimpiarForm();
        }
    }


}
