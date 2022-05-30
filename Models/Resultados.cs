using System;
using System.Collections.Generic;
using System.Text;

namespace MoveLegRef.Models
{
    public class Resultados
    {
        public int IDResultados { get; set; }
        public int IDSesion { get; set; }
        public int TiempoTranscurrido { get; set; }
        public int RepeticionesLogradasRodilla { get; set; }
        public int RepeticionesLogradasTobillo { get; set; }
    }
}
