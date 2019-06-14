using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//testing
//Prueba

namespace MediCsharp
{
    public enum DiaSemana {Lunes, Martes, Miercoles, Jueves,  Viernes, Sabado, Domingo }
    public enum Especialida { Clinico, Pediatra, Ginecologo, Dentista, Mastologo, Dermatologo, Oculista, Fonoaudiologo, Psicologo }
    public class Doctor
    {
        public string Matricula { get; set; }
        public string NombreDoctor { get; set; }
        public String ApellidoDoctor { get; set; }
        public string Especialidad { get; set; }
        public String Sexo { get; set; }
        public string Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Int64 Telefono { get; set; }

        public string GuardiaMedico { get; set; }


        public static List<Doctor> listaDoctor = new List<Doctor>();

        public static void AgregarDoctor(Doctor d)
        {
            listaDoctor.Add(d);
        }
        public static void EliminarDoctor(Doctor d)
        {
            listaDoctor.Remove(d);
        }
        public static List<Doctor> ObtenerDoctor()
        {
            return listaDoctor;
        }
        public override string ToString()
        {
            return this.NombreDoctor + " " + ApellidoDoctor;
        }


    }
}
