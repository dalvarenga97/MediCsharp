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
    public partial class frmMedicamento : Form
    {
        public frmMedicamento()
        {
            InitializeComponent();
            LimpiarFormulario();
            ActualizarListaMedicamento();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = ObtenerMedicamentoFormulario();

            Medicamento.AgregarMedicamento(medicamento);

            ActualizarListaMedicamento();
            LimpiarFormulario();
        }
        private void ActualizarListaMedicamento()
        {
            lstMedicamento.DataSource = null;
            lstMedicamento.DataSource = Medicamento.ObtenerMedicamento();

        }
        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtOrigen.Text = "";
            txtObservacion.Text = "";
            rdbJarabe.Checked = false;
            rdbPastillas.Checked = false;
            rdbInyectable.Checked = false;
            

        }

        private void lstMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento medi = (Medicamento)lstMedicamento.SelectedItem;

            if (medi != null)
            {
                txtCodigo.Text = Convert.ToString(medi.CodigoMedicamento);
                txtNombre.Text = medi.NombreMedicamento;
                txtDescripcion.Text = medi.DescripcionMedicamento;
                txtOrigen.Text = medi.Origen;
                txtObservacion.Text = medi.ObservacionMedicamento;
                if (medi.tipomedicamento == TipoMedicamento.jarabe)
                {
                    rdbJarabe.Checked = true;
                }
                else if (medi.tipomedicamento == TipoMedicamento.pastillas)
                {
                    rdbPastillas.Checked = true;
                }
                else if (medi.tipomedicamento == TipoMedicamento.inyectables)
                {
                    rdbInyectable.Checked = true;
                }



            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstMedicamento.SelectedIndex;
            Medicamento.listaMedicamento[index] = ObtenerMedicamentoFormulario();
            MessageBox.Show("Medicamento Modificado con Exito");
            ActualizarListaMedicamento();
        }

        private Medicamento ObtenerMedicamentoFormulario()
        {
            Medicamento m = new Medicamento();
            m.CodigoMedicamento = Convert.ToInt64(txtCodigo.Text);
            m.NombreMedicamento = txtNombre.Text;
            m.DescripcionMedicamento = txtDescripcion.Text;
            m.Origen = txtOrigen.Text;
            m.ObservacionMedicamento = txtObservacion.Text;
            if (rdbJarabe.Checked) { m.tipomedicamento = TipoMedicamento.jarabe; }
            if (rdbPastillas.Checked) { m.tipomedicamento = TipoMedicamento.pastillas; }
            if (rdbInyectable.Checked) { m.tipomedicamento = TipoMedicamento.inyectables; }

            return m;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Medicamento medic = (Medicamento)lstMedicamento.SelectedItem;
            Medicamento.EliminarMedicamento(medic);
            ActualizarListaMedicamento();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void frmMedicamento_Load(object sender, EventArgs e)
        {

        }
    }

}
