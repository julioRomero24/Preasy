using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED_Nomina.Response
{
    public class Respuesta
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public Object Data { get; set; }
        public Respuesta()
        {
            Exito = 0;
        }
    }
}
