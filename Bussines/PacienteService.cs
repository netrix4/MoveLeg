using Dapper;
using MoveLegRef.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Linq;
using System.Text;

namespace MoveLegRef.Bussines
{
    class PacienteService : IPacienteService
    {
        private readonly string connectionString = Utils.Utils.GlobalConnectionString.ToString();

        public ServiceResponse<int> AgregarPaciente(Paciente paciente)
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();
            string query = "INSERT INTO Paciente (Nombre, Edad, Patologia, PiernaAfectada, AnguloFlexionCadera, AnguloFlexionRodilla, AnguloDorsifexion, AnguloPlantarFlexion, " +
                "LongCRI, LongRTI, LongTPI, LongCRD, LongRTD, LongTPD) " +
                "VALUES (@Nombre, @Edad, @Patologia, @PiernaAfectada, @AnguloCadera, @AnguloRodilla, @AnguloDorsifexion, @AnguloPlanta, " +
                "@MedidaCaderaRodillaDerecha, @MedidaRodillaTobilloDerecha, @MedidaTobilloDedosDerecha, " +
                "@MedidaCaderaRodillaIzq, @MedidaRodillaTobilloIzq, @MedidaTobilloDedosIzq)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    //Dapper
                    serviceResponse.Data = sqlConnection.Execute(query, new
                    {
                        Nombre = paciente.Nombre,
                        Edad = paciente.Edad.ToString(),
                        Patologia = paciente.Patologia,
                        PiernaAfectada = paciente.PiernaAfectada,
                        AnguloCadera = paciente.AnguloCadera.ToString(),
                        AnguloRodilla = paciente.AnguloRodilla.ToString(),
                        AnguloDorsifexion = paciente.AnguloDorsifexion.ToString(),
                        AnguloPlanta = paciente.AnguloPlanta.ToString(),
                        MedidaCaderaRodillaDerecha = paciente.MedidaCaderaRodillaDerecha,
                        MedidaRodillaTobilloDerecha = paciente.MedidaRodillaTobilloDerecha,
                        MedidaTobilloDedosDerecha = paciente.MedidaTobilloDedosDerecha,
                        MedidaCaderaRodillaIzq = paciente.MedidaCaderaRodillaIzq,
                        MedidaRodillaTobilloIzq = paciente.MedidaRodillaTobilloIzq,
                        MedidaTobilloDedosIzq = paciente.MedidaTobilloDedosIzq
                    });

                    serviceResponse.Message = "Paciente agregado con exito";
                    serviceResponse.IsOk = true;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Message = "Agregado de paciente fallido (DaperManager) " + ex.Message;
                serviceResponse.IsOk = false;
            }

            return serviceResponse;
        }
        public ServiceResponse<List<Paciente>> ObtenerListaDePacientes()
        {
            ServiceResponse<List<Paciente>> serviceResponse = new ServiceResponse<List<Paciente>>();

            //serviceResponse.Data.Where((paciente) => paciente.Edad == 6);
            //serviceResponse.Data.Select((p) => 
            //    new {
            //        test = "",
            //        p.AnguloDorsifexion,
            //        p.Edad
            //    }
            //);

            string query = "SELECT * FROM [DB_MoveLeg].[dbo].[Paciente] ORDER BY [IDPaciente]";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    //Dapper
                    serviceResponse.Data = (List<Paciente>)sqlConnection.Query<Paciente>(query);
                    serviceResponse.Message = "Retribucion de datos exitoso";
                    serviceResponse.IsOk = true;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.IsOk = false;
                serviceResponse.Message = "Retribucion de datos fallida (PacienteService) " + ex.Message;
            }
            return serviceResponse;
        }

    }
}
