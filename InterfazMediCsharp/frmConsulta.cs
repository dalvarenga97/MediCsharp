﻿using MediCsharp;
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
            LimpiarForm();
        }



        private void frmConsulta_Load(object sender, EventArgs e)
        {


            dtgDetalleConsulta.AutoGenerateColumns = true;
           cmbNombreDoctor.DataSource = Doctor.ObtenerDoctores();
           cmbPaciente.DataSource = Paciente.ObtenerPacientes();
       



            consulta = new Consulta();
            ActualizarDataGrid();


          
            

        }

        

        private void ActualizarDataGrid()
        {
            dtgDetalleConsulta.DataSource = null;
            dtgDetalleConsulta.DataSource = consulta.detalle_consulta;

        }
        private void Limpiar()
        {
            txtDiagnostico.Text = "0";
            cmbPaciente.SelectedItem = null;
            cmbNombreDoctor.SelectedItem = null;
            


        }

      
        public void LimpiarForm() {
            txtId.Text = "";
            cmbNombreDoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;            
            
            txtDiagnostico.Text = "";
            
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConsultaDetalle dd = (ConsultaDetalle)dtgDetalleConsulta.CurrentRow.DataBoundItem;
            if (dd != null)
            {
                consulta.detalle_consulta.Remove(dd);
            }
            ActualizarDataGrid();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgDetalleConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaDetalle dd = new ConsultaDetalle();
            dd.paciente = (Paciente)cmbPaciente.SelectedItem;
            dd.doctor = (Doctor)cmbNombreDoctor.SelectedItem;
            dd.Diagnostico = txtDiagnostico.Text;
            dd.FechaConsulta = dtpFechaConsulta.Value.Date;          
            consulta.detalle_consulta.Add(dd);
            ActualizarDataGrid();
            consulta.paciente = (Paciente)cmbPaciente.SelectedItem;
            consulta.doctor = (Doctor)cmbNombreDoctor.SelectedItem;
            Consulta.Agregar(consulta);
            MessageBox.Show("La Consulta ha sido guardado con éxito");
            Limpiar();
            dtgDetalleConsulta.DataSource = null;
            cmbPaciente.SelectedItem = null;
            cmbNombreDoctor.SelectedItem = null;


            consulta = new Consulta();

            Limpiar();
        }


    }







}
