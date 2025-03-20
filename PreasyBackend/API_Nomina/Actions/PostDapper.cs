using Dapper;
using SHARED_Nomina.Response;
using System.Data.SqlClient;
using System.Data;

namespace API_Nomina.Actions
{
    public class PostDapper
    {
        public Respuesta ProcedimientoInsertar(string conexion, string[] parametros, object[] objValores, string procedimiento)
        {
            //var con = new SqlConnection(conexion);
            int x = parametros.Length;
            var param = new DynamicParameters();

            Respuesta rpta = new Respuesta();
            try
            {
                using (var con = new SqlConnection(conexion))
                {

                    for (int i = 0; i < x; i++)
                    {
                        param.Add(parametros[i], objValores[i]);
                    }

                    con.Execute(procedimiento, param, commandType: CommandType.StoredProcedure);
                }


                rpta.Exito = 1;

            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }

            return rpta;
        }

        public Respuesta ProcedimientoInsertarRetorno(string conexion, string[] parametros, object[] objValores, string procedimiento)
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


        /*public Respuesta procedimientoActualizar(string conexion, string[] parametros, object[] objValores, string procedimiento)
        {

        }*/
    }
}
