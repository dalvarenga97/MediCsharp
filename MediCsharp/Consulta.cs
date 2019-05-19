using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
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
        public string TipoUrgencia { get; set; }





        public List<DetalleMedicamento> detalle_medicamento = new List<DetalleMedicamento>();

        public static List<Consulta> listaConsulta = new List<Consulta>();

        public static void Agregar(Consulta c)
        {
            listaConsulta.Add(c);
        }
        public static void Eliminar(Consulta c)
        {
            listaConsulta.Remove(c);
        }

        public static List<Consulta> Obtener()
        {
            return listaConsulta;
        }

        

    }
}
