using MoveLegRef.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoveLegRef.Bussines
{
    interface ISesionService
    {
        public ServiceResponse<int> AgregarSesion(Sesion sesion);
        public ServiceResponse<List<Sesion>> ObtenerListaDeSesiones(int idPaciente);
    }
}
