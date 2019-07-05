using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
   public  class Receta
    {

        public Paciente paciente { get; set; }
        public Medicamento medicamento { get; set; }

        public string cantidad { get; set; }


        public List<DetalleReceta> detalle_receta = new List <DetalleReceta> ();

        public static List<Receta> listareceta = new List<Receta>();




        public static void Agregar(Receta r)
        {

            // listaDelivery.Add(d);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Receta (paciente) output INSERTED.id VALUES (@paciente)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@paciente", r.paciente.Id);


                p1.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
           


                int receta_id = (int)cmd.ExecuteScalar();

                foreach (DetalleReceta pd in r.detalle_receta)
                {
                    string textoCmd2 = @"insert into receta_detalle (receta_id, cantidad, medicamento) VALUES (@id, @cantidad ,@medicamento)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);

                    SqlParameter p3 = new SqlParameter("@id", receta_id);
                    SqlParameter p4 = new SqlParameter("@cantidad", r.cantidad);
                    SqlParameter p5 = new SqlParameter("@medicamento", r.medicamento.Id);
                    

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



            

        public static void Eliminar(Receta r)
        {
            listareceta.Remove(r);
        }

        public static List<Receta> Obtener()
        {
            return listareceta;
        }


        public override string ToString()
        {
            return this.paciente.NombrePaciente;
        }
    }
    }
    

        

    

