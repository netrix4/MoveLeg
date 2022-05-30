using MoveLegRef.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoveLegRef.Bussines
{
    interface IPacienteService
    {
        public ServiceResponse<int> AgregarPaciente(Paciente paciente);
        public ServiceResponse<List<Paciente>> ObtenerListaDePacientes();
    }
}
