using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED_Nomina.DTOs
{
    public class EmpleadoDTO
    {
        public int id { get; set; }
        public string documento { get; set; }
        public int tipo_doc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string titulo { get; set; }
        public float salario_basico { get; set; }
        public float salario_hora { get; set; }
        public string area { get; set; }
    }
}
