using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MediCsharp
{
    public enum DiaSemana {Lunes, Martes, Miercoles, Jueves,  Viernes, Sabado, Domingo }
    public class Doctor
    {
        public int Matricula { get; set; }
        public string NombreDoctor { get; set; }
        public String ApellidoDoctor { get; set; }
        public string Especialidad { get; set; }
        public String Sexo { get; set; }
        public string Edad { get; set; }
        public String FechaNacimiento { get; set; }
        public int Telefono { get; set; }

        public DiaSemana GuardiaMedico { get; set; }


        public Doctor()
        { }
       

        

              

        public void ActualizarDatosDoctor()
        { }


    }
}
