using ContratoAccesoDatos1.RkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoAccesoDatos1.Contratos
{
     public interface IReserva
    {
        bool RegistrarReserva(ReservaDBModel reserva);
        ReservaDBModel BuscarReserva(int id);
        bool EliminarReserva(int id);
        bool ActualizarReserva(ReservaDBModel reserva);
        IEnumerable<ReservaDBModel> ConsultaReserva();
    }

}
