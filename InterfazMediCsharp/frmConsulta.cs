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
            LimpiarForm();
        }



        private void frmConsulta_Load(object sender, EventArgs e)
        {
            cmbMedicamento.DataSource = Medicamento.ObtenerMedicamento();
            cmbNombreDoctor.DataSource = Doctor.ObtenerDoctor();
            cmbCIpaciente.DataSource = Paciente.ObtenerPaciente();
           // txtNombrePaciente.Text = Paciente.ObtenerPaciente();
            cmbSucursal.DataSource = Sucursal.ObtenerSucursal();

            consulta = new Consulta();
            dtgDetalleMedicamento.AutoGenerateColumns = true;
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

            ActualizarListaConsultas();
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
            Consulta consulta = (Consulta)lstconsultas.SelectedItem;
            Consulta.EliminarConsulta(consulta);
            ActualizarListaConsultas();
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

        private void lstconsultas_Click(object sender, EventArgs e)
        {
            Consulta consul = (Consulta)lstconsultas.SelectedItem;

            if (consul != null)
            {
                txtNumeroConsulta.Text = Convert.ToString(consul.NumeroConsulta);
                cmbNombreDoctor.SelectedItem = consul.NombreDoctor;
                cmbCIpaciente.SelectedItem = consul.CIPaciente;
                txtNombrePaciente.Text = consul.NombrePaciente;
                cmbSucursal.SelectedItem = consul.Sucursal;
                dtpHoraInicio.Value = consul.HoraInicioConsulta;
                dtpHoraFin.Value = consul.HoraFinConsulta;
                txtDiagnostico.Text = consul.Diagnostico;
            }
        }

        private void ActualizarListaConsultas()
        {
            lstconsultas.DataSource = null;
            lstconsultas.DataSource = Consulta.ObtenerConsulta();

        }

        private void button2_Click(object sender, EventArgs e)  // btnAgregarReceta
        {
            DetalleMedicamento dm = new DetalleMedicamento();
            dm.Cantidad = Convert.ToInt16(txtCantidad.Text);
            dm.NombreMedicamento = (Medicamento)cmbMedicamento.SelectedItem;
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

        
    }


}
