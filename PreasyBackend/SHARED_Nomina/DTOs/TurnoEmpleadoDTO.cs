using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED_Nomina.DTOs
{
    public class TurnoEmpleadoDTO
    {
        public int id { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_final { get; set; }
        public int turno { get; set; }
        public int empleado { get; set; }

    }
}
