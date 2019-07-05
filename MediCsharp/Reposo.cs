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
        public string cantidad { get; set; }

        public List<DetalleReposo> detalle_reposo = new List<DetalleReposo>();
        public static List<Reposo> listaReposo = new List<Reposo>();
        

        
        public static void Agregar(Reposo r)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Reposo (paciente) output INSERTED.id VALUES (@paciente)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@paciente", r.paciente.Id);


                p1.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);



                int reposo_id = (int)cmd.ExecuteScalar();

                foreach (DetalleReposo pd in r.detalle_reposo)
                {
                    string textoCmd2 = @"insert into reposo_detalle (reposo_id, cantidad, doctor) VALUES (@id, @cantidad , @doctor)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);

                    SqlParameter p3 = new SqlParameter("@id", reposo_id);
                    SqlParameter p4 = new SqlParameter("@cantidad", r.cantidad);
                    SqlParameter p5 = new SqlParameter("@doctor", r.doctor.Id);


                    p3.SqlDbType = SqlDbType.Int;
                    p4.SqlDbType = SqlDbType.VarChar;
                    p5.SqlDbType = SqlDbType.Int;
                    cmd2.Parameters.Add(p3);
                    cmd2.Parameters.Add(p4);
                    cmd2.Parameters.Add(p5);

                    cmd2.ExecuteNonQuery();
                }
            }
        }
        public static void EliminarReposo(Reposo r)
        {
            listaReposo.Remove(r);
        }
        public static List<Reposo>ObtenerReposo()
        {
            return listaReposo;
        }

        public override string ToString()
        {
            return this.paciente.NombrePaciente;
        }



    }
}
