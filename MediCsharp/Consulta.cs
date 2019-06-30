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


        public string Diagnostico { get; set; }


        public List<ConsultaDetalle> Detalle_Consulta = new List<ConsultaDetalle>();

        public static List<Consulta> listaConsulta = new List<Consulta>();

       

        public static void AgregarConsulta(Consulta c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Consulta (paciente, Diagnostico)  output INSERTED.Id VALUES ( @paciente, @Diagnostico)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@paciente", c.paciente.Id);
                SqlParameter p2 = new SqlParameter("@Diagnostico", c.Diagnostico);


                p1.SqlDbType = SqlDbType.Int;
                p2.SqlDbType = SqlDbType.VarChar;


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);



                int Consulta_Id = (int)cmd.ExecuteScalar();

                foreach (ConsultaDetalle cd in c.Detalle_Consulta)
                {
                    string textoCmd2 = @"insert into Detalle_Consulta (Consulta_Id, doctor, FechaConsulta )  VALUES (@Id, @doctor, @FechaConsulta)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);
                    SqlParameter p3 = new SqlParameter("@Id", Consulta_Id);                 
                    SqlParameter p4 = new SqlParameter("@doctor", cd.doctor.Id);
                   
                    SqlParameter p5 = new SqlParameter("@FechaConsulta", cd.FechaConsulta);
                    

                    p3.SqlDbType = SqlDbType.Int;
                    p4.SqlDbType = SqlDbType.Int;
                    p5.SqlDbType = SqlDbType.DateTime;
                 
                    cmd2.Parameters.Add(p3);
                    cmd2.Parameters.Add(p4);
                    cmd2.Parameters.Add(p5);
                    
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
                    consulta= new Consulta();
                    
                                       
                    listaConsulta.Add(consulta);
                }
            }
            return listaConsulta;
        }
    }

       

    }



