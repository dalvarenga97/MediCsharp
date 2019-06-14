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
            //int contador = 0;

            // Paciente paciente = ObtenerPacienteFormulario();

            // Paciente.AgregarPaciente(paciente);


            //            LimpiarFormulario();
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
            paciente.CIPaciente = txtCI.Text;
            paciente.NombrePaciente = txtNombre.Text;
            paciente.ApellidoPaciente = txtApellido.Text;
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
            txtCI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
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
                txtCI.Text = paciente.CIPaciente;
                txtNombre.Text = paciente.NombrePaciente;
                txtApellido.Text = paciente.ApellidoPaciente;
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



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;

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
            lstPaciente.DataSource = Paciente.ObtenerPaciente();

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
            txtCI.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            rdbFemenino.Enabled = true;
            rdbMasculino.Enabled = true;
            txtEdad.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtTelefono.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            

        }

        private void BloquearFormulario()
        {
            txtCI.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            rdbFemenino.Enabled = false;
            rdbMasculino.Enabled = false;
            txtEdad.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtTelefono.Enabled = false;
            cmbEstadoCivil.Enabled = false;

        }

    }
}
