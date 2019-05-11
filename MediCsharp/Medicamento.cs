using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{

    public enum TipoMedicamento {jarabe,pastillas,inyectables }
    public class Medicamento
    {
        public int CodigoMedicamento { get; set; }
        public string NombreMedicamento { get; set; }

        public string DescripcionMedicamento { get; set; }
        public string Origen { get; set; }
        public int CantidadMedicamento { get; set; }
        public string ObservacionMedicamento { get; set; }

        public TipoMedicamento tipomedicamento { get; set; }

        

        public Medicamento()
        { }

        public void  ActualizarMedicamento()
        { }




    }
}
