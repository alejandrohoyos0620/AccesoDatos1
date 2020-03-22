using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.RkModel
{
    public  class CalificacionesDBModel
    {
        public int Id_calificacion { get; set; }
        public  int  Id_servicio { get; set; }
        public int Id_cliente { get; set; }
        public int calificacion { get; set; }
        public string comentario { get; set; }

    }
}
