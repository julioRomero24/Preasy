using Dapper;
using SHARED_Nomina.Response;
using System.Data;
using System.Data.SqlClient;

namespace API_Nomina.Actions
{
    public class GetDapper
    {
        public Respuesta GetProcedure(string procedimiento, string conexion)
        {
            Respuesta rpta = new Respuesta();
            try
            {
                using (var con = new SqlConnection(conexion))
                {
                    var resultado = con.Query(procedimiento, commandType: CommandType.StoredProcedure).ToList();
                    rpta.Data = resultado;
                    rpta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                rpta.Mensaje = Convert.ToString(ex);

            }
            return rpta;
        }

        public Respuesta GetProcedureParam(string conexion, string[] parametros, object[] objValores, string procedimiento)
        {
            Respuesta rpta = new Respuesta();
            int x = parametros.Length;
            var param = new DynamicParameters();

            try
            {
                using (var con = new SqlConnection(conexion))
                {
                    for (int i = 0; i < x; i++)
                    {
                        param.Add(parametros[i], objValores[i]);
                    }

                    var resultado = con.Query(procedimiento, param, commandType: CommandType.StoredProcedure).ToList();
                    rpta.Data = resultado;
                    rpta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }

            return rpta;
        }

        public Respuesta GetConsulta(string conexion, string sql)
        {
            Respuesta rpta = new Respuesta();
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    var lst = con.Query(sql);
                    rpta.Data = lst;
                    rpta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                rpta.Exito = 0;
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
