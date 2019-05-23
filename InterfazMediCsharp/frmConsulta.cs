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

        Paciente paciente;

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
            Consulta consulta = ObtenerConsultasFormulario();
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
            rdbCritico.Checked = false;
            rdbGrave.Checked = false;
            rdbLeve.Checked = false;
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
        {;
            int index = lstconsultas.SelectedIndex;
            Consulta.listaConsulta[index] = ObtenerConsultasFormulario();
            MessageBox.Show("Consulta modificada con Exito");
            ActualizarListaConsultas();
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
                if (consul.TipoUrgencia == TipoUrgencia.Critico)
                {
                    rdbCritico.Checked = true;
                }
                else if (consul.TipoUrgencia == TipoUrgencia.Grave)
                {
                    rdbGrave.Checked = true;
                }
                else if (consul.TipoUrgencia == TipoUrgencia.Leve)
                {
                    rdbLeve.Checked = true;
                };
            }
        }

        private Consulta ObtenerConsultasFormulario()
        {
            Consulta c = new Consulta();

            c.NumeroConsulta = Convert.ToInt16(txtNumeroConsulta.Text);
            c.NombreDoctor = (Doctor)cmbNombreDoctor.SelectedItem;
            c.CIPaciente = (Paciente)cmbCIpaciente.SelectedItem;
            c.NombrePaciente = txtNombrePaciente.Text;
            c.Sucursal = (Sucursal)cmbSucursal.SelectedValue;
            c.HoraInicioConsulta = dtpHoraInicio.Value;
            c.HoraFinConsulta = dtpHoraFin.Value;
            c.Diagnostico = txtDiagnostico.Text;
            if (rdbCritico.Checked)
            {
                c.TipoUrgencia = TipoUrgencia.Critico;
            }
            else if (rdbGrave.Checked)
            {
                c.TipoUrgencia = TipoUrgencia.Grave;
            }
            else if (rdbLeve.Checked)
            {
                c.TipoUrgencia = TipoUrgencia.Leve;
            }
            return c;

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

        // cambio de planes
        private void txtNombrePaciente_Leave(object sender, EventArgs e)
        {
          //  cmbCIpaciente.Text = paciente.obtenerPacientexNombre(txtNombrePaciente.Text);
        }
    }


}
