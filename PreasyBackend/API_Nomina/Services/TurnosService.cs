using API_Nomina.Actions;
using API_Nomina.Services.Interface;
using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Services
{
    public class TurnosService : ITurnosService
    {
        private readonly string conexion;

        public TurnosService(IConfiguration config)
        {
            conexion = config.GetConnectionString("Default");
        }

        public Respuesta TurnoEmpleado(TurnoEmpleadoDTO dto)
        {
            Respuesta rpta = new Respuesta();
            PostDapper post = new PostDapper();

            try
            {
                string procedimiento = "spTurnoEmpleado";
                string[] parametros = { "fecha_inicio", "fecha_final", "turno", "empleado" };
                object[] objValores = new object[]
                {
                    dto.fecha_inicio, dto.fecha_final, dto.turno, dto.empleado
                };
                rpta = post.ProcedimientoInsertar(conexion, parametros, objValores, procedimiento);

            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }

            return rpta;
        }

        public Respuesta ListTurnos()
        {
            string sql = "select * from turno";
            GetDapper get = new GetDapper();
            Respuesta rpta = new Respuesta();
            rpta = get.GetConsulta(conexion, sql);
            return rpta;
        }

        
    }
}
