using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.Contratos
{
     public interface IReservaServicios
    {
        bool RegistrarReservaServicio(ReservaServicioDBModel reservaServicio);
        ReservaServicioDBModel BuscarReservaServicio(int id);
        bool EliminarReservaServicio(int id);
        bool ActualizarReservaServicio(ReservaServicioDBModel reservaServicio);
        IEnumerable<ReservaServicioDBModel> ConsultaReservaServicios();
    }


}
