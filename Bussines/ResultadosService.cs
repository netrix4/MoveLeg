using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using MoveLegRef.Models;

namespace MoveLegRef.Bussines
{
    class ResultadosService : IResultadosSesion
    {
        private readonly string _connectionString = Utils.Utils.GlobalConnectionString.ToString();
        public ServiceResponse<List<Resultados>> ObtenerResultados(int idSesion)
        {
            ServiceResponse<List<Resultados>> serviceResponse = new ServiceResponse<List<Resultados>>();
            
            string query = "SELECT * FROM [DB_MoveLeg].[dbo].[Resultados] WHERE [IDSesion] = @IDSesion";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    //Dapper
                    serviceResponse.Data = (List<Resultados>)sqlConnection.Query<Resultados>(query, new { IDSesion = idSesion });
                    serviceResponse.Message = "Retribucion de datos exitoso";
                    serviceResponse.IsOk = true;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.IsOk = false;
                serviceResponse.Message = "Retribucion de datos fallida (ResultadosSesionService) " + ex.Message;
            }
            return serviceResponse;

        }
        public ServiceResponse<int> AgregarResultadosSesion(Resultados resultados)
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();

            string query = "INSERT INTO Resultados (IDSesion, TiempoTranscurrido, " +
                "RepeticionesLogradasRodilla, RepeticionesLogradasTobillo) " +

                "VALUES (@IDSesion, @TiempoTranscurrido, " +
                "@RepeticionesLogradasRodilla, @RepeticionesLogradasTobillo)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    //Dapper
                    serviceResponse.Data = sqlConnection.Execute(query, new
                    {
                        IDSesion = resultados.IDSesion,
                        TiempoTranscurrido = resultados.TiempoTranscurrido,
                        RepeticionesLogradasRodilla = resultados.RepeticionesLogradasRodilla,
                        RepeticionesLogradasTobillo = resultados.RepeticionesLogradasTobillo
                    });

                    serviceResponse.Message = "Resultados de sesion agregados con exito";
                    serviceResponse.IsOk = true;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Message = "Agregado de resultados de sesion fallido (SesionService) " + ex.Message;
                serviceResponse.IsOk = false;
            }

            return serviceResponse;
        }
    }
}
