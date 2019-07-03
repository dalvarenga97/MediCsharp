using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MediCsharp
{
    public class ConsultaDetalle
    {
        public Paciente paciente { get; set; }
        public Doctor doctor { get; set; }

        public DateTime FechaConsulta { get; set; }

        public string Diagnostico { get; set; }

        public Sucursal Sucursal { get; set; }        

        public TipoUrgencia tipourgencia { get; set; }



    }
}
