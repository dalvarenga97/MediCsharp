using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    public enum TipoUrgencia { Critico, Grave, Leve }
    public class Consulta
    {

        public Paciente paciente { get; set; }
        public Doctor doctor { get; set; }
        public DateTime FechaConsulta { get; set; }

        public string Diagnostico { get; set; }

        public List<ConsultaDetalle> detalle_consulta = new List<ConsultaDetalle>();

        public static List<Consulta> listaConsulta = new List<Consulta>();


        public static void Agregar(Consulta c)
        {
           

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Consulta (paciente) output INSERTED.Id VALUES (@paciente)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@paciente", c.paciente.Id);


                p1.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);



                int consulta_id = (int)cmd.ExecuteScalar();

                foreach (ConsultaDetalle pd in c.detalle_consulta)
                {
                    string textoCmd2 = @"insert into consulta_detalle (consulta_id, Diagnostico, doctor, FechaConsulta, Sucursal, tipourgencia) VALUES (@id, @Diagnostico, @doctor, @FechaConsulta, @Sucursal, @tipourgencia)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);

                    SqlParameter p3 = new SqlParameter("@id", consulta_id);
                    SqlParameter p4 = new SqlParameter("@Diagnostico", pd.Diagnostico);
                    SqlParameter p5 = new SqlParameter("@doctor", pd.doctor.Id);
                    SqlParameter p6 = new SqlParameter("@FechaConsulta", pd.FechaConsulta);
                    SqlParameter p7 = new SqlParameter("@Sucursal", pd.Sucursal.Id);
                    SqlParameter p8 = new SqlParameter("@tipourgencia", pd.tipourgencia);

                    p3.SqlDbType = SqlDbType.Int;
                    p4.SqlDbType = SqlDbType.VarChar;
                    p5.SqlDbType = SqlDbType.Int;
                    p6.SqlDbType = SqlDbType.DateTime;
                    p7.SqlDbType = SqlDbType.Int;
                    p8.SqlDbType = SqlDbType.Int;
                    cmd2.Parameters.Add(p3);
                    cmd2.Parameters.Add(p4);
                    cmd2.Parameters.Add(p5);
                    cmd2.Parameters.Add(p6);
                    cmd2.Parameters.Add(p7);
                    cmd2.Parameters.Add(p8);

                    cmd2.ExecuteNonQuery();
                }



            }
        }
        public static void Eliminar(Consulta c)
        {
            listaConsulta.Remove(c);
        }

        public static List<Consulta> Obtener()
        {
            return listaConsulta;
        }

        public override string ToString()
        {
            return this.paciente.NombrePaciente;
        }

        private void ActualizarDataGrid()
        {

        }

        private void Limpiar()
        {

        }



        public static DataTable ObtenerConsultasPendientes()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT CD.id, P.NombrePaciente, D.NombreDoctor, CD.FechaConsuLTA, CD.Diagnostico FROM CONSULTA_DETALLE CD JOIN        Consulta C   ON C.Id = CD.consulta_id JOIN  Paciente P  ON C.paciente = p.Id  JOIN  Doctor D  ON D.Id = CD.doctor  where CD.recibido = 0";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }

        }


        public static void ConfirmarConsultas(List<int> listaIds)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                foreach (int id in listaIds)
                {
                    string textoCmd = @"UPDATE Consulta_Detalle SET recibido = 1 where id = @id";
                    SqlCommand cmd = new SqlCommand(textoCmd, con);
                    SqlParameter p1 = new SqlParameter("@id", id);
                    p1.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(p1);
                    cmd.ExecuteNonQuery();
                }

            }
        }

       




        public static List<Consulta> ObtenerConsultas()
        {
            //return listaProveedores;
            Consulta consulta;
            Consulta.listaConsulta.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Consulta";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    consulta = new Consulta();
                    consulta.paciente = Paciente.ObtenerPaciente(elLectorDeDatos.GetInt32(0));
                    consulta.doctor =Doctor.ObtenerDoctor(elLectorDeDatos.GetInt32(1));
                    consulta.FechaConsulta = elLectorDeDatos.GetDateTime(2);
                    consulta.Diagnostico = elLectorDeDatos.GetString(3);
                    listaConsulta.Add(consulta);
                }
            }
            return listaConsulta;
        }
    }


}

       

    



