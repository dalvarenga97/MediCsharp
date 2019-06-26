using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    public enum TipoUrgencia {Critico, Grave, Leve}
    public class Consulta
    {
        public Int32 NumeroConsulta { get; set; }
        public Doctor NombreDoctor { get; set; }
        public Paciente CIPaciente { get; set; }

        public string NombrePaciente { get; set; }
        
        public Sucursal Sucursal { get; set; }

        public String Medicamento { get; set; }
        
        public String Diagnostico { get; set; }
        public TipoUrgencia TipoUrgencia { get; set; }

        public List<DetalleMedicamento> detalle_medicamento = new List<DetalleMedicamento>();

        public static List<Consulta> listaConsulta = new List<Consulta>();

        public static void AgregarConsulta(Consulta c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Consulta (Doctor, Paciente, Hora_Inicio_Consulta, Hora_Fin_Consulta, NroSucursal, Diagnostico, Tipo_Urgencia) VALUES (@Doctor, @Paciente, @HoraInicioConsulta, @HoraFinConsulta, @NumeroSucursal, @NumeroMedicamento)"; // DEJO CONSULTA PARA DESPUES
                SqlCommand cmd = new SqlCommand(textoCmd, con);            // AL LLAMAR A DOCTOR, PACIENTE Y MEDICAMENTO
                //cmd = c.ObtenerParametros(cmd);                            // Medicamento no seiria llamar a Detallemedic
                cmd.ExecuteNonQuery();
            }

        }


       /* private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
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

        }*/
        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p6 = new SqlParameter("@NroConsulta", this.NumeroConsulta);
            p6.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p6);
            return cmd;
        }
        
        
        public static void EliminarConsulta(Consulta c)
        {
            //listaConsulta.Remove(c);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"DELETE FROM Consulta WHERE NroConsulta = @NumeroConsulta";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Consulta> ObtenerConsulta()
        {
            return listaConsulta;
        }

        public override string ToString()
        {
            return this.NumeroConsulta + "      " + NombreDoctor + "      " + NombrePaciente;
        }


    }
}
