using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public class DetalleReposo
    {
        public Paciente paciente { get; set; }
        public Doctor doctor { get; set; }

        public string cantidad { get; set; }

    }
}
