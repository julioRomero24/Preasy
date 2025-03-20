using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED_Nomina.DTOs
{
    public class UsuariosDTO
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public bool estado { get; set; }
        public int empleado { get; set; }
        public int perfil { get; set; }
    }
}
