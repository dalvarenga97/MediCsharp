using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public class Paciente: Persona
    {
        public string CIPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
                 
        public string estadocivil { get; set; }



        public Paciente()
        { }

        public Paciente(int CodPaciente, string NombrePersona, string ApellidoPersona)
        {
            this.CIPaciente = CIPaciente;
            this.NombrePaciente = NombrePaciente;
            this.ApellidoPaciente = ApellidoPaciente;

        }


        public void ActualizarDatosPaciente()
        { }


    }
}
