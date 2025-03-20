using API_Nomina.Services;
using API_Nomina.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : Controller
    {
        private readonly IUsuarioService usuariosServices;
        public LoginController(IUsuarioService _usuarioService)
        {
            usuariosServices = _usuarioService;
        }

        [HttpPost]
        public IActionResult Login(LoginDTO dto)
        {
            Respuesta rpta = new Respuesta();
            try
            {
                rpta = usuariosServices.Login(dto);
                if (rpta.Exito == 0)
                {
                    return BadRequest(rpta);
                }
                return Ok(rpta);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
                return BadRequest(ex.Message);
            }

        }

        


    }
}
