using API_Nomina.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using SHARED_Nomina.Response;

namespace API_Nomina.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UserController : Controller
    {
        private readonly IUsuarioService usuariosServices;

        public UserController(IUsuarioService _usuarioService)
        {
            usuariosServices = _usuarioService;
        }

        [HttpGet]
        public IActionResult Usuarios()
        {

            Respuesta rpta = new Respuesta();
            try
            {
                rpta = usuariosServices.ListUsuarios();
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
