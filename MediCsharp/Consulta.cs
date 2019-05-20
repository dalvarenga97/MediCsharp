using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public enum TipoUrgencia {Critico, Grave, Leve}
    public class Consulta
    {
        public Int64 NumeroConsulta { get; set; }
        public Doctor NombreDoctor { get; set; }
        public Paciente CIPaciente { get; set; }

        public string NombrePaciente { get; set; }
        public DateTime HoraInicioConsulta { get; set; }
        public DateTime HoraFinConsulta { get; set; }

        public Sucursal Sucursal { get; set; }

        public String Medicamento { get; set; }
        
        public String Diagnostico { get; set; }
        public TipoUrgencia TipoUrgencia { get; set; }

        public List<DetalleMedicamento> detalle_medicamento = new List<DetalleMedicamento>();

        public static List<Consulta> listaConsulta = new List<Consulta>();

        public static void AgregarConsulta(Consulta c)
        {
            listaConsulta.Add(c);
        }
        public static void EliminarConsulta(Consulta c)
        {
            listaConsulta.Remove(c);
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
