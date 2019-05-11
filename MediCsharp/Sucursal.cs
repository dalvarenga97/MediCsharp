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
        public int NumeroSucursal { get; set; }
        public String NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public int CantidadPisos { get; set; }

        public Horario HorarioInicioVisitas { get; set; }
        public Horario HorarioFinVisitas { get; set; }

        public Sucursal()
        { }


        public void ActualizarDatosSucursal()
        { }



    }
}
