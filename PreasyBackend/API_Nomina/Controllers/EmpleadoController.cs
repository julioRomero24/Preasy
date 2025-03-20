using API_Nomina.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Controllers
{
    [ApiController]
    [Route("api/empleado")]
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadosService empleadosService;
        public EmpleadoController(IEmpleadosService _empleadosService)
        {
            empleadosService = _empleadosService;
        }

        [HttpGet]
        public IActionResult GetEmpleados() { 
            Respuesta rpta = new Respuesta();
            try
            {
                rpta = empleadosService.GetEmpleado();
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
        

        [HttpPost]
        public IActionResult PostEmpleados(EmpleadoDTO dto)
        {
            Respuesta rpta = new Respuesta();
            try
            {
                rpta = empleadosService.PostEmpleado(dto);
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

        
     

        [HttpGet("/area")]
        public IActionResult GetNameAreaById(int idArea)
        {
            Respuesta rpta = new Respuesta();
            try
            {
                rpta = empleadosService.GetNameAreaById(idArea);
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
