using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosControladorApp1.Contratos
{
    public interface ICalificacionApp
    {
        bool RegistrarCalificacion(CalificacionesDTO calificacion);
        CalificacionesDTO BuscarCalificacion(int id);
        bool EliminarCalificacion(int id);
        bool ActualizarCalificacion(CalificacionesDTO calificacion);
        IEnumerable<CalificacionesDTO> ConsultaCalificaciones();
    }
}
