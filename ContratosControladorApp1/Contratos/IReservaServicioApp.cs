using ContratosControladorApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosControladorApp1.Contratos
{
    public interface IReservaServicioApp
    {
        bool RegistrarReservaServicio(ReservaServicioDTO reservaServicio);
        ReservaServicioDTO BuscarReservaServicio(int id);
        bool EliminarReservaServicio(int id);
        bool ActualizarReservaServicio(ReservaServicioDTO reservaServicio);
        IEnumerable<ReservaServicioDTO> ConsultaReservaServicios();
    }
}
