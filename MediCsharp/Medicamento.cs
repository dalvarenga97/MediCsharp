using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    public enum Origen { Paraguay, Brasil, Argentina, EEUU, China, Suecia, Mexico, Rusia }
    public enum TipoMedicamento {jarabe,pastillas,inyectables }
    public class Medicamento
    {
        public int Id { get; set; }
        public string NombreMedicamento { get; set; }

        public string DescripcionMedicamento { get; set; }
        public Origen origen { get; set; }
        
        public string ObservacionMedicamento { get; set; }

        public TipoMedicamento tipomedicamento { get; set; }
        

        public static List<Medicamento> listaMedicamento = new List<Medicamento>();

        public static void AgregarMedicamento(Medicamento m)
        {
            // listaMedicamento.Add(m);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Medicamento (NombreMedicamento, DescripcionMedicamento,origen,ObservacionMedicamento,tipomedicamento) VALUES (@NombreMedicamento, @DescripcionMedicamento, @origen, @ObservacionMedicamento, @tipomedicamento)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = m.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            SqlParameter p1 = new SqlParameter("@NombreMedicamento", this.NombreMedicamento);
            SqlParameter p2 = new SqlParameter("@DescripcionMedicamento", this.DescripcionMedicamento);
            SqlParameter p3 = new SqlParameter("@origen", this.origen);
            SqlParameter p4 = new SqlParameter("@ObservacionMedicamento", this.ObservacionMedicamento);
            SqlParameter p5 = new SqlParameter("@tipomedicamento", this.tipomedicamento);
            
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.Int;          
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            

            if (Id == true) cmd = ObtenerParametroId(cmd);

            return cmd;

        }
        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p6 = new SqlParameter("@Id", this.Id);
            p6.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p6);
            return cmd;
        }
        public static void EliminarMedicamento(Medicamento m)
        {
            //listaMedicamento.Remove(m);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Medicamento where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = m.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarMedicamento(int index, Medicamento m)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Medicamento SET NombreMedicamento = @NombreMedicamento, DescripcionMedicamento = @DescripcionMedicamento, origen = @origen ,ObservacionMedicamento = @ObservacionMedicamento,tipomedicamento = @tipomedicamento where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = m.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }
        public static List<Medicamento> ObtenerMedicamento()
        {
            // return listaMedicamento;
            Medicamento medicamento;
            listaMedicamento.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();
                    string textoCmd = "select * from Medicamento";
                     SqlCommand cmd = new SqlCommand(textoCmd, con);

                     SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                 while (elLectorDeDatos.Read())
                      {
                        medicamento = new Medicamento();
                        medicamento.Id = elLectorDeDatos.GetInt32(0);
                        medicamento.NombreMedicamento = elLectorDeDatos.GetString(1);
                        medicamento.DescripcionMedicamento = elLectorDeDatos.GetString(2);
                        medicamento.origen = (Origen)elLectorDeDatos.GetInt32(3);
                        medicamento.ObservacionMedicamento = elLectorDeDatos.GetString(4);
                        medicamento.tipomedicamento = (TipoMedicamento)elLectorDeDatos.GetInt32(5);



                              listaMedicamento.Add(medicamento);

                          }
                     }
                          return listaMedicamento;
                     }
        public override string ToString()
        {
            return this.NombreMedicamento;
        }

        
    }
}
