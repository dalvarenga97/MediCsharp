using MediCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
   public  class Program
    {
        static void Main(string[] args)
        {

            Doctor d = new Doctor();
            d.CodDoctor = 101;
            d.NombreDoctor = "Alvaro";
            d.ApellidoDoctor = "Moreira";
            d.Especialidad = "Clinico";
            d.Matricula = "23.4546.1";
            d.DNI = 4446478;
            d.Direccion = "Saturio Rios 2482";
            d.Edad = 23;
            d.FechaNacimiento = "13/05/1992";

                     




        }
    }
}
