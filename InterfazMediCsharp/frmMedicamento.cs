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
        string modo;
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
            //if (modo == "I")
            //{
            //    Medicamento medicamento = ObtenerMedicamentoFormulario();

            //    Medicamento.AgregarMedicamento(medicamento);


            //}
            //else if (modo == "E")
            //{
            //    int index = lstMedicamento.SelectedIndex;

            //    Medicamento medicamento = ObtenerMedicamentoFormulario();
            //    Medicamento.EditarMedicamento(index, medicamento);

            //}

            //ActualizarListaMedicamento();
            //LimpiarFormulario();
            //BloquearFormulario();

            string Valoringresado = "";
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el nombre", "ADVERTENCIA");
                txtNombre.SelectAll();
                txtNombre.Focus();
                Valoringresado = "-1";
                return;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el Descripcion", "ADVERTENCIA");
                txtDescripcion.SelectAll();
                txtDescripcion.Focus();
                Valoringresado = "-1";
                return;
            }

            if (txtObservacion.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese la Observacion", "ADVERTENCIA");
                txtObservacion.SelectAll();
                txtObservacion.Focus();
                Valoringresado = "-1";
                return;
            }
            if (cmbOrigen.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el Origen", "ADVERTENCIA");
                cmbOrigen.SelectAll();
                cmbOrigen.Focus();
                Valoringresado = "-1";
                return;
            }
            //if (dtpFechaNacimiento.Value < System.DateTime.Today)  TIPO
            //{
            //    MessageBox.Show("La fecha de Nacimiento. no puede ser mayor a la Fecha de Hoy", "ADVERTENCIA");
            //    dtpFechaNacimiento.Focus();
            //    Valoringresado = "-1";
            //    return;
            //}


            else
           if (modo == "I")
            {
                Medicamento medicamento = ObtenerMedicamentoFormulario();

                Medicamento.AgregarMedicamento(medicamento);


            }
            else if (modo == "E")
            {
                int index = lstMedicamento.SelectedIndex;

                Medicamento medicamento = ObtenerMedicamentoFormulario();
                Medicamento.EditarMedicamento(index, medicamento);

            }

            ActualizarListaMedicamento();
            LimpiarFormulario();
            BloquearFormulario();
        }
        private void ActualizarListaMedicamento()
        {
            lstMedicamento.DataSource = null;
            lstMedicamento.DataSource = Medicamento.ObtenerMedicamento();

        }
        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbOrigen.SelectedItem = null;
            txtObservacion.Text = "";
            rdbJarabe.Checked = false;
            rdbPastillas.Checked = true;
            rdbInyectable.Checked = false;
            

        }

        private void lstMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento medi = (Medicamento)lstMedicamento.SelectedItem;

            if (medi != null)
            {
                txtId.Text = Convert.ToString(medi.Id);
                txtNombre.Text = medi.NombreMedicamento;
                txtDescripcion.Text = medi.DescripcionMedicamento;
                cmbOrigen.SelectedItem = medi.origen;
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
                DesbloquearFormulario();


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = ObtenerMedicamentoFormulario();

            int index = lstMedicamento.SelectedIndex;
            Medicamento.EditarMedicamento(index, medicamento);

            MessageBox.Show("Medicamento Modificado con Exito");

            ActualizarListaMedicamento();
            LimpiarFormulario();


        }

        private Medicamento ObtenerMedicamentoFormulario()
        {
            
            Medicamento m = new Medicamento();
            
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                m.Id = Convert.ToInt32(txtId.Text);
            }
           
            m.NombreMedicamento = txtNombre.Text;
            m.DescripcionMedicamento = txtDescripcion.Text;
            m.origen = (Origen)cmbOrigen.SelectedItem;
            m.ObservacionMedicamento = txtObservacion.Text;
            if (rdbJarabe.Checked) { m.tipomedicamento = TipoMedicamento.jarabe; }
            if (rdbPastillas.Checked) { m.tipomedicamento = TipoMedicamento.pastillas; }
            if (rdbInyectable.Checked) { m.tipomedicamento = TipoMedicamento.inyectables; }

            return m;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                Medicamento medicamento = (Medicamento)lstMedicamento.SelectedItem;
                if (medicamento != null)
                {
                    Medicamento.EliminarMedicamento(medicamento);
                    ActualizarListaMedicamento();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Por favor, Seleccione un item de la lista");
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void frmMedicamento_Load(object sender, EventArgs e)
        {
            ActualizarMedicamento();
            cmbOrigen.DataSource = Enum.GetValues(typeof(Origen));
            BloquearFormulario();
        }

        private void ActualizarMedicamento()
        {
            lstMedicamento.DataSource = null;
            lstMedicamento.DataSource = Medicamento.ObtenerMedicamento();

        }
        private void BloquearFormulario()
        {
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            cmbOrigen.Enabled = false;
            txtObservacion.Enabled = false;
            rdbInyectable.Enabled = false;
            rdbJarabe.Enabled = false;
            rdbPastillas.Enabled = false;
            btnLimpiar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }

        private void DesbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            cmbOrigen.Enabled = true;
            txtObservacion.Enabled = true;        
            rdbInyectable.Enabled = true;
            rdbJarabe.Enabled = true;
            rdbPastillas.Enabled = true;
            btnLimpiar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo foramto texto");
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo foramto texto");
            }
        }

        private void txtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;
            //}

            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //    MessageBox.Show("solo foramto texto");
            //}
        }
    }
    

}
