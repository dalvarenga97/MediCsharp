using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
   public  class ConsultaDetalle
    {
        public Paciente paciente { get; set; }
       
        public Doctor doctor { get; set; }
        public DateTime FechaConsulta { get; set; }



    }
}
