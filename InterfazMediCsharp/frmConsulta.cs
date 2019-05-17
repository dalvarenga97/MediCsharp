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

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleMedicamento dm = new DetalleMedicamento();
            dm.Cantidad = Convert.ToInt16(txtCantidad.Text);
            dm.NombreMedicamento = (Medicamento)cmbMedicamento.SelectedItem;
            consulta.detalle_medicamento.Add(dm);
            ActualizarDataGrid();
            Limpiar();
    

        }

        private void ActualizarDataGrid()
        {
            dtgDetalleMedicamento.DataSource = null;
            dtgDetalleMedicamento.DataSource = consulta.detalle_medicamento;
        }

        private void Limpiar()
        {
            txtCantidad.Text = "0";
            cmbMedicamento.SelectedItem = null;
        }

    }


}
