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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
            LimpiarFormulario();
            ActualizarListaDoctor();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Doctor doctor = ObtenerDoctorFormulario();

            Doctor.AgregarDoctor(doctor);

            ActualizarListaDoctor();

            LimpiarFormulario();
        }

        private void ActualizarListaDoctor()
        {
            lstDoctor.DataSource = null;
            lstDoctor.DataSource = Doctor.ObtenerDoctor();

        }

        private Doctor ObtenerDoctorFormulario()
        {
            Doctor doctor = new Doctor();
            doctor.Matricula = txtMatricula.Text;
            doctor.NombreDoctor = txtNombre.Text;
            doctor.ApellidoDoctor = txtApellido.Text;
            doctor.Edad = txtEdad.Text;
            doctor.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            doctor.Especialidad = txtEspecialidad.Text;
            doctor.Telefono = Convert.ToInt64(txtTelefono.Text);
            doctor.GuardiaMedico = txtGuardiaMedico.Text;

            //preguntar al profe como hacer con los checkbox

            return doctor;
        }

        private void LimpiarFormulario()
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            dtpFechaNacimiento.Value = System.DateTime.Now;
            txtEspecialidad.Text = "";
            txtTelefono.Text = "";
            txtGuardiaMedico.Text = "";

        }

        private void lstDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor doctor = (Doctor)lstDoctor.SelectedItem;

            if (doctor != null)
            {
                txtMatricula.Text = doctor.Matricula;
                txtNombre.Text = doctor.NombreDoctor;
                txtApellido.Text = doctor.ApellidoDoctor;
                txtEdad.Text = doctor.Edad;
                dtpFechaNacimiento.Value = doctor.FechaNacimiento;
                txtEspecialidad.Text = doctor.Especialidad;
                txtTelefono.Text = Convert.ToString(doctor.Telefono);
                txtGuardiaMedico.Text = doctor.GuardiaMedico;
            }

          }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Doctor doctor = (Doctor)lstDoctor.SelectedItem;
            Doctor.EliminarDoctor(doctor);
            ActualizarListaDoctor();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstDoctor.SelectedIndex;
            Doctor.listaDoctor[index] = ObtenerDoctorFormulario();
            MessageBox.Show("Doctor Modificado con Exito");
            ActualizarListaDoctor();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
