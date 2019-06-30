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
        public Medicamento NombreMedicamento { get; set; }

        public Consulta Id { get; set; }
       
        public Int16 Cantidad { get; set; }


    }
}