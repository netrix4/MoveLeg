using MoveLegRef.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoveLegRef.Bussines
{
    interface IResultadosSesion
    {
        public ServiceResponse<int> AgregarResultadosSesion(Resultados resultados);
        public ServiceResponse<List<Resultados>> ObtenerResultados(int idSesion);

    }
}
