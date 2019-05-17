using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public class Consulta
    {
        public int NumeroConsulta { get; set; }
        public string NombreDoctor { get; set; }
        public string CIPaciente { get; set; }

        public string NombrePaciente { get; set; }
        public Horario HoraInicioConsulta { get; set; }
        public Horario HoraFinConsulta { get; set; }

        public int Sucursal { get; set; }

        public String Medicamento { get; set; }
        
        public String Observaciones { get; set; }
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
