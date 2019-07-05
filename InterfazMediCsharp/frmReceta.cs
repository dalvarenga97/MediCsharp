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
using System.Data.SqlClient;

namespace InterfazMediCsharp
{
    public partial class frmReceta : Form
    {

        Receta receta;
        public frmReceta()
        {
            InitializeComponent();
        }

        private void gpbMedicamento_Enter(object sender, EventArgs e)
        {

        }

        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            Receta rc = new Receta();
           
            rc.cantidad = Convert.ToInt16(txtCantidad.Text);
            rc.medicamento = (Medicamento)cmbMedicamento.SelectedItem;
            //receta.detalle_medicamento.Add(dm);
          // ActualizarDataGrid();
            //LimpiarReceta();
        }

        private void btnEliminarReceta_Click(object sender, EventArgs e)
        {
            DetalleReceta dtm = (DetalleReceta)dtgDetalleReceta.CurrentRow.DataBoundItem;
            if (dtm != null)
            {
               // consulta.detalle_medicamento.Remove(dtm);
            }
          //  ActualizarDataGrid();
           // LimpiarReceta();
        }

        private void dtgDetalleMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReceta_Load(object sender, EventArgs e)
        {
            cmbMedicamento.DataSource = Medicamento.ObtenerMedicamento();



            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                {
                    //SqlCommand cmd = new SqlCommand(@"select consulta_id from //Consulta_Detalle", con);
                    string sql = " select consulta_id from Consulta_Detalle";

                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable factura = new DataTable();
                    try
                    {
                        da.Fill(factura);
                        cmbConsulta.DataSource = factura;
                        cmbConsulta.DisplayMember = "consulta_id";
                        cmbConsulta.ValueMember = "consulta_id";

                    }
                    catch { throw new Exception("Error en el ID."); }

                }
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

