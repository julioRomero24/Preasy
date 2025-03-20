using API_Nomina.Actions;
using API_Nomina.Services.Interface;
using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Services
{
    public class UsuariosServices : IUsuarioService
    {
        private readonly string conexion;
        public UsuariosServices(IConfiguration config)
        {
            conexion = config.GetConnectionString("Default");
        }

        public Respuesta Login(LoginDTO dto)
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();

            try
            {
                string procedimiento = "spLogin";
                string[] param = { "user", "pass" };
                object[] objValores = new object[] { dto.UserName, dto.Password };

                rpta = get.GetProcedureParam(conexion, param, objValores, procedimiento);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }

            return rpta;
        }

        public Respuesta ListUsuarios()
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();

            try
            {
                string procedimiento = "spListUsuario";
                rpta = get.GetProcedure(procedimiento, conexion);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }

        public Respuesta AddUsuarios(UsuariosDTO dto)
        {
            Respuesta rpta = new Respuesta();
            PostDapper post = new PostDapper();

            try
            {
                string procedimiento = "spPostUsuario";
                string[] param = { "usuario", "password", "estado", "empleado", "perfil" };
                object[] objValores = new object[] {
                    dto.usuario, dto.password, dto.estado, dto.empleado, dto.perfil
                };

                rpta = post.ProcedimientoInsertar(conexion, param, objValores, procedimiento);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
