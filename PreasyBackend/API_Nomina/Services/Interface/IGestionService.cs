using SHARED_Nomina.Response;

namespace API_Nomina.Services.Interface
{
    public interface IGestionService
    {
        public Respuesta GetAreas();
        public Respuesta GetTurnos();
        public Respuesta GetJerarquias();
    }
}
