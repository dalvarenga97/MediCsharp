using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public class Reposo
    {
        public int Id { get; set; }
        public Doctor doctor { get; set; }
        public Paciente paciente { get; set; }
        public int CantidadDias { get; set; }
        

        public static List<Reposo> listaReposo = new List<Reposo>();

        public static void AgregarReposo(Reposo r)
        {
            //listaReposo.Add(r);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Reposo (Doctor, Paciente, CantidadDias) VALUES (@Doctor, @Paciente, @CantidadDias)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
               // cmd = r.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarReposo(Reposo r)
        {
            //listaReposo.Remove(r);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Reposo where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
               // cmd = r.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }
        public static List<Reposo>ObtenerReposo()
        {
            //return listaReposo;

            Reposo reposo;
            listaReposo.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "select * from Reposo";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    reposo = new Reposo();
                    reposo.Id = elLectorDeDatos.GetInt32(0);
                    reposo.doctor = Doctor.ObtenerDoctor(elLectorDeDatos.GetInt32(1));
                    reposo.paciente = Paciente.ObtenerPaciente(elLectorDeDatos.GetInt32(2));
                    reposo.CantidadDias = elLectorDeDatos.GetInt32(3);
                    

                    listaReposo.Add(reposo);

                }
                return listaReposo;
            }
        }

        public override string ToString()
        {
            return this.Id + " " + paciente;
        }



    }
}
