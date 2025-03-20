using API_Nomina.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using SHARED_Nomina.Response;

namespace API_Nomina.Controllers
{
    [ApiController]
    [Route("api/gestion")]
    public class GestionController : Controller
    {
        private readonly IGestionService gestionService;
        public GestionController(IGestionService _gestionService)
        {
            gestionService = _gestionService;
        }

        [HttpGet("area")]
        public ActionResult GetArea()
        {
            Respuesta rpta = new Respuesta();
            try
            {
                rpta = gestionService.GetAreas();
                if(rpta.Exito == 0)
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
