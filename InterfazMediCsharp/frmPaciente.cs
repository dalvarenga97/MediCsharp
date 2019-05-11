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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente pac = new Paciente();
            pac.CIPaciente = txtCI.Text; // Preguntarle al profesor por que al poner en int da error en la clase paciente
            pac.NombrePaciente = txtNombre.Text;
            pac.ApellidoPaciente = txtApellido.Text;
            pac.Edad = txtEdad.Text; // este tambien es entero
             

        }

        
    }
}
