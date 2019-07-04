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
        string modo;
        public frmDoctor()
        {
            InitializeComponent();
            LimpiarFormulario();
            ActualizarListaDoctor();
        }

      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (modo == "I")
            //{
            //    Doctor doctor = ObtenerDoctorFormulario();

            //    Doctor.AgregarDoctor(doctor);


            //}
            //else if (modo == "E")
            //{
            //    int index = lstDoctor.SelectedIndex;

            //    Doctor doctor = ObtenerDoctorFormulario();
            //    Doctor.EditarDoctor(index, doctor);

            //}

            //ActualizarListaDoctor();
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

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Favor ingrese el apellido", "ADVERTENCIA");
                txtApellido.SelectAll();
                txtApellido.Focus();
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


            else
           if (modo == "I")
            {
                Doctor doctor = ObtenerDoctorFormulario();

                Doctor.AgregarDoctor(doctor);


            }
            else if (modo == "E")
            {
                int index = lstDoctor.SelectedIndex;

                Doctor doctor = ObtenerDoctorFormulario();
                Doctor.EditarDoctor(index, doctor);

            }

            ActualizarListaDoctor();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void ActualizarListaDoctor()
        {
            lstDoctor.DataSource = null;
            lstDoctor.DataSource = Doctor.ObtenerDoctores();

        }

        private Doctor ObtenerDoctorFormulario()
        {
            Doctor doctor = new Doctor();
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                doctor.Id = Convert.ToInt32(txtId.Text);
            }
            doctor.NombreDoctor = txtNombre.Text;
            doctor.ApellidoDoctor = txtApellido.Text;
            doctor.Edad = Convert.ToInt32(txtEdad.Text);
            doctor.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            doctor.especialidad = (Especialidad)cmbEspecialidad.SelectedItem;
            doctor.Telefono = txtTelefono.Text;
            doctor.DiasGuardia = clbDiasGuardia.CheckedItems.Cast<String>().ToList();
            if (doctor.sexo == Sexo.Femenino)
            {
                rdbFemenino.Checked = true;
            }
            else if (doctor.sexo == Sexo.Masculino)
            {
                rdbMasculino.Checked = true;
            }

            //preguntar al profe como hacer con los checkbox

            return doctor;
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            dtpFechaNacimiento.Value = System.DateTime.Now;
            cmbEspecialidad.SelectedItem = null;
            txtTelefono.Text = "";
            ResetearCheckedListBox();

        }

        private void lstDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            Doctor doctor = ObtenerDoctorFormulario();


            int index = lstDoctor.SelectedIndex;
            Doctor.EditarDoctor(index, doctor);

            MessageBox.Show("Doctor Modificado con Exito");

            ActualizarListaDoctor();
            LimpiarFormulario();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            // PRUEBA

            ActualizarListaDoctores();
            cmbEspecialidad.DataSource = Enum.GetValues(typeof(Especialidad));
            BloquearFormulario();
        }

        private void BloquearFormulario()
        {   
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            cmbEspecialidad.Enabled = false;
            txtTelefono.Enabled = false;
            rdbFemenino.Enabled = false;
            rdbMasculino.Enabled = false;            
            btnLimpiar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }

        private void DesbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEdad.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            cmbEspecialidad.Enabled = true;
            txtTelefono.Enabled = true;
            rdbFemenino.Enabled = true;
            rdbMasculino.Enabled = true;
            btnLimpiar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private void ActualizarListaDoctores()
        {
            lstDoctor.DataSource = null;
            lstDoctor.DataSource = Doctor.ObtenerDoctores();

        }
        private void lstDoctor_Click(object sender, EventArgs e)
        {

            Doctor doctor = (Doctor)lstDoctor.SelectedItem;

            if (doctor != null)
            {
                txtId.Text = Convert.ToString(doctor.Id);
                txtNombre.Text = doctor.NombreDoctor;
                txtApellido.Text = doctor.ApellidoDoctor;
                cmbEspecialidad.SelectedItem = (Especialidad)doctor.especialidad;
                if (doctor.sexo == Sexo.Femenino)
                {
                    rdbFemenino.Checked = true;
                }
                else if (doctor.sexo == Sexo.Masculino)
                {
                    rdbMasculino.Checked = true;
                }
                txtEdad.Text = Convert.ToString(doctor.Edad);
                dtpFechaNacimiento.Value = doctor.FechaNacimiento;
                txtTelefono.Text = Convert.ToString(doctor.Telefono);
                ResetearCheckedListBox();
                foreach (string dia in doctor.DiasGuardia)
                {
                    if (dia == "L") clbDiasGuardia.SetItemChecked(0, true);
                    else if (dia == "M") clbDiasGuardia.SetItemChecked(1, true);
                    else if (dia == "X") clbDiasGuardia.SetItemChecked(2, true);
                    else if (dia == "J") clbDiasGuardia.SetItemChecked(3, true);
                    else if (dia == "V") clbDiasGuardia.SetItemChecked(4, true);
                    else if (dia == "S") clbDiasGuardia.SetItemChecked(5, true);
                    else if (dia == "D") clbDiasGuardia.SetItemChecked(6, true);


                }
                if (true)
                {

                }

                DesbloquearFormulario();
            }



        }

        private void ResetearCheckedListBox()
        {
            clbDiasGuardia.SetItemChecked(0, false);
            clbDiasGuardia.SetItemChecked(1, false);
            clbDiasGuardia.SetItemChecked(2, false);
            clbDiasGuardia.SetItemChecked(3, false);
            clbDiasGuardia.SetItemChecked(4, false);
            clbDiasGuardia.SetItemChecked(5, false);
            clbDiasGuardia.SetItemChecked(6, false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }
    }
}
