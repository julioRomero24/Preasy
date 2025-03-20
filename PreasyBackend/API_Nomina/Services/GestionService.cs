using API_Nomina.Actions;
using API_Nomina.Services.Interface;
using SHARED_Nomina.Response;

namespace API_Nomina.Services
{
    public class GestionService : IGestionService
    {
        private readonly string conexion;
        public GestionService(IConfiguration config)
        {
            conexion = config.GetConnectionString("Default");
        }

        public Respuesta GetAreas()
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();
            try
            {
                string sql = "select * from area";
                rpta = get.GetConsulta(conexion, sql);

            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }

        public Respuesta GetTurnos()
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();
            try
            {
                string sql = "select * from turno";
                rpta = get.GetConsulta(conexion, sql);

            }
            catch (Exception ex) {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }

        public Respuesta GetJerarquias()
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();
            try
            {
                string sql = "select * from direccion";
                rpta = get.GetConsulta(conexion, sql);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
