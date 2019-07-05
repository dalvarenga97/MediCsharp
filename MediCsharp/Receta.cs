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

        public Int16 consulta_id { get; set; }
        public Medicamento medicamento { get; set; }
        public Int16 cantidad { get; set; }

        public List<Receta> receta = new List<Receta>();

        public List<DetalleReceta> detalle_medicamento = new List<DetalleReceta>();

        


        public static void Agregar(Receta r)
        {
            //listaPedidos.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Receta (consulta_id, medicamento, cantidad) VALUES (@consulta_id, @medicamento, @cantidad)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@consulta_id", r.consulta_id);
                SqlParameter p2 = new SqlParameter("@medicamento", r.medicamento.Id);
                SqlParameter p3 = new SqlParameter("@cantidad", r.cantidad);
                p1.SqlDbType = SqlDbType.Int;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                
                    cmd.ExecuteNonQuery();
                }



            }



        }
    }
    

        

    

