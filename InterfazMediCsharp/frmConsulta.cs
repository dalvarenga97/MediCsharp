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


            dtgDetalleConsulta.AutoGenerateColumns = true;
            cmbNombreDoctor.DataSource = Doctor.ObtenerDoctor();
            cmbPaciente.DataSource = Paciente.ObtenerPaciente();    
            



            consulta = new Consulta();
            ActualizarDataGrid();
            
        }

       

        private void ActualizarDataGrid()
        {
            dtgDetalleConsulta.DataSource = null;
            dtgDetalleConsulta.DataSource = Consulta.Obtener();

        }
        private void Limpiar()
        {
            txtDiagnostico.Text = "0";
            cmbPaciente.SelectedItem = null;


        }

      
        public void LimpiarForm() {
            txtId.Text = "";
            cmbNombreDoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;            
            
            txtDiagnostico.Text = "";
            
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConsultaDetalle cd = (ConsultaDetalle)dtgDetalleConsulta.CurrentRow.DataBoundItem;
            consulta.Detalle_Consulta.Remove(cd);
            ActualizarDataGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.paciente = (Paciente)cmbPaciente.SelectedItem;
            consulta.Diagnostico = Convert.ToString(txtDiagnostico.Text);
           
            Consulta.AgregarConsulta(consulta);
            ConsultaDetalle cd = new ConsultaDetalle();
            cd.paciente = (Paciente)cmbPaciente.SelectedItem;
            cd.FechaConsulta = dtpFechaConsulta.Value.Date;
            cd.doctor = (Doctor)cmbNombreDoctor.SelectedItem;
            consulta.Detalle_Consulta.Add(cd);
            MessageBox.Show("La Consulta ha sido guardado con éxito");
            Limpiar();
            dtgDetalleConsulta.DataSource = null;
            dtpFechaConsulta.Value = System.DateTime.Now;
            cmbNombreDoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            ActualizarDataGrid();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }







}
