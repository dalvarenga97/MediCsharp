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
        public frmPaciente()
        {
            InitializeComponent();
            LimpiarFormulario();
            ActualizarListaPacientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = ObtenerPacienteFormulario();

            Paciente.AgregarPaciente(paciente);

            ActualizarListaPacientes();

            LimpiarFormulario();


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
            paciente.estadocivil = txtEstadoCivil.Text;

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
            txtEstadoCivil.Text = "";
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
                txtEstadoCivil.Text = paciente.estadocivil;
                
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstPaciente.SelectedIndex;
            Paciente.listaPacientes[index] = ObtenerPacienteFormulario();
            MessageBox.Show ("Paciente Modificado con Exito");
            ActualizarListaPacientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;
            Paciente.EliminarPaciente(paciente);
            ActualizarListaPacientes();
            LimpiarFormulario();
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
