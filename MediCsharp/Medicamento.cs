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
        public Int64 CodigoMedicamento { get; set; }
        public string NombreMedicamento { get; set; }

        public string DescripcionMedicamento { get; set; }
        public string Origen { get; set; }
        
        public string ObservacionMedicamento { get; set; }

        public TipoMedicamento tipomedicamento { get; set; }
        

        public static List<Medicamento> listaMedicamento = new List<Medicamento>();

        public static void AgregarMedicamento(Medicamento m)
        {
            listaMedicamento.Add(m);
        }
        public static void EliminarMedicamento(Medicamento m)
        {
            listaMedicamento.Remove(m);
        }
        public static List<Medicamento> ObtenerMedicamento()
        {
            return listaMedicamento;
        }
        public override string ToString()
        {
            return this.NombreMedicamento;
        }

        
    }
}
