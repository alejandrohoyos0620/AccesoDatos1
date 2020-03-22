using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.Contratos
{
     public interface ICalificaciones
    {
        bool RegistrarCalificacion(CalificacionesDBModel calificacion);
        CalificacionesDBModel BuscarCalificacion(int id);
        bool EliminarCalificacion(int id);
        bool ActualizarCalificacion(CalificacionesDBModel calificacion);
        IEnumerable<CalificacionesDBModel> ConsultaCalificaciones();
    }
}

