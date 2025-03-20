using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Services.Interface
{
    public interface IEmpleadosService
    {
        public Respuesta GetEmpleado();
        public Respuesta PostEmpleado(EmpleadoDTO dto);
       
        public Respuesta GetNameAreaById(int idArea); //public Respuesta GetAreaDeEmpleadoById(int idArea);//nombre del area del empleado
        //public Respuesta EditarEmpleado(int idEmpleado, string? documento=null, int? tipo_doc=null, string? nombre=null, string? apellido=null, string? titulo=null, float? salario_basico=null, float? salario_hora=null, int? area=null );
    }
}
