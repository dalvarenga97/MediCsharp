using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
   public  class Receta
    {
        public Medicamento medicamento { get; set; }
        public Int16 CantidadMedicamento { get; set; }

        public List<DetalleReceta> detalle_medicamento = new List<DetalleReceta>();

        

    }
}
