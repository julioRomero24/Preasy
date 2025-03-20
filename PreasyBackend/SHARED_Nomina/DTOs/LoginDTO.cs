using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED_Nomina.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Error, Usuario no Ingresado")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Error, Contraseña no Ingresado")]
        public string Password { get; set; }
    }
}
