﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    //public struct Horario
    //{ public int Hora { get; set; }
    //  public int Minuto { get; set; }
    //}

   public class Sucursal
    {
        public int Id { get; set; }
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public Int32 CantidadPisos { get; set; }

        //public DateTime HorarioInicioVisitas { get; set; }
        //public DateTime HorarioFinVisitas { get; set; }

        //public Sucursal()
        //{ }


        //public void ActualizarDatosSucursal()
        //{ }

        public static List<Sucursal> listaSucursales = new List<Sucursal>();

        public static void AgregarSucursal(Sucursal s)
        {
            //listaSucursal.Add(s);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Sucursal (NombreSucursal, Direccion, CantidadPisos) VALUES (@NombreSucursal, @Direccion, @CantidadPisos)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = s.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();
            }

        }
        public static void EliminarSucursal(Sucursal s)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Sucursal where Id = @Id";

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
                string textoCmd = @"UPDATE Sucursal SET NombreSucursal = @NombreSucursal, Direccion = @Direccion , CantidadPisos = @CantidadPisos where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = s.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }


        public static List<Sucursal> ObtenerSucursal()
        {
            //return listaSucursal;
            Sucursal sucursal;
            listaSucursales.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();
                string textoCmd = "Select * from Sucursal";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    sucursal = new Sucursal();
                    sucursal.Id = elLectorDeDatos.GetInt32(0);
                    sucursal.NombreSucursal = elLectorDeDatos.GetString(1);
                    sucursal.Direccion = elLectorDeDatos.GetString(2);
                    sucursal.CantidadPisos = elLectorDeDatos.GetInt32(3);



                    listaSucursales.Add(sucursal);

                }
            }
            return listaSucursales;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            SqlParameter p1 = new SqlParameter("@NombreSucursal", this.NombreSucursal);
            SqlParameter p2 = new SqlParameter("@Direccion", this.Direccion);
            SqlParameter p3 = new SqlParameter("@CantidadPisos", this.CantidadPisos);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);


            if (Id == true) cmd = ObtenerParametroId(cmd);

            return cmd;

        }



        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p4 = new SqlParameter("@Id", this.Id);
            p4.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p4);
            return cmd;
        }
        

        public override string ToString()
        {
            return this.NombreSucursal;
        }


    }
}
