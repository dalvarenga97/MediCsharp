using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public enum Sexo { Femenino, Masculino }
    public class Paciente
    {
        public string CIPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public Sexo sexo { get; set; }
        public Int16 Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Int32 Telefono { get; set; }

        public string estadocivil { get; set; }

        public static List<Paciente> listaPacientes = new List<Paciente>();

        public static void AgregarPaciente(Paciente p)
        {
            listaPacientes.Add(p);
        }
        public static void EliminarPaciente(Paciente p)
        {
            listaPacientes.Remove(p);
        }
        public static List<Paciente> ObtenerPaciente()
        {
            return listaPacientes;
        }
        public override string ToString()
        {
            return this.NombrePaciente;
        }





    }
}
