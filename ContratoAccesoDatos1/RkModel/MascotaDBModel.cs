using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.RkModel
{
    public class MascotaDBModel
    {
        public int Id_mascota { get; set; }
        public int Id_dueño { get; set; }
        public string Nombre_mascota { get; set; }
        public string Raza { get; set; }
        public string Pdf_canet { get; set; }

    }
}