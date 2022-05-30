using System;
using System.Collections.Generic;
using System.Text;

namespace MoveLegRef.Models
{
    public class Sesion
    {
        public int IDSesion { get; set; }
        public int IDPaciente { get; set; }
        public DateTime FechaDeInsercion { get; set; }
        public int RepeticionesTobillo { get; set; }
        public int RepeticionesRodilla { get; set; }

        //public float PromVelTobilloFlexion { get; set; }
        //public float PromVelTobilloDorsiflexion { get; set; }

        //public float PromVelRodillaFlexion { get; set; }
        //public float PromVelRodillaEstiramiento { get; set; }

        //public int DezplTobillo { get; set; }
        //public int DezplRodilla { get; set; }

        //Valores con la disminucion
        public int PorcDismVelTobillo { get; set; }
        public int PorcDismVelRodilla { get; set; }
        public int PorcDismMovTobillo { get; set; }
        public int PorcDismDespRodilla { get; set; }


        public float VelTobilloDisminuido { get; set; }
        public float VelRodillaDisminuido { get; set; }
        public float MovTobilloDisminuido { get; set; }
        public float DespRodillaDisminuido { get; set; }
    }
}
