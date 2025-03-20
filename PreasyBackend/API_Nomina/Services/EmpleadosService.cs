using API_Nomina.Actions;
using API_Nomina.Services.Interface;
using Dapper;
using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;
using System.Data.SqlClient;

namespace API_Nomina.Services
{
    public class EmpleadosService : IEmpleadosService
    {
        private readonly string conexion;
        public EmpleadosService(IConfiguration config)
        {
            conexion = config.GetConnectionString("Default");
        }

       
        public Respuesta GetEmpleado()
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();

            try
            {
           
                string procedimiento = "spListEmpleados";
                rpta = get.GetProcedure(procedimiento, conexion);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }

        public Respuesta PostEmpleado(EmpleadoDTO dto)
        {
            Respuesta rpta = new Respuesta();
            PostDapper post = new PostDapper(); 
            try
            {
                string procedimiento = "spPostEmpleado";
                string[] parametros = {
                    "documento", "tipo_doc", "nombre", "apellido", "titulo", "salario_basico", "salario_hora", "area"
                };
                object[] objValores = new object[] {
                    dto.documento, dto.tipo_doc, dto.nombre, dto.apellido, dto.titulo, dto.salario_basico, dto.salario_hora, dto.area
                };
                rpta = post.ProcedimientoInsertar(conexion, parametros, objValores, procedimiento);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }

        
        
        public Respuesta GetNameAreaById(int idArea)
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();

            try
            {
                string procedimiento = "getNameAreById";
                // Define los nombres de los parámetros y sus valores
                string[] parametros = { "@idArea" };  // Nombre del parámetro en el SQL
                object[] objValores = { idArea };     // Valor del parámetro idArea

                // Llama a GetProcedureParam y pasa los parámetros y sus valores
                rpta = get.GetProcedureParam(conexion, parametros, objValores, procedimiento);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }

            return rpta;
    
        }

        /*public Respuesta EditarEmpleado(int idEmpleado, string? documento = null, int? tipo_doc = null, string? nombre = null, string? apellido = null, string? titulo = null, float? salario_basico = null, float? salario_hora = null, int? area = null)
        {
            Respuesta rpta = new Respuesta();
            PostDapper post = new PostDapper();
            
            List<string> parametros = new List<string>();
            List<object> objValores = new List<object>();

            // Agrega los campos que se quieren actualizar, dependiendo de los parámetros no nulos

            if (documento!=null)
            {
                parametros.Add("documento");
                objValores.Add(documento);
               
                /*camposActualizar.Add("documento= @documento");
                parametros.Add("@documento",documento);
            }
            if (tipo_doc!=null)
            {
                parametros.Add("tipo_doc");
                objValores.Add(tipo_doc);
                /*camposActualizar.Add("tipo_doc=@tipo_doc");
                parametros.Add("@tipo_doc", tipo_doc);
            }      
            if (nombre != null)
            {
                parametros.Add("nombre");
                objValores.Add(nombre);


                /*
                camposActualizar.Add("nombre = @nombre");
                parametros.Add("@nombre", nombre);
            }
            if (apellido!=null)
            {
                parametros.Add("apellido");
                objValores.Add(apellido);
                /*camposActualizar.Add("apellido=@apellido");
                parametros.Add("@apellido", apellido);
            }
            if (titulo != null)
            {
                parametros.Add("titulo");
                objValores.Add(titulo);
                /*camposActualizar.Add("titulo = @titulo");
                parametros.Add("@titulo", titulo);
            }
            if (salario_basico != null)
            {
                parametros.Add("salario_basico");
                objValores.Add(salario_basico);
                /*camposActualizar.Add("salario_basico = @salario_basico");
                parametros.Add("@salario_basico", salario_basico);
            }
            if (salario_hora != null)
            {
                parametros.Add("salario_hora");
                objValores.Add(salario_hora);
                /*camposActualizar.Add("salario_hora = @salario_hora");
                parametros.Add("@salario_hora", salario_hora);
            }
            if (area != null)
            {
                parametros.Add("area");
                objValores.Add(area);
                /*camposActualizar.Add("area = @area");
                parametros.Add("@area", area);
            }


            // Asegura que se hayan especificado campos para actualizar
            if (!objValores.Any())
                throw new ArgumentException("No se especificaron campos para actualizar.");

            rpta = post.procedimientoActualizar(conexion,parametros,objValores, procedimiento);


            // Construcción dinámica de la consulta
            var query = $@"UPDATE Empleados 
                   SET {string.Join(", ", camposActualizar)} 
                   WHERE Id = @Id";

            parametros.Add("@Id", idEmpleado);

            // Conexión y ejecución
            using (var connection = new SqlConnection("TuCadenaDeConexion"))
            {
                connection.Execute(query, parametros);
            }
            return null;
        */
       
    }
}
