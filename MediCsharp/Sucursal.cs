using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    public struct Horario
    { public int Hora { get; set; }
      public int Minuto { get; set; }
    }

   public class Sucursal
    {
        //public int Id { get; set; }               No se necesita, se usa el numero de sucursal(?)
        public Int64 NumeroSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public Int64 CantidadPisos { get; set; }

        public DateTime HorarioInicioVisitas { get; set; }
        public DateTime HorarioFinVisitas { get; set; }

        public Sucursal()
        { }


        public void ActualizarDatosSucursal()
        { }

        public static List<Sucursal> listaSucursal = new List<Sucursal>();

        public static void AgregarSucursal(Sucursal s)
        {
            //listaSucursal.Add(s);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Sucursal (NroSucursal, Nombre_Sucursal, Direccion, Cantidad_Pisos, HorarioInicioVisitas, HorarioFinVisitas) VALUES (@NumeroSucursal, @NombreSucursal, @Direccion, @CantidadPisos, @HorarioInicioVisitas, @HorarioFinVisitas)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = s.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();
            }

        }
        public static void EliminarSucursal(Sucursal s)
        {
            //listaSucursal.Remove(s);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"DELETE FROM Sucursal WHERE NroSucursal = @NumeroSucursal";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = s.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }

        }

        public static void EditarSucursal(int index, Sucursal s)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Sucursal SET Nombre_Sucursal = @NombreSucursal, Direccion = @Direccion ,Cantidad_Pisos = @CantidadPisos, HorarioInicioVisitas = @HorarioInicioVisitas, HorarioFinVisitas = @HorarioFinVisitas WHERE NroSucursal = @NumeroSucursal";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = s.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            SqlParameter p1 = new SqlParameter("@Nombre_Sucursal", this.NombreSucursal);
            SqlParameter p2 = new SqlParameter("@Direccion", this.Direccion);
            SqlParameter p3 = new SqlParameter("@Cantidad_Pisos", this.CantidadPisos);
            SqlParameter p4 = new SqlParameter("@HorarioInicioVisitas", this.HorarioInicioVisitas);
            SqlParameter p5 = new SqlParameter("@HorarioFinVisitas", this.HorarioFinVisitas);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.DateTime;
            p5.SqlDbType = SqlDbType.DateTime;
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
            SqlParameter p6 = new SqlParameter("@NroSucursal", this.NumeroSucursal);
            p6.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p6);
            return cmd;
        }


        public static List<Sucursal> ObtenerSucursal()
        {
            //return listaSucursal;
            Sucursal sucursal;
            listaSucursal.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();
                string textoCmd = "SELECT * FROM Scursal";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    sucursal = new Sucursal();
                    sucursal.NumeroSucursal = elLectorDeDatos.GetInt64(0);
                    sucursal.NombreSucursal = elLectorDeDatos.GetString(1);
                    sucursal.Direccion = elLectorDeDatos.GetString(2);
                    sucursal.CantidadPisos = elLectorDeDatos.GetInt32(3);
                    sucursal.HorarioInicioVisitas = elLectorDeDatos.GetDateTime(4);
                    sucursal.HorarioFinVisitas = elLectorDeDatos.GetDateTime(5);



                    listaSucursal.Add(sucursal);

                }
            }
            return listaSucursal;
        }
    
        public override string ToString()
        {
            return this.NombreSucursal;
        }


    }
}
