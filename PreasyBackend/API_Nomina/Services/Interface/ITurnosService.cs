using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Services.Interface
{
    public interface ITurnosService
    {
        public Respuesta TurnoEmpleado(TurnoEmpleadoDTO dto);
        public Respuesta ListTurnos();
    }
}
