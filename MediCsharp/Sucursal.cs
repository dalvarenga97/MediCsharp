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
        public String NombreSucursal { get; set; }
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
                string textoCmd = @"INSERT INTO Sucursal (NroSucursal, Nombre_Sucursal, Direccion varchar, Cantidad_Pisos, HorarioInicioVisitas, HorarioFinVisitas) VALUES (@NumeroSucursal, @NombreSucursal, @Direccion, @CantidadPisos, @HorarioInicioVisitas, @HorarioFinVisitas)";
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
                string textoCmd = @"delete from Sucursal where NroSucursal = @NumeroSucursal";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = s.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }

        }
        public static List<Sucursal> ObtenerSucursal()
        {
            return listaSucursal;
        }
        public override string ToString()
        {
            return this.NombreSucursal;
        }


    }
}
