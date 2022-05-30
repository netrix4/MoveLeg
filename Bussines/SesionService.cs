using Dapper;
using MoveLegRef.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MoveLegRef.Bussines
{
    class SesionService : ISesionService
    {
        private readonly string _connectionString = Utils.Utils.GlobalConnectionString.ToString();

        public ServiceResponse<int> AgregarSesion(Sesion sesion)
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();

            string query = "INSERT INTO Sesion (IDPaciente, FechaDeInsercion, " +
                "RepeticionesTobillo, RepeticionesRodilla, " +
                "PorcDismVelTobillo, PorcDismVelRodilla, PorcDismMovTobillo, PorcDismDespRodilla, " +
                "VelTobilloDisminuido, VelRodillaDisminuido, MovTobilloDisminuido, DespRodillaDisminuido)" +

                "VALUES (@IDPaciente, GETDATE(), " +
                "@RepeticionesTobillo, @RepeticionesRodilla," +
                "@PorcDismVelTobillo, @PorcDismVelRodilla, @PorcDismMovTobillo, @PorcDismDespRodilla," +
                "@VelTobilloDisminuido, @VelRodillaDisminuido, @MovTobilloDisminuido, @DespRodillaDisminuido) " +
                "SELECT TOP (1) [IDSesion]  FROM [DB_MoveLeg].[dbo].[Sesion] ORDER BY [IDSesion] DESC";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    //Dapper
                    serviceResponse.Data = sqlConnection.QuerySingle<int>(query, new
                    {
                        IDPaciente = sesion.IDPaciente,
                        RepeticionesTobillo = sesion.RepeticionesTobillo,
                        RepeticionesRodilla = sesion.PorcDismDespRodilla,

                        PorcDismVelTobillo = sesion.PorcDismVelTobillo,
                        PorcDismVelRodilla = sesion.PorcDismVelRodilla,
                        PorcDismMovTobillo = sesion.PorcDismMovTobillo,
                        PorcDismDespRodilla = sesion.PorcDismDespRodilla,

                        VelTobilloDisminuido = sesion.VelTobilloDisminuido,
                        VelRodillaDisminuido = sesion.VelRodillaDisminuido,
                        MovTobilloDisminuido = sesion.MovTobilloDisminuido,
                        DespRodillaDisminuido = sesion.DespRodillaDisminuido
                    });

                    serviceResponse.Message = "Sesion agregada con exito";
                    serviceResponse.IsOk = true;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Message = "Agregado de sesion fallido (SesionService) " + ex.Message;
                serviceResponse.IsOk = false;
            }

            return serviceResponse;
        }

        public ServiceResponse<List<Sesion>> ObtenerListaDeSesiones(int idPaciente)
        {
            ServiceResponse<List<Sesion>> serviceResponse = new ServiceResponse<List<Sesion>>();
            string query = "SELECT [IDSesion], [FechaDeInsercion] "+
                                ",[RepeticionesTobillo]"+
                                ",[RepeticionesRodilla]"+
                                ",[PorcDismVelTobillo]"+
                                ",[PorcDismVelRodilla]"+
                                ",[PorcDismMovTobillo]"+
                                ",[PorcDismDespRodilla]"+
                                ",[VelTobilloDisminuido]"+
                                ",[VelRodillaDisminuido]"+
                                ",[MovTobilloDisminuido]"+
                                ",[DespRodillaDisminuido]"+
                           "FROM [DB_MoveLeg].[dbo].[Paciente] INNER JOIN [DB_MoveLeg].[dbo].[Sesion]"+
                           "ON [Sesion].[IDPaciente] = [Paciente].[IDPaciente]"+
                           "WHERE [Sesion].[IDPaciente] = @Id";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    //Dapper
                    serviceResponse.Data = (List<Sesion>)sqlConnection.Query<Sesion>(query, new {Id = idPaciente});
                    serviceResponse.Message = "Retribucion de datos exitoso";
                    serviceResponse.IsOk = true;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.IsOk = false;
                serviceResponse.Message = "Retribucion de datos fallida (SesionService) " + ex.Message;
            }
            return serviceResponse;

        }

    }
}
