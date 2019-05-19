using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public class Reposo
    {
        public string CodigoReposo { get; set; }
        public Doctor NombreDoctor { get; set; }
        public Paciente NombrePaciente { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        public static List<Reposo> listaReposo = new List<Reposo>();

        public static void AgregarReposo(Reposo r)
        {
            listaReposo.Add(r);
        }
        public static void EliminarReposo(Reposo r)
        {
            listaReposo.Remove(r);
        }
        public static List<Reposo>ObtenerReposo()
        {
            return listaReposo;
        }
        public override string ToString()
        {
            return this.CodigoReposo + " " + NombrePaciente;
        }



    }
}
