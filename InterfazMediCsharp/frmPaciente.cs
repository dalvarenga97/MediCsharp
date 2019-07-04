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
    public partial class frmPaciente : Form
    {
        string modo;

       
        public frmPaciente()
        {
            InitializeComponent();
            LimpiarFormulario();
            ActualizarListaPacientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (modo == "I")
            //{
            //    Paciente paciente = ObtenerPacienteFormulario();



            //        Paciente.AgregarPaciente(paciente);




            //}
            //else if (modo == "E")
            //{
            //    int index = lstPaciente.SelectedIndex;

            //    Paciente paciente = ObtenerPacienteFormulario();
            //    Paciente.EditarPaciente(index, paciente);

            //}

            //ActualizarListaPacientes();
            //LimpiarFormulario();
            //BloquearFormulario();

            string Valoringresado = "";
            if (txtNombrePaciente.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el nombre", "ADVERTENCIA");
                txtNombrePaciente.SelectAll();
                txtNombrePaciente.Focus();
                Valoringresado = "-1";
                return;
            }

            if (txtApellidoPaciente.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el apellido", "ADVERTENCIA");
                txtApellidoPaciente.SelectAll();
                txtApellidoPaciente.Focus();
                Valoringresado = "-1";
                return;
            }

            if (txtEdad.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese la edad", "ADVERTENCIA");
                txtEdad.SelectAll();
                txtEdad.Focus();
                Valoringresado = "-1";
                return;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el Telefono", "ADVERTENCIA");
                txtTelefono.SelectAll();
                txtTelefono.Focus();
                Valoringresado = "-1";
                return;
            }
            if (dtpFechaNacimiento.Value < System.DateTime.Today)
            {
                MessageBox.Show("La fecha de Nacimiento. no puede ser mayor a la Fecha de Hoy", "ADVERTENCIA");
                dtpFechaNacimiento.Focus();
                Valoringresado = "-1";
                return;
            }

            if (cmbEstadoCivil.Text.Trim() == "")
            {
                MessageBox.Show("Favor seleccione el estado civil", "ADVERTENCIA");
                cmbEstadoCivil.Focus();
                Valoringresado = "-1";
                return;
            }

            else
           if (modo == "I")
            {
                Paciente paciente = ObtenerPacienteFormulario();

                Paciente.AgregarPaciente(paciente);


            }
            else if (modo == "E")
            {
                int index = lstPaciente.SelectedIndex;

                Paciente paciente = ObtenerPacienteFormulario();
                Paciente.EditarPaciente(index, paciente);

            }

            ActualizarListaPacientes();
            LimpiarFormulario();
            BloquearFormulario();



        }


        private Paciente ObtenerPacienteFormulario()
        {
            Paciente paciente = new Paciente();
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                paciente.Id = Convert.ToInt32(txtId.Text);
            }           
            paciente.NombrePaciente = txtNombrePaciente.Text;
            paciente.ApellidoPaciente = txtApellidoPaciente.Text;
            paciente.Edad = Convert.ToInt16(txtEdad.Text);
            if (rdbFemenino.Checked)
            {
                paciente.sexo = Sexo.Femenino;
            }
            else if (rdbMasculino.Checked)
            {
                paciente.sexo = Sexo.Masculino;
            }
            paciente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            paciente.Telefono = Convert.ToInt32(txtTelefono.Text);
            cmbEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivil));

           
            return paciente;
        }



        private void LimpiarFormulario()
        {
            txtId.Text = "";
            
            txtNombrePaciente.Text = "";
            txtApellidoPaciente.Text = "";
            txtEdad.Text = "";
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
            dtpFechaNacimiento.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            cmbEstadoCivil.SelectedItem = null;
        }

        private void lstPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;

            if (paciente != null)
            {
                txtId.Text = Convert.ToString(paciente.Id);                
                txtNombrePaciente.Text = paciente.NombrePaciente;
                txtApellidoPaciente.Text = paciente.ApellidoPaciente;
                txtEdad.Text = Convert.ToString(paciente.Edad);
                if (paciente.sexo == Sexo.Femenino)
                {
                    rdbFemenino.Checked = true;
                }
                else if (paciente.sexo == Sexo.Masculino)
                {
                    rdbMasculino.Checked = true;
                }
                dtpFechaNacimiento.Value = paciente.FechaNacimiento;
                txtTelefono.Text = Convert.ToString(paciente.Telefono);
                cmbEstadoCivil.SelectedItem = paciente.estadocivil;

            }
            DesbloquearFormulario();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Paciente paciente = ObtenerPacienteFormulario();

            int index = lstPaciente.SelectedIndex;
            Paciente.EditarPaciente(index, paciente);

            MessageBox.Show("Paciente Modificado con Exito");

            ActualizarListaPacientes();
            LimpiarFormulario();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                Paciente paciente = (Paciente)lstPaciente.SelectedItem;
                if (paciente != null)
                {
                    Paciente.EliminarPaciente(paciente);
                    ActualizarListaPacientes();
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



        private void ActualizarListaPacientes()
        {
            lstPaciente.DataSource = null;
            lstPaciente.DataSource = Paciente.ObtenerPacientes();

        }

       


        

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            cmbEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivil));
            BloquearFormulario();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();

        }

        private void DesbloquearFormulario()
        {
            
            txtNombrePaciente.Enabled = true;
            txtApellidoPaciente.Enabled = true;
            rdbFemenino.Enabled = true;
            rdbMasculino.Enabled = true;
            txtEdad.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtTelefono.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            

        }

        private void BloquearFormulario()
        {
            
            txtNombrePaciente.Enabled = false;
            txtApellidoPaciente.Enabled = false;
            rdbFemenino.Enabled = false;
            rdbMasculino.Enabled = false;
            txtEdad.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtTelefono.Enabled = false;
            cmbEstadoCivil.Enabled = false;

        }

        private void lstPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellidoPaciente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo foramto Numero");
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo foramto Numero");
            }
        }
    }

 
}
