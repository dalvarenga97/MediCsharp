using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    public class DetalleMedicamento
    {
        public Medicamento NombreMedicamento { get; set; }
        public Consulta NumeroConsulta { get; set; }
        public Int16 Cantidad { get; set; }

        public static List<DetalleMedicamento> listaDetalleMedicamento = new List<DetalleMedicamento>();

        public static void AgregarConsulta(Consulta c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Consulta (NombreMedicamento, NumeroConsulta, Cantidad) VALUES (@Codigo)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd.ExecuteNonQuery();
            }


        }
    }
}