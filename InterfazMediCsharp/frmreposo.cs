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
            Limpiar();
            
        }



        private void frmreposo_Load(object sender, EventArgs e)
        {
            cmbDoctor.DataSource = Doctor.ObtenerDoctores();
            cmbPaciente.DataSource = Paciente.ObtenerPacientes();
            reposo = new Reposo();
            dtgReposo.AutoGenerateColumns = true;

            

        }

        private void ActualizarDataGrid()
        {
            dtgReposo.DataSource = null;
            dtgReposo.DataSource = reposo.detalle_reposo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Reposo rp = new Reposo();
           
            rp.doctor = (Doctor)cmbDoctor.SelectedItem;
            rp.paciente = (Paciente)cmbPaciente.SelectedItem;
          
            Reposo.listaReposo.Add(rp);

            ActualizarDataGrid();
            Limpiar();
        }

        public void Limpiar()
        {
           
            cmbDoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            txtCantidad.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            {
                DetalleReposo dr = (DetalleReposo)dtgReposo.CurrentRow.DataBoundItem;
                if (dr != null)
                {
                    reposo.detalle_reposo.Remove(dr);
                }
                ActualizarDataGrid();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Reposo.Agregar(reposo);
            MessageBox.Show("El reposo se guardó con Exito!!");
            Limpiar();
            dtgReposo.DataSource = null;
            cmbDoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            reposo = new Reposo();
        }

     

      

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DetalleReposo dr = new DetalleReposo();

            dr.cantidad = Convert.ToString(txtCantidad.Text);
            dr.paciente = (Paciente)cmbPaciente.SelectedItem;
            dr.doctor = (Doctor)cmbDoctor.SelectedItem;
            reposo.detalle_reposo.Add(dr);
            ActualizarDataGrid();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            reposo.paciente = (Paciente)cmbPaciente.SelectedItem;
            reposo.cantidad = txtCantidad.Text;
            reposo.doctor = (Doctor)cmbDoctor.SelectedItem;

            Reposo.Agregar(reposo);
            MessageBox.Show("El Reposo ha sido guardado con éxito");
            Limpiar();
            dtgReposo.DataSource = null;
            cmbPaciente.SelectedItem = null;
            cmbDoctor.SelectedItem = null;

            reposo = new Reposo();
        }
    }
}
