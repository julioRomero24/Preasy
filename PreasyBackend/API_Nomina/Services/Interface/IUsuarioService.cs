using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Services.Interface
{
    public interface IUsuarioService
    {
        public Respuesta Login(LoginDTO dto);

        public Respuesta ListUsuarios();
        public Respuesta AddUsuarios(UsuariosDTO dto);
    }
}
