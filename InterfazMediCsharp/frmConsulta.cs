using MediCsharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            //CargarDT();
        }

        private void CargarDT()
        {
            dtgDetalleConsulta.DataSource = CargarData1();
        }

        private object CargarData1()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT P.NombrePaciente, D.NombreDoctor, CD.FechaConsuLTA, CD.Diagnostico FROM CONSULTA_DETALLE CD JOIN        Consulta C   ON C.Id = CD.consulta_id JOIN  Paciente P  ON C.paciente = p.Id  JOIN  Doctor D  ON D.Id = CD.doctor; ";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

           
           dtgDetalleConsulta.AutoGenerateColumns = true;
           cmbNombreDoctor.DataSource = Doctor.ObtenerDoctores();
           cmbPaciente.DataSource = Paciente.ObtenerPacientes();
            cmbSucursal.DataSource = Sucursal.ObtenerSucursal();
            cmbTipoUrgencia.DataSource = Enum.GetValues(typeof(TipoUrgencia));

            dtgDetalleConsulta.DataSource = Consulta.ObtenerConsultasPendientes();

            CargarDT();
            consulta = new Consulta();
            ActualizarDataGrid();
             CargarDT();

          
            

        }

        

        private void ActualizarDataGrid()
        {
            //dtgDetalleConsulta.DataSource = null;
            //dtgDetalleConsulta.DataSource = Consulta.ObtenerConsultasPendientes();
            dtgDetalleConsulta.DataSource = consulta.detalle_consulta;

        }
        private void Limpiar()
        {
            txtDiagnostico.Text = "0";
            cmbPaciente.SelectedItem = null;
            cmbNombreDoctor.SelectedItem = null;
            


        }

      
        public void LimpiarForm() {
            
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
            ConsultaDetalle dd = (ConsultaDetalle)dtgDetalleConsulta.CurrentRow.DataBoundItem;
            if (dd != null)
            {
                consulta.detalle_consulta.Remove(dd);
            }
            ActualizarDataGrid();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgDetalleConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaDetalle dd = new ConsultaDetalle();
            dd.paciente = (Paciente)cmbPaciente.SelectedItem;
            dd.doctor = (Doctor)cmbNombreDoctor.SelectedItem;
            dd.Diagnostico = txtDiagnostico.Text;
            dd.FechaConsulta = dtpFechaConsulta.Value.Date;
            dd.Sucursal = (Sucursal)cmbSucursal.SelectedItem;
            dd.tipourgencia = (TipoUrgencia)cmbTipoUrgencia.SelectedItem;
            consulta.detalle_consulta.Add(dd);
            ActualizarDataGrid();
            consulta.paciente = (Paciente)cmbPaciente.SelectedItem;
            consulta.doctor = (Doctor)cmbNombreDoctor.SelectedItem;
            Consulta.Agregar(consulta);
            MessageBox.Show("La Consulta ha sido guardado con éxito");
            Limpiar();
            //dtgDetalleConsulta.DataSource = null;
            cmbPaciente.SelectedItem = null;
            cmbNombreDoctor.SelectedItem = null;


            consulta = new Consulta();

            Limpiar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmConsultasProcesadas form = new frmConsultasProcesadas();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulta cd = (Consulta)dtgDetalleConsulta.CurrentRow.DataBoundItem;
            //consulta.detalle_consulta.Remove(cd);
            ActualizarDataGrid();
        }
    }







}
