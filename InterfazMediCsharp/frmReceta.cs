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
using System.Data.SqlClient;

namespace InterfazMediCsharp
{
    public partial class frmReceta : Form
    {

        Receta receta;
        public frmReceta()
        {
            InitializeComponent();
        }

        private void gpbMedicamento_Enter(object sender, EventArgs e)
        {

        }

        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            DetalleReceta dc = new DetalleReceta();

            dc.cantidad = Convert.ToString(txtCantidad.Text);
            dc.paciente = (Paciente)cmbPaciente.SelectedItem;
            dc.medicamento = (Medicamento)cmbMedicamento.SelectedItem;
            receta.detalle_receta.Add(dc);
            ActualizarDataGrid();

            


        }



        private void Limpiar()
        {
            
            cmbPaciente.SelectedItem = null;
            cmbMedicamento.SelectedItem = null;
            txtCantidad.Text = "";
            


        }

        private void ActualizarDataGrid()
        {
            dtgDetalleReceta.DataSource = null;
            dtgDetalleReceta.DataSource = receta.detalle_receta;

        }

        private void btnEliminarReceta_Click(object sender, EventArgs e)
        {
            {
                DetalleReceta dd = (DetalleReceta)dtgDetalleReceta.CurrentRow.DataBoundItem;
                if (dd != null)
                {
                    receta.detalle_receta.Remove(dd);
                }
                ActualizarDataGrid();
            }
        }

        private void dtgDetalleMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReceta_Load(object sender, EventArgs e)
        {
            
            cmbMedicamento.DataSource = Medicamento.ObtenerMedicamento();
            cmbPaciente.DataSource = Paciente.ObtenerPacientes();
            receta = new Receta();
            dtgDetalleReceta.AutoGenerateColumns = true;
           


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            receta.paciente = (Paciente)cmbPaciente.SelectedItem;
            receta.cantidad = txtCantidad.Text;
            receta.medicamento = (Medicamento)cmbMedicamento.SelectedItem;
           
            Receta.Agregar(receta);
            MessageBox.Show("La Receta ha sido guardada con éxito");
            Limpiar();
            dtgDetalleReceta.DataSource = null;
           cmbPaciente.SelectedItem = null;
            cmbMedicamento.SelectedItem = null;

            receta = new Receta();

        }
    }


        

    }
    

