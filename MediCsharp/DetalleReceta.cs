using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    public class DetalleReceta
    {
        public Medicamento medicamento { get; set; }

        public Paciente paciente { get; set; }




        public string cantidad { get; set; }


    }
}