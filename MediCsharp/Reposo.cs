using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public class Reposo
    {
        public int CodReposo { get; set; }
        public int CodDoctor { get; set; }
        public string CodPaciente { get; set; }

        public DiaSemana DiaReposo { get; set; }

        public String Observaciones { get; set; }

        public Reposo()
        { }

        public void ActualizarDatosReposo()
        { }



    }
}
