using System;
using System.Collections.Generic;
using System.Text;

namespace MoveLegRef.Models
{
    public class Paciente
    {
        public int IDPaciente { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Patologia { get; set; }
        public string PiernaAfectada { get; set; }

        public float AnguloCadera { get; set; }
        public float AnguloRodilla { get; set; }
        public float AnguloDorsifexion { get; set; }
        public float AnguloPlanta { get; set; }

        public float MedidaCaderaRodillaDerecha { get; set; }
        public float MedidaRodillaTobilloDerecha { get; set; }
        public float MedidaTobilloDedosDerecha { get; set; }
        public float MedidaCaderaRodillaIzq { get; set; }
        public float MedidaRodillaTobilloIzq { get; set; }
        public float MedidaTobilloDedosIzq { get; set; }

    }
}
