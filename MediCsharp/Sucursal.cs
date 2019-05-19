using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public struct Horario
    { public int Hora { get; set; }
      public int Minuto { get; set; }
    }

   public class Sucursal
    {
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
            listaSucursal.Add(s);
        }
        public static void EliminarSucursal(Sucursal s)
        {
            listaSucursal.Remove(s);
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
